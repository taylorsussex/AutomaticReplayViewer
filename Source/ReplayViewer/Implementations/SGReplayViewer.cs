using InputManager;
using System;
using System.Configuration;
using System.Threading;
using System.Windows.Forms;

class SGReplayViewer : ReplayViewer
{
    public SGReplayViewer() : base("Skullgirls", "Skullgirls", false)
    {
    }

    public void StartLoop(int ReplaysToPlay, Keys inputLP, Keys inputLK, Keys inputMP, Keys inputRight, Keys RecordStart, Keys RecordStop, bool Hitboxes, bool Inputs, bool AttackData)
    {
        NoErrors = true;
        getProcess();
        LP = inputLP;
        LK = inputLK;
        MP = inputMP;
        Right = inputRight;
        DisplayHitboxes = Hitboxes;
        DisplayInputs = Inputs;
        DisplayAttackData = AttackData;
        
        if (NoErrors)
        {
            pointer = findPointer(new int[1] { Int32.Parse(ConfigurationManager.AppSettings["SGMenuState"]) });
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
        menu = (readMemory(pointer) == 0x3F666666);
    }

    protected override void NavigateDefault()
    {
        // Input keystrokes for menu navigation
        Thread.Sleep(100);
        Keyboard.KeyDown(LK);
        Thread.Sleep(100);
        Keyboard.KeyUp(LK);
        Keyboard.KeyDown(Right);
        Thread.Sleep(100);
        Keyboard.KeyUp(Right);
        Keyboard.KeyDown(LK);
        Thread.Sleep(100);
        Keyboard.KeyUp(LK);
    }

    protected override void GameNotOpen()
    {
        base.GameNotOpen();
        ProgressText = "SG was not open";
        NoErrors = false;
    }

    protected override void InMatchInputs()
    {
        Thread.Sleep(100);
        if (DisplayHitboxes)
        {
            Keyboard.KeyDown(LP);
            Thread.Sleep(100);
            Keyboard.KeyUp(LP);
        }
        if (DisplayInputs)
        {
            Keyboard.KeyDown(LK);
            Thread.Sleep(100);
            Keyboard.KeyUp(LK);
        }
        if (DisplayAttackData)
        {
            Keyboard.KeyDown(MP);
            Thread.Sleep(100);
            Keyboard.KeyUp(MP);
        }
    }

    private Keys LP = Keys.A;
    private Keys LK = Keys.Z;
    private Keys MP = Keys.S;
    private Keys Right = Keys.Right;
    private int pointer;
    private bool NoErrors;
    private bool DisplayHitboxes;
    private bool DisplayInputs;
    private bool DisplayAttackData;
}