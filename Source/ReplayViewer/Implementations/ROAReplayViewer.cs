using InputManager;
using System;
using System.Threading;
using System.Windows.Forms;

class ROAReplayViewer : ReplayViewer
{
    public ROAReplayViewer() : base("RivalsofAether", "Rivals of Aether", true)
    {
    }

    public void StartLoop(int ReplaysToPlay, Keys inputStart, Keys inputL, Keys RecordStart, Keys RecordStop)
    {
        NoErrors = true;
        getProcess();

        Start = inputStart;
        L = inputL;

        if (NoErrors)
        {
            // Notes to make cursor pointer easier to find
            // X cursor - float: bound between 0 and 936
            // Y cursor - float: bound between 0 and 468
            pointerMenuState = findPointer(GetPointerArray("ROAMenuState"));
            pointerCursorX = findPointer(GetPointerArray("ROACursorX"));
            pointerCursorY = findPointer(GetPointerArray("ROACursorY"));

            float posX = readMemoryFloat(pointerCursorX);
            float posY = readMemoryFloat(pointerCursorY);

            posX = ClosestPosition(posX, menuPositionX, ref cellX);
            posY = ClosestPosition(posY, menuPositionY, ref cellY);
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
        menu = (readMemory(pointerMenuState) == 57);
        if (readMemory(pointerMenuState) == 9)
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
        float posX = 0, posY = 0;

        currentCell = initCell - ReplaysPlayed + 1;
        if (currentCell < 0)
        {
            currentCell = 15;
            initCell += 16;
            Keyboard.KeyDown(L);
            Thread.Sleep(50);
            Keyboard.KeyUp(L);
        }
        Cell2Position(currentCell, ref posX, ref posY);
        MoveCursor(posX, posY);

        Thread.Sleep(50);
        Keyboard.KeyDown(Start);
        Thread.Sleep(50);
        Keyboard.KeyUp(Start);
        Thread.Sleep(50);
        Keyboard.KeyDown(Start);
        Thread.Sleep(50);
        Keyboard.KeyUp(Start);
    }
	
	private void MoveCursor(float targetX, float targetY)
	{
        writeMemory(findPointer(GetPointerArray("ROACursorX")), targetX);
        writeMemory(findPointer(GetPointerArray("ROACursorY")), targetY);
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

    private float ClosestPosition(float inputPosition, float[] positionArray, ref int cell)
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

    private void Cell2Position(int cell, ref float posX, ref float posY)
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

    private float[] menuPositionX = new float[4] { 530, 640, 750, 860 };
    private float[] menuPositionY = new float[4] { 150, 225, 300, 375 };

    private Keys Start = Keys.Return;
    private Keys L = Keys.A;
}