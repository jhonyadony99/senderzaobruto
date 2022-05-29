// Decompiled with JetBrains decompiler
// Type: Skill_Sender.PacketSender
// Assembly: SS 1.6.5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53A40850-8FD5-4E75-B8A2-8BAE16B1E02D
// Assembly location: C:\Users\USUARIO\Documents\LUTOBIXA\111S 1.6.5.exe

using System;

namespace Skill_Sender
{
  internal class PacketSender
  {
    private byte[] Opcode = new byte[27]
    {
      (byte) 96,
      (byte) 184,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 139,
      (byte) 13,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 139,
      (byte) 73,
      (byte) 32,
      (byte) 191,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 0,
      (byte) 106,
      (byte) 0,
      (byte) 87,
      byte.MaxValue,
      (byte) 208,
      (byte) 97,
      (byte) 195
    };
    private const int Pacall = 10033584;
    private const int RBA = 19454876;
    private Memory Mem;
    private int OpcodeAddr;

    public PacketSender(Memory mem)
    {
      this.Mem = mem;
      this.OpcodeAddr = this.SetUpOpcode();
    }

    private int SetUpOpcode()
    {
      int address = this.Mem.Allocate(4);
      this.Mem.Write(address, (object) this.Opcode);
      this.Mem.Write(address + 2, (object) 10033584, true);
      this.Mem.Write(address + 8, (object) 19454876, true);
      return address;
    }

    public void SendPacket(Packet pkt)
    {
      if (pkt.Address == 9)
        pkt.Address = this.Mem.Allocate(4);
      if (this.Mem.ReadInt32(pkt.Address) == 0)
        this.Mem.Write(pkt.Address, (object) pkt.Pkt);
      this.Mem.Write(this.OpcodeAddr + 16, (object) pkt.Address, true);
      this.Mem.Write(this.OpcodeAddr + 21, (object) pkt.Size);
      IntPtr remoteThread = this.Mem.CreateRemoteThread(this.OpcodeAddr);
      this.Mem.WaitThread(remoteThread);
      this.Mem.CloseThread(remoteThread);
    }
  }
}
