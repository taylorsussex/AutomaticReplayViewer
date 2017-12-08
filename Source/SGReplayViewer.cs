using InputManager;
using System;
using System.Threading;
using System.Windows.Forms;

class SGReplayViewer : ReplayViewer
{
    public SGReplayViewer() : base("Skullgirls", "Skullgirls", false)
    {
    }

    public void StartLoop(int ReplaysToPlay, Keys inputLK, Keys inputRight, Keys RecordStart, Keys RecordStop)
    {
        NoErrors = true;
        getProcess();
        LK = inputLK;
        Right = inputRight;
        
        if (NoErrors)
        {
            pointer = findPointer(new int[1] { 3909632 });
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
        if (readMemory(pointer) == 0x3F666666)
        {
            menu = true;
            return;
        }
        menu = false;
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

    private Keys LK = Keys.Z;
    private Keys Right = Keys.Right;
    private int pointer;
    private bool NoErrors;
}
