using InputManager;
using System;
using System.Threading;
using System.Windows.Forms;

class GGXrdReplayViewer : ReplayViewer
{
    public GGXrdReplayViewer() : base("GuiltyGearXrd", "Guilty Gear Xrd Rev 2", true)
    {
    }

    public void StartLoop(int ReplaysToPlay, Keys inputConfirm, Keys inputGauge, Keys inputWindow, Keys inputInputs, Keys RecordStart, Keys RecordStop, bool gauge, bool window, bool inputs)
    {
        NoErrors = true;
        getProcess();
        Confirm = inputConfirm;
        Gauge = inputGauge;
        Window = inputWindow;
        Inputs = inputInputs;
        hideGauge = gauge;
        hideWindow = window;
        hideInputs = inputs;

        if (NoErrors)
        {
            // Get pointers
            MenuState = findPointer(GetPointerArray("GGXrdMenuState"));

            // Notes:
            // 8 -> outro not playing
            // 4 -> P2 outro playing
            // 0 -> P1 outro playing
            OutroPlaying = findPointer(GetPointerArray("GGXrdOutroPlaying"));

            // Make sure user is in replay menu before proceeding
            if (readMemory(MenuState) != 4)
            {
                ProgressText = "Please start at the replay menu";
                OnLoopEnd(new EventArgs());
                return;
            }

            // Find initReplay
            cursor = GetPointerArray("GGXrdCursor");
            ReplayCursorPointer = findPointer(cursor);
            initReplay = readMemory(ReplayCursorPointer);

            // Limit amount of replays if not enough exist
            if (initReplay + 1 < ReplaysToPlay)
                ReplaysToPlay = initReplay + 1;

            LoopThread = new Thread(() => PlaybackLoop(ReplaysToPlay, RecordStart, RecordStop));
            LoopThread.Start();
        }
        else
        {
            OnLoopEnd(new EventArgs());
        }
    }

    protected override void MenuStateActive(ref bool menu)
    {
        menu = (readMemory(MenuState) == 4);

        int outro = readMemory(OutroPlaying);
        if (outro == 0 || outro == 4)
        {
            Keyboard.KeyDown(Confirm);
            Thread.Sleep(50);
            Keyboard.KeyUp(Confirm);
        }
    }

    protected override void NavigateDefault()
    {
        // Find current replay to navigate to
        currentReplay = initReplay - ReplaysPlayed + 1;

        // Find current cursor pointer
        ReplayCursorPointer = findPointer(cursor);

        // Write to memory to go to replay location
        writeMemory(ReplayCursorPointer, currentReplay);

        // Input keystrokes to play selected replay
        Thread.Sleep(50);
        Keyboard.KeyDown(Confirm);
        Thread.Sleep(50);
        Keyboard.KeyUp(Confirm);
    }

    protected override void InMatchInputs()
    {
        while (ProcessRunning)
        {
            // Check if replay has loaded
            if (readMemory(MenuState) == 2)
            {
                Thread.Sleep(100);
                if (hideWindow)
                {
                    Keyboard.KeyDown(Window);
                    Thread.Sleep(100);
                    Keyboard.KeyUp(Window);
                }
                if (hideGauge)
                {
                    Keyboard.KeyDown(Gauge);
                    Thread.Sleep(100);
                    Keyboard.KeyUp(Gauge);
                }
                if (hideInputs)
                {
                    Keyboard.KeyDown(Inputs);
                    Thread.Sleep(100);
                    Keyboard.KeyUp(Inputs);
                }
                return;
            }
        }
    }

    protected override void GameNotOpen()
    {
        base.GameNotOpen();
        ProgressText = "GGXrd was not open";
        NoErrors = false;
    }

    private bool NoErrors;
    private bool hideGauge;
    private bool hideWindow;
    private bool hideInputs;

    private Keys Confirm = Keys.U;
    private Keys Gauge = Keys.J;
    private Keys Window = Keys.I;
    private Keys Inputs = Keys.L;

    private int MenuState;
    private int ReplayCursorPointer;
    private int OutroPlaying;
    private int initReplay;
    private int currentReplay;

    private int[] cursor;
}