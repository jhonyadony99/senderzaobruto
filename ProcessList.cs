// Decompiled with JetBrains decompiler
// Type: Flay_Haker.ProcessList
// Assembly: SS 1.6.5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53A40850-8FD5-4E75-B8A2-8BAE16B1E02D
// Assembly location: C:\Users\USUARIO\Documents\LUTOBIXA\111S 1.6.5.exe

using PWFrameWork;
using Skill_Sender;
using System;
using System.Collections.Generic;

namespace Flay_Haker
{
  internal class ProcessList
  {
    public IEnumerable<ClientWindow> ClientWindows
    {
      get
      {
        IntPtr hwnd = IntPtr.Zero;
        while (true)
        {
          hwnd = WinApi.FindWindowEx(IntPtr.Zero, hwnd, "ElementClient Window", (string) null);
          if (!(hwnd == IntPtr.Zero))
          {
            int lpdwProcessId;
            WinApi.GetWindowThreadProcessId(hwnd, out lpdwProcessId);
            Memory memory = new Memory(WinApi.OpenProcess(WinApi.ProcessAccessFlags.All, false, lpdwProcessId));
            string str = memory.ReadUnicode(memory.ReadInt32(memory.ReadInt32(memory.ReadInt32(19457556) + 48) + 2648));
            int _class = memory.ReadInt32(memory.ReadInt32(memory.ReadInt32(19457556) + 52) + 2648);
            if (str != "")
              yield return new ClientWindow(string.Format("Nome: {0} Classe: [{1}]", (object) str, (object) ClasePW.Classepw(_class)), lpdwProcessId);
            else
              yield return new ClientWindow(WinApi.GetWindowText(hwnd), lpdwProcessId);
          }
          else
            break;
        }
      }
    }
  }
}
