// Decompiled with JetBrains decompiler
// Type: Skill_Sender.Packet
// Assembly: SS 1.6.5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53A40850-8FD5-4E75-B8A2-8BAE16B1E02D
// Assembly location: C:\Users\USUARIO\Documents\LUTOBIXA\111S 1.6.5.exe

using System;
using System.Collections.Generic;
using System.Linq;

namespace Skill_Sender
{
  public class Packet
  {
    internal byte[] Pkt;
    internal int Address;

    internal byte Size => (byte) this.Pkt.Length;

    public Packet(short header, int size)
    {
      this.Pkt = new byte[size];
      byte[] bytes = BitConverter.GetBytes(header);
      ((IEnumerable<byte>) bytes).Reverse<byte>();
      Buffer.BlockCopy((Array) bytes, 0, (Array) this.Pkt, 0, 2);
    }
  }
}
