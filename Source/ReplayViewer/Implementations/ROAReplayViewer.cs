using InputManager;
using System;
using System.Threading;
using System.Windows.Forms;

class ROAReplayViewer : ReplayViewer
{
    public ROAReplayViewer() : base("RivalsofAether", "Rivals of Aether", false)
    {
    }

    public void StartLoop(int ReplaysToPlay, Keys inputUp, Keys inputDown, Keys inputLeft, Keys inputRight, Keys inputStart, Keys inputL, Keys RecordStart, Keys RecordStop)
    {
        NoErrors = true;
        getProcess();

        Up = inputUp;
        Down = inputDown;
        Left = inputLeft;
        Right = inputRight;
        Start = inputStart;
        L = inputL;

        if (NoErrors)
        {
            pointerMenuState = findPointer(0x99D15A8);
            pointerCursorX = findPointer(new int[6] { 0x09A16944, 0x80, 0x44, 0x10, 0x628, 0 });
            pointerCursorY = findPointer(new int[6] { 0x09A16944, 0x80, 0x44, 0x10, 0x220, 0 });

            initMenuState = readMemory(pointerMenuState);
            double posX = readMemoryDouble(pointerCursorX);
            double posY = readMemoryDouble(pointerCursorY);

            posX = closestPosition(posX, menuPositionX, ref cellX);
            posY = closestPosition(posY, menuPositionY, ref cellY);
            initCell = cellX + 4 * cellY;

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
        menu = (readMemory(pointerMenuState) == initMenuState);
        if (readMemory(pointerMenuState) == initMenuState - 2)
        {
            Keyboard.KeyDown(Start);
            Thread.Sleep(50);
            Keyboard.KeyUp(Start);
        }
    }

    protected override void NavigateDefault()
    {
        Thread.Sleep(500);

        // Input keystrokes for menu navigation
        double posX = 0, posY = 0;

        currentCell = initCell - ReplaysPlayed + 1;
        if (currentCell < 0)
        {
            currentCell = 15;
            initCell += 16;
            Keyboard.KeyDown(L);
            Thread.Sleep(50);
            Keyboard.KeyUp(L);
        }
        cell2position(currentCell, ref posX, ref posY);
        MoveCursor(posX, posY);

        Keyboard.KeyDown(Start);
        Thread.Sleep(50);
        Keyboard.KeyUp(Start);
        Thread.Sleep(50);
        Keyboard.KeyDown(Start);
        Thread.Sleep(50);
        Keyboard.KeyUp(Start);
    }
	
	private void MoveCursor(double targetX, double targetY)
	{
        pointerCursorX = findPointer(new int[6] { 0x09A16944, 0x80, 0x44, 0x10, 0x628, 0 });
        pointerCursorY = findPointer(new int[6] { 0x09A16944, 0x80, 0x44, 0x10, 0x220, 0 });

        double position;

        while (ProcessRunning)
        {
            position = readMemoryDouble(pointerCursorX);

            if (position - targetX > 15)
            {
                Keyboard.KeyDown(Left);
                Thread.Sleep(50);
                Keyboard.KeyUp(Left);
            } else if (position - targetX < -15)
            {
                Keyboard.KeyDown(Right);
                Thread.Sleep(50);
                Keyboard.KeyUp(Right);
            } else
            {
                break;
            }
        }
        while (ProcessRunning)
        {
            position = readMemoryDouble(pointerCursorY);

            if (position - targetY > 15)
            {
                Keyboard.KeyDown(Up);
                Thread.Sleep(50);
                Keyboard.KeyUp(Up);
            }
            else if (position - targetY < -15)
            {
                Keyboard.KeyDown(Down);
                Thread.Sleep(50);
                Keyboard.KeyUp(Down);
            }
            else
            {
                break;
            }
        }
    }

    protected override void GameNotOpen()
    {
        base.GameNotOpen();
        ProgressText = "ROA was not open";
        NoErrors = false;
    }

    protected override void InMatchInputs()
    {

    }

    private double closestPosition(double inputPosition, double[] positionArray, ref int cell)
    {
        if (inputPosition < (positionArray[0] + positionArray[1]) / 2)
        {
            cell = 0;
            return positionArray[0];
        }
        else if (inputPosition < (positionArray[1] + positionArray[2]) / 2)
        {
            cell = 1;
            return positionArray[1];
        }
        else if (inputPosition < (positionArray[2] + positionArray[3]) / 2)
        {
            cell = 2;
            return positionArray[2];
        }
        cell = 3;
        return positionArray[3];
    }

    private void cell2position(int cell, ref double posX, ref double posY)
    {
        int cellX = cell % 4;
        int cellY = (cell - cellX) / 4;
        posX = menuPositionX[cellX];
        posY = menuPositionY[cellY];
    }

    private int pointerMenuState;
    private int pointerCursorX;
    private int pointerCursorY;
    private int currentCell;
    private int initCell;
    private int cellX;
    private int cellY;
    private bool NoErrors;

    private int initMenuState;
    private double[] menuPositionX = new double[4] { 565, 675, 785, 895 };
    private double[] menuPositionY = new double[4] { 175, 250, 325, 400 };

    private Keys Start = Keys.Return;
    private Keys L = Keys.A;
    private Keys Up = Keys.Up;
    private Keys Down = Keys.Down;
    private Keys Left = Keys.Left;
    private Keys Right = Keys.Right;
}