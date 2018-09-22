using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public class MemoryReader
{
	public MemoryReader(string processName, string gameName, bool write)
	{
        game = gameName;
        pName = processName;
        canWrite = write;
    }

    protected void getProcess()
    {
        try
        {
            process = Process.GetProcessesByName(pName)[0];
            pHandle = (int)OpenProcess(canWrite ? PROCESS_ALL_ACCESS : PROCESS_WM_READ, false, process.Id);
            hWnd = process.MainWindowHandle;
        }
        catch (IndexOutOfRangeException)
        {
            GameNotOpen();
        }
    }

    protected int readMemory(int targetAddress)
    {
        ReadProcessMemory(pHandle, targetAddress, buffer, buffer.Length, ref bytesRead);
        return BitConverter.ToInt32(buffer, 0);
    }

    protected double readMemoryDouble(int targetAddress)
    {
        byte[] doubleBuffer = new byte[8];
        ReadProcessMemory(pHandle, targetAddress, doubleBuffer, doubleBuffer.Length, ref bytesRead);
        return BitConverter.ToDouble(doubleBuffer, 0);
    }

    protected float readMemoryFloat(int targetAddress)
    {
        ReadProcessMemory(pHandle, targetAddress, buffer, buffer.Length, ref bytesRead);
        return BitConverter.ToSingle(buffer, 0);
    }

    protected void writeMemory(int targetAddress, int value)
    {
        if (!canWrite)
            return;

        buffer = BitConverter.GetBytes(value);
        WriteProcessMemory(pHandle, targetAddress, buffer, buffer.Length, ref bytesWritten);
    }

    protected void writeMemory(int targetAddress, float value)
    {
        if (!canWrite)
            return;

        buffer = BitConverter.GetBytes(value);
        WriteProcessMemory(pHandle, targetAddress, buffer, buffer.Length, ref bytesWritten);
    }

    // Offset from base process handle if no string is given
    protected int findPointer(int[] offset)
    {
        int pointer = process.MainModule.BaseAddress.ToInt32();
        int i;

        for (i = 0; i < offset.Length - 1; i++)
        {
            pointer = readMemory(pointer + offset[i]);
        }

        return pointer + offset[i];
    }

    protected int findPointer(int offset)
    {
        return findPointer(new int[1] { offset });
    }

    // Offset from dll module
    protected int findPointer(string moduleName, int[] offset)
    {
        // Find module
        ProcessModuleCollection modules = process.Modules;
        ProcessModule dllBaseAdress = null;
        foreach (ProcessModule m in modules)
        {
            if (m.ModuleName == moduleName)
            {
                dllBaseAdress = m;
                break;
            }
        }

        int pointer = dllBaseAdress.BaseAddress.ToInt32();
        int i;

        for (i = 0; i < offset.Length - 1; i++)
        {
            pointer = readMemory(pointer + offset[i]);
        }

        return pointer + offset[i];
    }

    protected int findPointer(string moduleName, int offset)
    {
        return findPointer(moduleName, new int[1] { offset });
    }

    protected virtual void GameNotOpen()
    {
        MessageBox.Show("Please have " + game + " open while runnning this process");
    }

    protected int[] GetPointerArray(string key)
    {
        string PointerString = ConfigurationManager.AppSettings[key];
        IEnumerable<int> PointerInts = (PointerString ?? "").Split(',').Select(c => Convert.ToInt32(c, 16));
        return PointerInts.ToArray();
    }

    [DllImport("kernel32.dll")]
    public static extern IntPtr OpenProcess(int dwDesiredAccess, bool bInheritHandle, int dwProcessId);

    [DllImport("kernel32.dll")]
    public static extern bool ReadProcessMemory(int hProcess,
      int lpBaseAddress, byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesRead);

    [DllImport("kernel32.dll", SetLastError = true)]
    static extern bool WriteProcessMemory(int hProcess, int lpBaseAddress,
      byte[] lpBuffer, int dwSize, ref int lpNumberOfBytesWritten);

    private const int PROCESS_WM_READ = 0x0010;
    private const int PROCESS_ALL_ACCESS = 0x1F0FFF;
    protected const int SW_RESTORE = 9;
    private Process process;
    private int pHandle;
    private int bytesRead = 0;
    private int bytesWritten = 0;
    private byte[] buffer = new byte[4];
    private bool canWrite;
    protected IntPtr hWnd;
    public string game;
    public string pName;
}