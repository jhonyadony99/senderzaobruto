// Decompiled with JetBrains decompiler
// Type: PWFrameWork.WinApi
// Assembly: SS 1.6.5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53A40850-8FD5-4E75-B8A2-8BAE16B1E02D
// Assembly location: C:\Users\USUARIO\Documents\LUTOBIXA\111S 1.6.5.exe

using System;
using System.Runtime.InteropServices;
using System.Text;

namespace PWFrameWork
{
  public static class WinApi
  {
    private static readonly IntPtr HWND_TOPMOST = new IntPtr(-1);
    private static readonly IntPtr HWND_NOTOPMOST = new IntPtr(-2);
    private static readonly IntPtr HWND_TOP = new IntPtr(0);
    private static readonly IntPtr HWND_BOTTOM = new IntPtr(1);
    public const int WH_KEYBOARD_LL = 13;
    public const int WM_KEYDOWN = 256;
    public const int WM_KEYUP = 257;
    public const int WM_SYSKEYDOWN = 260;
    public const int WM_SYSKEYUP = 261;

    [DllImport("kernel32.dll")]
    public static extern IntPtr OpenProcess(
      WinApi.ProcessAccessFlags dwDesiredAccess,
      [MarshalAs(UnmanagedType.Bool)] bool bInheritHandle,
      int dwProcessId);

