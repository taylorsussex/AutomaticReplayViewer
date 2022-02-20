using InputManager;
using System;
using System.Threading;
using System.Windows.Forms;

class BBCFReplayViewer : ReplayViewer
{
    public BBCFReplayViewer() : base("BBCF", "BlazBlue Centralfiction", true)
    {
    }

    public void StartLoop(int ReplaysToPlay, Keys inputUp, Keys inputConfirm, Keys inputGauge, Keys inputWindow, Keys RecordStart, Keys RecordStop, bool gauge, bool window)
    {
        NoErrors = true;
        getProcess();
        Up = inputUp;
        Confirm = inputConfirm;
        Gauge = inputGauge;
        Window = inputWindow;
        hideGauge = gauge;
        hideWindow = window;

        if (NoErrors)
        {
            // Get pointers
            MenuState = findPointer(GetPointerArray("BBCFMenuState"));

            ReplayPlaying = findPointer(GetPointerArray("BBCFReplayPlaying"));

            // Make sure user is in replay menu before proceeding
            if (readMemory(MenuState) != 4)
            {
                ProgressText = "Please start at the replay menu";
                OnLoopEnd(new EventArgs());
                return;
            }

            // Find initReplay
            ReplayCursorPointer = findPointer(GetPointerArray("BBCFCursor"));
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

        //int outro = readMemory(OutroPlaying);
        //if (outro == 0 || outro == 4)
        //{
        //    Keyboard.KeyDown(Confirm);
        //    Thread.Sleep(50);
        //    Keyboard.KeyUp(Confirm);
        //}
    }

    protected override void NavigateDefault()
    {
        // Find current replay to navigate to
        currentReplay = initReplay - ReplaysPlayed + 1;

        // Find current cursor pointer
        //ReplayCursorPointer = findPointer(cursor);

        // Write to memory to go to replay location
        writeMemory(ReplayCursorPointer, currentReplay);

        // Input keystrokes to play selected replay
        Thread.Sleep(50);
        Keyboard.KeyDown(Confirm);
        Thread.Sleep(50);
        Keyboard.KeyUp(Confirm);
        Thread.Sleep(50);
        Keyboard.KeyDown(Up);
        Thread.Sleep(50);
        Keyboard.KeyUp(Up);
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
            if (readMemory(ReplayPlaying) == 1)
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
                return;
            }
        }
    }

    protected override void GameNotOpen()
    {
        base.GameNotOpen();
        ProgressText = "BBCF was not open";
        NoErrors = false;
    }

    private bool NoErrors;
    private bool hideGauge;
    private bool hideWindow;

    private Keys Up = Keys.W;
    private Keys Confirm = Keys.J;
    private Keys Gauge = Keys.U;
    private Keys Window = Keys.I;

    private int MenuState;
    private int ReplayCursorPointer;
    private int ReplayPlaying;
    private int initReplay;
    private int currentReplay;
}