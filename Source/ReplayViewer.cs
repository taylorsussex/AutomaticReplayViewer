using InputManager;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

abstract class ReplayViewer : MemoryReader
{
    public ReplayViewer(string processName, string gameName, bool write) : base(processName, gameName, write)
    {
    }

    protected void FocusWindow()
    {
        SetForegroundWindow(hWnd);
        ShowWindowAsync(hWnd, SW_RESTORE);

        while (ProcessRunning)
        {
            if (GetForegroundWindow() == hWnd)
            {
                Thread.Sleep(500);
                break;
            }
        }
    }

    protected void PlaybackLoop(int ReplaysToPlay, Keys RecordStart, Keys RecordStop)
    {
        ProcessRunning = true;
        bool menu = false;
        bool IsLoading = false;
        ReplaysPlayed = 0;

        try
        {
            FocusWindow();

            // Start recording hotkey
            if (RecordStart != Keys.None && RecordStop != Keys.None)
                Keyboard.KeyPress(RecordStart);

            // Main loop
            while (ProcessRunning)
            {
                MenuStateActive(ref menu);

                Thread.Sleep(500);

                if (!IsLoading && menu)
                {
                    ReplaysPlayed++;
                    // Check if all the replays have been played
                    if (ReplaysPlayed > ReplaysToPlay)
                    {
                        ProgressText = "Queue finished";
                        break;
                    }

                    ProgressText = "Viewing replay " + ReplaysPlayed.ToString() + " / " + ReplaysToPlay.ToString();

                    // Navigate to next replay in game
                    NavigateDefault();
                    IsLoading = true;
                }
                else if (IsLoading && !menu)
                {
                    IsLoading = false;
                    InMatchInputs();
                }
            }
        }
        catch (IndexOutOfRangeException)
        {
            GameNotOpen();
        }

        // Stop recording hotkey
        if (RecordStart != Keys.None && RecordStop != Keys.None)
            Keyboard.KeyPress(RecordStop);

        if (ReplaysPlayed <= ReplaysToPlay)
        {
            ProgressText = "Queue interrupted";
        }

        ProcessRunning = false;
        LoopEnded?.Invoke(this, new EventArgs());
    }

    protected override void GameNotOpen()
    {
        base.GameNotOpen();
        ProcessRunning = false;
    }

    protected abstract void NavigateDefault();
    protected abstract void MenuStateActive(ref bool menu);

    protected virtual void InMatchInputs()
    {
    }

    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    private static extern bool SetForegroundWindow(IntPtr hWnd);

    [DllImport("user32.dll")]
    private static extern bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);

    [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
    private static extern IntPtr GetForegroundWindow();

    public bool ProcessRunning;

    private string _progressText;
    public string ProgressText
    {
        get { return _progressText; }
        set
        {
            _progressText = value;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ProgressText"));
        }
    }

    public event PropertyChangedEventHandler PropertyChanged;
    public event EventHandler LoopEnded;

    protected virtual void OnLoopEnd(EventArgs e)
    {
        LoopEnded?.Invoke(this, e);
    }

    protected Thread LoopThread;
    protected int ReplaysPlayed;
}