    [DllImport("kernel32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool CloseHandle(IntPtr hObject);

    [DllImport("kernel32.dll")]
    public static extern int ReadProcessMemory(
      IntPtr hProcess,
      int lpBaseAddress,
      [In, Out] byte[] buffer,
      int size,
      out int lpNumberOfBytesRead);

    [DllImport("kernel32.dll", EntryPoint = "ReadProcessMemory")]
    public static extern int ReadProcessMemory2(
      IntPtr hProcess,
      int lpBaseAddress,
      IntPtr buffer,
      int size,
      out int lpNumberOfBytesRead);

    [DllImport("kernel32.dll")]
    public static extern bool WriteProcessMemory(
      IntPtr hProcess,
      int lpBaseAddress,
      [In, Out] byte[] buffer,
      int nSize,
      out int lpNumberOfBytesWritten);

    [DllImport("kernel32.dll")]
    public static extern bool WriteProcessMemory2(
      IntPtr hProcess,
      int lpBaseAddress,
      IntPtr buffer,
      int nSize,
      out int lpNumberOfBytesWritten);

    [DllImport("kernel32.dll", SetLastError = true)]
    public static extern int VirtualAllocEx(
      IntPtr hProcess,
      int lpAddress,
      int dwSize,
      WinApi.AllocationType flAllocationType,
      WinApi.MemoryProtection flProtect);

    [DllImport("kernel32.dll", SetLastError = true)]
    public static extern IntPtr VirtualAlloc(
      int lpAddress,
      int dwSize,
      WinApi.AllocationType flAllocationType,
      WinApi.MemoryProtection flProtect);

    [DllImport("kernel32.dll", SetLastError = true)]
    public static extern bool VirtualFreeEx(
      IntPtr hProcess,
      int lpAddress,
      int dwSize,
      WinApi.FreeType dwFreeType);

    [DllImport("kernel32.dll", SetLastError = true)]
    public static extern bool VirtualFree(int lpAddress, int dwSize, WinApi.FreeType dwFreeType);

    [DllImport("kernel32.dll")]
    public static extern IntPtr CreateRemoteThread(
      IntPtr hProcess,
      IntPtr lpThreadAttributes,
      int dwStackSize,
      int lpStartAddress,
      IntPtr lpParameter,
      int dwCreationFlags,
      out IntPtr lpThreadId);

    [DllImport("kernel32.dll")]
    public static extern IntPtr CreateThread(
      IntPtr lpThreadAttributes,
      int dwStackSize,
      int lpStartAddress,
      IntPtr lpParameter,
      int dwCreationFlags,
      out IntPtr lpThreadId);

    [DllImport("kernel32.dll", SetLastError = true)]
    public static extern uint WaitForSingleObject(IntPtr hHandle, uint dwMilliseconds);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    public static extern int GetClassName(IntPtr hWnd, StringBuilder lpClassName, int nMaxCount);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    public static extern IntPtr FindWindowEx(
      IntPtr hwndParent,
      IntPtr hwndChildAfter,
      string lpszClass,
      string lpszWindow);

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    public static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, out int lpdwProcessId);

    public static string GetWindowClass(IntPtr handle)
    {
      StringBuilder lpClassName = new StringBuilder(128);
      WinApi.GetClassName(handle, lpClassName, 128);
      return lpClassName.ToString();
    }

    [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
    public static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

    public static string GetWindowText(IntPtr handle)
    {
      StringBuilder lpString = new StringBuilder(128);
      WinApi.GetWindowText(handle, lpString, 128);
      return lpString.ToString();
    }

    [DllImport("user32.dll")]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool SetWindowPos(
      int hWnd,
      int hWndInsertAfter,
      int X,
      int Y,
      int cx,
      int cy,
      WinApi.SetWinPosFlag uFlags);

    [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
    public static extern IntPtr LoadLibraryW(string lpFileName);

    [DllImport("kernel32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
    public static extern IntPtr GetProcAddress(IntPtr hModule, string lpProcName);

    [DllImport("user32.dll")]
    public static extern IntPtr SetWindowsHookEx(
      int idHook,
      WinApi.KeyboardHookProc callback,
      IntPtr hInstance,
      uint threadId);

    [DllImport("user32.dll")]
    public static extern bool UnhookWindowsHookEx(IntPtr hInstance);

    [DllImport("user32.dll")]
    public static extern int CallNextHookEx(
      IntPtr idHook,
      int nCode,
      int wParam,
      ref WinApi.KeyboardHookStruct lParam);

    [DllImport("user32.dll")]
    public static extern IntPtr GetForegroundWindow();

    [DllImport("user32.dll")]
    public static extern int SendMessage(int hWnd, int Msg, int wParam, string lParam);

    [Flags]
    public enum ProcessAccessFlags : uint
    {
      All = 2035711, // 0x001F0FFF
      AllT = All, // 0x001F0FFF
      Terminate = 1,
      CreateThread = 2,
      VmOperation = 8,
      VmRead = 16, // 0x00000010
      VmWrite = 32, // 0x00000020
      DupHandle = 64, // 0x00000040
      SetInformation = 512, // 0x00000200
      QueryInformation = 1024, // 0x00000400
      Synchronize = 1048576, // 0x00100000
    }

    [Flags]
    public enum AllocationType
    {
      Commit = 4096, // 0x00001000
      Reserve = 8192, // 0x00002000
      Decommit = 16384, // 0x00004000
      Release = 32768, // 0x00008000
      Reset = 524288, // 0x00080000
      Physical = 4194304, // 0x00400000
      TopDown = 1048576, // 0x00100000
      WriteWatch = 2097152, // 0x00200000
      LargePages = 536870912, // 0x20000000
    }

    [Flags]
    public enum MemoryProtection
    {
      Execute = 16, // 0x00000010
      ExecuteRead = 32, // 0x00000020
      ExecuteReadWrite = 64, // 0x00000040
      ExecuteWriteCopy = 128, // 0x00000080
      NoAccess = 1,
      ReadOnly = 2,
      ReadWrite = 4,
      WriteCopy = 8,
      GuardModifierflag = 256, // 0x00000100
      NoCacheModifierflag = 512, // 0x00000200
      WriteCombineModifierflag = 1024, // 0x00000400
    }

    [Flags]
    public enum FreeType
    {
      Decommit = 16384, // 0x00004000
      Release = 32768, // 0x00008000
    }

    public static class HWND
    {
      public static IntPtr NoTopMost = new IntPtr(-2);
      public static IntPtr TopMost = new IntPtr(-1);
      public static IntPtr Top = new IntPtr(0);
      public static IntPtr Bottom = new IntPtr(1);
    }

    [Flags]
    public enum SetWinPosFlag
    {
      NOSIZE = 1,
      NOMOVE = 2,
      NOZORDER = 4,
      NOREDRAW = 8,
      NOACTIVATE = 16, // 0x00000010
      DRAWFRAME = 32, // 0x00000020
      FRAMECHANGED = DRAWFRAME, // 0x00000020
      SHOWWINDOW = 64, // 0x00000040
      HIDEWINDOW = 128, // 0x00000080
      NOCOPYBITS = 256, // 0x00000100
      NOOWNERZORDER = 512, // 0x00000200
      NOREPOSITION = NOOWNERZORDER, // 0x00000200
      NOSENDCHANGING = 1024, // 0x00000400
      DEFERERASE = 8192, // 0x00002000
      ASYNCWINDOWPOS = 16384, // 0x00004000
    }

    public delegate int KeyboardHookProc(
      int code,
      int wParam,
      ref WinApi.KeyboardHookStruct lParam);

    public struct KeyboardHookStruct
    {
      public int vkCode;
      public int scanCode;
      public int flags;
      public int time;
      public int dwExtraInfo;
    }

    [Flags]
    public enum Msg
    {
      SetText = 12, // 0x0000000C
      Close = 16, // 0x00000010
      ButtonDown = 513, // 0x00000201
      ButtonUp = 514, // 0x00000202
    }
  }
}
