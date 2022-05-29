// Decompiled with JetBrains decompiler
// Type: Flay_Haker.ClientWindow
// Assembly: SS 1.6.5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53A40850-8FD5-4E75-B8A2-8BAE16B1E02D
// Assembly location: C:\Users\USUARIO\Documents\LUTOBIXA\111S 1.6.5.exe

using System.Diagnostics;

namespace Flay_Haker
{
  public class ClientWindow
  {
    public string Name { get; set; }

    public int ProcessId { get; set; }

    public Process Process => Process.GetProcessById(this.ProcessId);

    public ClientWindow(string name, int process_id)
    {
      this.Name = name;
      this.ProcessId = process_id;
    }

    public override string ToString() => this.Name;
  }
}
