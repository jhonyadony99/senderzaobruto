// Decompiled with JetBrains decompiler
// Type: Read_Write_ProcessMemory.Memoria
// Assembly: SS 1.6.5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53A40850-8FD5-4E75-B8A2-8BAE16B1E02D
// Assembly location: C:\Users\USUARIO\Documents\LUTOBIXA\111S 1.6.5.exe

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Read_Write_ProcessMemory
{
  public class Memoria
  {
    private int PROCESS_ALL_ACCESS = 2035711;
    private int ProcID;
    private Process Proc;
    private const uint WM_KEYDOWN = 256;
    public const int KEYEVENTF_KEYDOWN = 0;
    public const int KEYEVENTF_EXTENDEDKEY = 1;
    public const int KEYEVENTF_KEYUP = 2;
    public const int VK_LCONTROL = 162;
    private const int MOUSEEVENTF_LEFTDOWN = 2;
    private const int MOUSEEVENTF_LEFTUP = 4;
    private const int MOUSEEVENTF_RIGHTDOWN = 8;
    private const int MOUSEEVENTF_RIGHTUP = 16;

    [DllImport("USER32.DLL")]
    private static extern bool EnumWindows(Memoria.EnumWindowsProc enumFunc, int lParam);

    [DllImport("USER32.DLL")]
    private static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

    [DllImport("USER32.DLL")]
    private static extern int GetWindowTextLength(IntPtr hWnd);

    [DllImport("USER32.DLL")]
    private static extern bool IsWindowVisible(IntPtr hWnd);

    [DllImport("USER32.DLL")]
    private static extern IntPtr GetShellWindow();

    [DllImport("user32.dll")]
    private static extern bool SetWindowText(IntPtr hwnd, string windowname);

    [DllImport("Kernel32.dll")]
    private static extern int CloseHandle(IntPtr hwnd);

    [DllImport("Kernel32.dll")]
    private static extern IntPtr OpenProcess(int acc, int hw, int processID);

    [DllImport("Kernel32.dll")]
    private static extern int ReadProcessMemory(
      IntPtr hwnd,
      int adr,
      [In, Out] byte[] buf,
      int size,
      out int ptreturn);

    [DllImport("Kernel32.dll")]
    private static extern int WriteProcessMemory(
      IntPtr hwnd,
      int adr,
      [In, Out] byte[] buf,
      int size,
      out int ptreturn);

    [DllImport("user32.dll")]
    private static extern bool GetKeyState(Memoria.VK key);

    [DllImport("user32.dll")]
    private static extern bool GetAsyncKeyState(Keys key);

    [DllImport("user32.dll", SetLastError = true)]
    private static extern bool keybd_event(
      Memoria.VK bVk,
      byte bScan,
      int dwFlags,
      int dwExtraInfo);

    [DllImport("user32.dll")]
    private static extern bool PostMessage(IntPtr hWnd, uint Msg, Memoria.VK wParam, int lParam);

    [DllImport("user32.dll", CharSet = CharSet.Auto)]
    private static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr w, IntPtr l);

    [DllImport("user32.dll")]
    private static extern void mouse_event(
      int dwFlags,
      int dx,
      int dy,
      int dwData,
      int dwExtraInfo);

    internal void PostMessager(object vK_TAB) => throw new NotImplementedException();

    public Memoria(int ProcessID)
    {
      try
      {
        this.ProcID = ProcessID;
      }
      catch (Exception ex)
      {
        int num = (int) MessageBox.Show("Abra o jogo primeiro.", "Atencao");
      }
    }

    public int BaseModule(string Moduledll, int ProcessID)
    {
      int num = 0;
      Process processById = Process.GetProcessById(ProcessID);
      int procId = this.ProcID;
      foreach (ProcessModule module in (ReadOnlyCollectionBase) processById.Modules)
      {
        if (module.ModuleName.Equals(Moduledll))
          num = (int) module.BaseAddress;
      }
      return num;
    }

    private int ReadMam(int adr, int size, out byte[] buf)
    {
      IntPtr zero = IntPtr.Zero;
      int procId = this.ProcID;
      IntPtr hwnd = Memoria.OpenProcess(this.PROCESS_ALL_ACCESS, 1, this.ProcID);
      buf = new byte[size];
      int ptreturn;
      Memoria.ReadProcessMemory(hwnd, adr, buf, size, out ptreturn);
      Memoria.CloseHandle(hwnd);
      return ptreturn;
    }

    public int ReadMultPointAddres(int adr, int[] offsetList)
    {
      int adr1 = adr;
      for (int index = 0; index < offsetList.Length; ++index)
      {
        byte[] buf;
        this.ReadMam(adr1, 4, out buf);
        adr1 = BitConverter.ToInt32(buf, 0) + offsetList[index];
      }
      return adr1;
    }

    public int ReadInt(int adr)
    {
      byte[] buf;
      this.ReadMam(adr, 4, out buf);
      return BitConverter.ToInt32(buf, 0);
    }

    public int ReadInt2(int adr)
    {
      byte[] buf;
      this.ReadMam(adr, 4, out buf);
      return (int) BitConverter.ToUInt16(buf, 0);
    }

    public float ReadFloat(int adr)
    {
      byte[] buf;
      this.ReadMam(adr, 4, out buf);
      return BitConverter.ToSingle(buf, 0);
    }

    public double ReadDouble(int adr)
    {
      byte[] buf;
      this.ReadMam(adr, 8, out buf);
      return BitConverter.ToDouble(buf, 0);
    }

    public byte ReadByte(int adr)
    {
      byte[] buf;
      this.ReadMam(adr, 2, out buf);
      return buf[0];
    }

    public string ReadString(int adr, int stringize)
    {
      byte[] buf;
      this.ReadMam(adr, stringize, out buf);
      return Encoding.Unicode.GetString(buf, 0, stringize);
    }

    public int ReadMultPointerInt(int adr, int[] offsetlist) => this.ReadInt(this.ReadMultPointAddres(adr, offsetlist));

    public int ReadMultPointerInt2(int adr, int[] offsetlist) => this.ReadInt2(this.ReadMultPointAddres(adr, offsetlist));

    public float ReadMultPointerFloat(int adr, int[] offsetlist) => this.ReadFloat(this.ReadMultPointAddres(adr, offsetlist));

    public float ReadMultPointerDouble(int adr, int[] offsetlist) => this.ReadFloat(this.ReadMultPointAddres(adr, offsetlist));

    public byte ReadMultPointerByte(int adr, int[] offsetlist) => this.ReadByte(this.ReadMultPointAddres(adr, offsetlist));

    public string ReadMultPointerString(int adr, int stringsize, int[] offsetlist) => this.ReadString(this.ReadMultPointAddres(adr, offsetlist), stringsize);

    private void WriteMam(int adr, int size, byte[] buf)
    {
      IntPtr zero = IntPtr.Zero;
      int procId = this.ProcID;
      IntPtr hwnd = Memoria.OpenProcess(this.PROCESS_ALL_ACCESS, 1, this.ProcID);
      Memoria.WriteProcessMemory(hwnd, adr, buf, size, out int _);
      Memoria.CloseHandle(hwnd);
    }

    public void WriteInt(int adr, int valor)
    {
      byte[] bytes = BitConverter.GetBytes(valor);
      this.WriteMam(adr, 4, bytes);
    }

    public void WriteFloat(int adr, float valor)
    {
      byte[] bytes = BitConverter.GetBytes(valor);
      this.WriteMam(adr, 4, bytes);
    }

    public void WriteDouble(int adr, double valor)
    {
      byte[] bytes = BitConverter.GetBytes(valor);
      this.WriteMam(adr, 8, bytes);
    }

    public void WriteByte(int adr, byte valor)
    {
      byte[] bytes = BitConverter.GetBytes((short) valor);
      this.WriteMam(adr, 2, bytes);
    }

    public void WriteString(int adr, string valor)
    {
      byte[] bytes = Encoding.Default.GetBytes(valor);
      this.WriteMam(adr, 100, bytes);
    }

    public void WriteMultPointerInt(int adr, int valor, int[] offsetList) => this.WriteInt(this.ReadMultPointAddres(adr, offsetList), valor);

    public void WriteMultPointerFloat(int adr, float valor, int[] offsetList) => this.WriteFloat(this.ReadMultPointAddres(adr, offsetList), valor);

    public void WriteMultPointerDouble(int adr, double valor, int[] offsetList) => this.WriteDouble(this.ReadMultPointAddres(adr, offsetList), valor);

    public void WriteMultPointerByte(int adr, byte valor, int[] offsetList) => this.WriteByte(this.ReadMultPointAddres(adr, offsetList), valor);

    public void WriteMultPointerString(int adr, string valor, int[] offsetList) => this.WriteString(this.ReadMultPointAddres(adr, offsetList), valor);

    private static IDictionary<IntPtr, string> GetOpenWindows()
    {
      IntPtr shellWindow = Memoria.GetShellWindow();
      Dictionary<IntPtr, string> windows = new Dictionary<IntPtr, string>();
      Memoria.EnumWindows((Memoria.EnumWindowsProc) ((hWnd, lParam) =>
      {
        if (hWnd == shellWindow || !Memoria.IsWindowVisible(hWnd))
          return true;
        int windowTextLength = Memoria.GetWindowTextLength(hWnd);
        if (windowTextLength == 0)
          return true;
        StringBuilder lpString = new StringBuilder(windowTextLength);
        Memoria.GetWindowText(hWnd, lpString, windowTextLength + 1);
        windows[hWnd] = lpString.ToString();
        return true;
      }), 0);
      return (IDictionary<IntPtr, string>) windows;
    }

    public int WindowsOpnenCount(string windowstitle)
    {
      int num = 0;
      foreach (KeyValuePair<IntPtr, string> openWindow in (IEnumerable<KeyValuePair<IntPtr, string>>) Memoria.GetOpenWindows())
      {
        IntPtr key = openWindow.Key;
        if (openWindow.Value.Contains(windowstitle))
          ++num;
      }
      return num;
    }

    public void SetState(ProgressBar pBar, int state) => Memoria.SendMessage(pBar.Handle, 1040U, (IntPtr) state, IntPtr.Zero);

    public void MudarNomeJanela(string name) => Memoria.SetWindowText(this.Proc.MainWindowHandle, name);

    public bool KeyPress(Memoria.VK key) => Memoria.GetKeyState(key);

    public bool KeyPressAsyc(Keys key) => Memoria.GetAsyncKeyState(key);

    public void KeyBordEvent(Memoria.VK key, int time)
    {
      Memoria.keybd_event(key, (byte) 0, 1, 0);
      Thread.Sleep(time);
      Memoria.keybd_event(key, (byte) 0, 2, 0);
    }

    public void PostMessager(Memoria.VK key) => Memoria.PostMessage(this.Proc.MainWindowHandle, 256U, key, 0);

    public void MouserClickLeft()
    {
      Memoria.mouse_event(2, 0, 0, 0, 0);
      Thread.Sleep(40);
      Memoria.mouse_event(4, 0, 0, 0, 0);
    }

    public void MouserClickRight()
    {
      Memoria.mouse_event(8, 0, 0, 0, 0);
      Thread.Sleep(40);
      Memoria.mouse_event(16, 0, 0, 0, 0);
    }

    public IntPtr OpenHamdle(int id) => Memoria.OpenProcess(this.PROCESS_ALL_ACCESS, 0, id);

    private delegate bool EnumWindowsProc(IntPtr hWnd, int lParam);

    public enum VK
    {
      VK_LBUTTON = 1,
      VK_RBUTTON = 2,
      VK_CANCEL = 3,
      VK_MBUTTON = 4,
      VK_XBUTTON1 = 5,
      VK_XBUTTON2 = 6,
      VK_BACK = 8,
      VK_TAB = 9,
      VK_CLEAR = 12, // 0x0000000C
      VK_RETURN = 13, // 0x0000000D
      VK_SHIFT = 16, // 0x00000010
      VK_CONTROL = 17, // 0x00000011
      VK_MENU = 18, // 0x00000012
      VK_PAUSE = 19, // 0x00000013
      VK_CAPITAL = 20, // 0x00000014
      VK_HANGEUL = 21, // 0x00000015
      VK_HANGUL = 21, // 0x00000015
      VK_KANA = 21, // 0x00000015
      VK_JUNJA = 23, // 0x00000017
      VK_FINAL = 24, // 0x00000018
      VK_HANJA = 25, // 0x00000019
      VK_KANJI = 25, // 0x00000019
      VK_ESCAPE = 27, // 0x0000001B
      VK_CONVERT = 28, // 0x0000001C
      VK_NONCONVERT = 29, // 0x0000001D
      VK_ACCEPT = 30, // 0x0000001E
      VK_MODECHANGE = 31, // 0x0000001F
      VK_SPACE = 32, // 0x00000020
      VK_PRIOR = 33, // 0x00000021
      VK_NEXT = 34, // 0x00000022
      VK_END = 35, // 0x00000023
      VK_HOME = 36, // 0x00000024
      VK_LEFT = 37, // 0x00000025
      VK_UP = 38, // 0x00000026
      VK_RIGHT = 39, // 0x00000027
      VK_DOWN = 40, // 0x00000028
      VK_SELECT = 41, // 0x00000029
      VK_PRINT = 42, // 0x0000002A
      VK_EXECUTE = 43, // 0x0000002B
      VK_SNAPSHOT = 44, // 0x0000002C
      VK_INSERT = 45, // 0x0000002D
      VK_DELETE = 46, // 0x0000002E
      VK_HELP = 47, // 0x0000002F
      VK_0 = 48, // 0x00000030
      VK_1 = 49, // 0x00000031
      VK_2 = 50, // 0x00000032
      VK_3 = 51, // 0x00000033
      VK_4 = 52, // 0x00000034
      VK_5 = 53, // 0x00000035
      VK_6 = 54, // 0x00000036
      VK_7 = 55, // 0x00000037
      VK_8 = 56, // 0x00000038
      VK_9 = 57, // 0x00000039
      VK_a = 65, // 0x00000041
      VK_b = 66, // 0x00000042
      VK_c = 67, // 0x00000043
      VK_d = 68, // 0x00000044
      VK_e = 69, // 0x00000045
      VK_f = 70, // 0x00000046
      VK_g = 71, // 0x00000047
      VK_h = 72, // 0x00000048
      VK_i = 73, // 0x00000049
      VK_j = 74, // 0x0000004A
      VK_k = 75, // 0x0000004B
      VK_l = 76, // 0x0000004C
      VK_m = 77, // 0x0000004D
      VK_n = 78, // 0x0000004E
      VK_o = 79, // 0x0000004F
      VK_p = 80, // 0x00000050
      VK_q = 81, // 0x00000051
      VK_r = 82, // 0x00000052
      VK_s = 83, // 0x00000053
      VK_t = 84, // 0x00000054
      VK_u = 85, // 0x00000055
      VK_v = 86, // 0x00000056
      VK_w = 87, // 0x00000057
      VK_x = 88, // 0x00000058
      VK_y = 89, // 0x00000059
      VK_z = 90, // 0x0000005A
      VK_LWIN = 91, // 0x0000005B
      VK_RWIN = 92, // 0x0000005C
      VK_APPS = 93, // 0x0000005D
      VK_SLEEP = 95, // 0x0000005F
      VK_NUMPAD0 = 96, // 0x00000060
      VK_NUMPAD1 = 97, // 0x00000061
      VK_NUMPAD2 = 98, // 0x00000062
      VK_NUMPAD3 = 99, // 0x00000063
      VK_NUMPAD4 = 100, // 0x00000064
      VK_NUMPAD5 = 101, // 0x00000065
      VK_NUMPAD6 = 102, // 0x00000066
      VK_NUMPAD7 = 103, // 0x00000067
      VK_NUMPAD8 = 104, // 0x00000068
      VK_NUMPAD9 = 105, // 0x00000069
      VK_MULTIPLY = 106, // 0x0000006A
      VK_ADD = 107, // 0x0000006B
      VK_SEPARATOR = 108, // 0x0000006C
      VK_SUBTRACT = 109, // 0x0000006D
      VK_DECIMAL = 110, // 0x0000006E
      VK_DIVIDE = 111, // 0x0000006F
      VK_F1 = 112, // 0x00000070
      VK_F2 = 113, // 0x00000071
      VK_F3 = 114, // 0x00000072
      VK_F4 = 115, // 0x00000073
      VK_F5 = 116, // 0x00000074
      VK_F6 = 117, // 0x00000075
      VK_F7 = 118, // 0x00000076
      VK_F8 = 119, // 0x00000077
      VK_F9 = 120, // 0x00000078
      VK_F10 = 121, // 0x00000079
      VK_F11 = 122, // 0x0000007A
      VK_F12 = 123, // 0x0000007B
      VK_F13 = 124, // 0x0000007C
      VK_F14 = 125, // 0x0000007D
      VK_F15 = 126, // 0x0000007E
      VK_F16 = 127, // 0x0000007F
      VK_F17 = 128, // 0x00000080
      VK_F18 = 129, // 0x00000081
      VK_F19 = 130, // 0x00000082
      VK_F20 = 131, // 0x00000083
      VK_F21 = 132, // 0x00000084
      VK_F22 = 133, // 0x00000085
      VK_F23 = 134, // 0x00000086
      VK_F24 = 135, // 0x00000087
      VK_NUMLOCK = 144, // 0x00000090
      VK_SCROLL = 145, // 0x00000091
      VK_OEM_FJ_JISHO = 146, // 0x00000092
      VK_OEM_NEC_EQUAL = 146, // 0x00000092
      VK_OEM_FJ_MASSHOU = 147, // 0x00000093
      VK_OEM_FJ_TOUROKU = 148, // 0x00000094
      VK_OEM_FJ_LOYA = 149, // 0x00000095
      VK_OEM_FJ_ROYA = 150, // 0x00000096
      VK_LSHIFT = 160, // 0x000000A0
      VK_RSHIFT = 161, // 0x000000A1
      VK_LCONTROL = 162, // 0x000000A2
      VK_RCONTROL = 163, // 0x000000A3
      VK_LMENU = 164, // 0x000000A4
      VK_RMENU = 165, // 0x000000A5
      VK_BROWSER_BACK = 166, // 0x000000A6
      VK_BROWSER_FORWARD = 167, // 0x000000A7
      VK_BROWSER_REFRESH = 168, // 0x000000A8
      VK_BROWSER_STOP = 169, // 0x000000A9
      VK_BROWSER_SEARCH = 170, // 0x000000AA
      VK_BROWSER_FAVORITES = 171, // 0x000000AB
      VK_BROWSER_HOME = 172, // 0x000000AC
      VK_VOLUME_MUTE = 173, // 0x000000AD
      VK_VOLUME_DOWN = 174, // 0x000000AE
      VK_VOLUME_UP = 175, // 0x000000AF
      VK_MEDIA_NEXT_TRACK = 176, // 0x000000B0
      VK_MEDIA_PREV_TRACK = 177, // 0x000000B1
      VK_MEDIA_STOP = 178, // 0x000000B2
      VK_MEDIA_PLAY_PAUSE = 179, // 0x000000B3
      VK_LAUNCH_MAIL = 180, // 0x000000B4
      VK_LAUNCH_MEDIA_SELECT = 181, // 0x000000B5
      VK_LAUNCH_APP1 = 182, // 0x000000B6
      VK_LAUNCH_APP2 = 183, // 0x000000B7
      VK_OEM_1 = 186, // 0x000000BA
      VK_OEM_PLUS = 187, // 0x000000BB
      VK_OEM_COMMA = 188, // 0x000000BC
      VK_OEM_MINUS = 189, // 0x000000BD
      VK_OEM_PERIOD = 190, // 0x000000BE
      VK_OEM_2 = 191, // 0x000000BF
      VK_OEM_3 = 192, // 0x000000C0
      VK_OEM_4 = 219, // 0x000000DB
      VK_OEM_5 = 220, // 0x000000DC
      VK_OEM_6 = 221, // 0x000000DD
      VK_OEM_7 = 222, // 0x000000DE
      VK_OEM_8 = 223, // 0x000000DF
      VK_OEM_AX = 225, // 0x000000E1
      VK_OEM_102 = 226, // 0x000000E2
      VK_ICO_HELP = 227, // 0x000000E3
      VK_ICO_00 = 228, // 0x000000E4
      VK_PROCESSKEY = 229, // 0x000000E5
      VK_ICO_CLEAR = 230, // 0x000000E6
      VK_PACKET = 231, // 0x000000E7
      VK_OEM_RESET = 233, // 0x000000E9
      VK_OEM_JUMP = 234, // 0x000000EA
      VK_OEM_PA1 = 235, // 0x000000EB
      VK_OEM_PA2 = 236, // 0x000000EC
      VK_OEM_PA3 = 237, // 0x000000ED
      VK_OEM_WSCTRL = 238, // 0x000000EE
      VK_OEM_CUSEL = 239, // 0x000000EF
      VK_OEM_ATTN = 240, // 0x000000F0
      VK_OEM_FINISH = 241, // 0x000000F1
      VK_OEM_COPY = 242, // 0x000000F2
      VK_OEM_AUTO = 243, // 0x000000F3
      VK_OEM_ENLW = 244, // 0x000000F4
      VK_OEM_BACKTAB = 245, // 0x000000F5
      VK_ATTN = 246, // 0x000000F6
      VK_CRSEL = 247, // 0x000000F7
      VK_EXSEL = 248, // 0x000000F8
      VK_EREOF = 249, // 0x000000F9
      VK_PLAY = 250, // 0x000000FA
      VK_ZOOM = 251, // 0x000000FB
      VK_NONAME = 252, // 0x000000FC
      VK_PA1 = 253, // 0x000000FD
      VK_OEM_CLEAR = 254, // 0x000000FE
    }
  }
}
