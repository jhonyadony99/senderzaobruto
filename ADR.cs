// Decompiled with JetBrains decompiler
// Type: Skill_Sender.ADR
// Assembly: SS 1.6.5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53A40850-8FD5-4E75-B8A2-8BAE16B1E02D
// Assembly location: C:\Users\USUARIO\Documents\LUTOBIXA\111S 1.6.5.exe

using System;

namespace Skill_Sender
{
  internal class ADR
  {
    private const int RBA = 13069772;
    private PacketSender sender;
    private Memory mam;
    private Packet skillPkt;
    private Packet cskillPkt;
    private Packet finishPkt;
    public byte QueueSkillCType;

    public ADR(IntPtr pHandle)
    {
      this.mam = new Memory(pHandle);
      this.sender = new PacketSender(this.mam);
    }

    private int GamePtr => this.mam.ReadInt32(19457556);

    public int CharPtr => this.mam.ReadInt32(this.GamePtr + 48);

    public int adr1 => this.mam.ReadInt32(this.CharPtr + 3376);

    public int adr2 => this.mam.ReadInt32(this.adr1);

    public int ActionPtr => this.mam.ReadInt32(this.adr2 + 3368);

    public uint UID => this.mam.ReadUInt32(this.CharPtr + 3680);

    public string Name => this.mam.ReadUnicode(this.mam.ReadInt32(this.CharPtr + 2648));

    public int QueuePtr => this.mam.ReadInt32(this.ActionPtr + 64);

    public int QueueType => this.mam.ReadInt32(this.QueuePtr + 4);

    public uint QueueTarget => this.mam.ReadUInt32(this.mam.ReadInt32(this.QueuePtr + 64) + 8);

    public int QueueSkillPtr => this.mam.ReadInt32(this.QueuePtr + 52);

    public int QueueSkillID => this.mam.ReadInt32(this.QueueSkillPtr + 8);

    public byte QueueSkillType => (byte) this.mam.ReadInt32(this.mam.ReadInt32(this.mam.ReadInt32(this.QueueSkillPtr + 4) + 4) + 28);

    public int SkillPtr => this.mam.ReadInt32(this.CharPtr + 2884);

    public bool Charging => this.mam.ReadByte(this.SkillPtr + 36) == (byte) 1;

    public bool Charging1 => this.mam.ReadByte(this.SkillPtr + 24) == (byte) 1;

    public bool Charging2 => this.mam.ReadByte(this.SkillPtr + 16) == (byte) 1;

    public void SendPacket(Packet packet)
    {
      try
      {
        this.sender.SendPacket(packet);
      }
      catch (Exception ex)
      {
      }
    }

    public void ZoomHack()
    {
      this.mam.Write(4231344, (object) (byte) 144);
      this.mam.Write(4506194, (object) (byte) 144);
    }

    public void MirarFull()
    {
      this.mam.Write(this.SkillPtr + 36, (object) (byte) 0);
      this.mam.Write(this.SkillPtr + 24, (object) (byte) 0);
      this.mam.Write(this.SkillPtr + 16, (object) (byte) 0);
      this.SendPacket(this.FinishPkt());
      this.SendPacket(this.FinishPkt());
    }

    public Packet FinishPkt()
    {
      try
      {
        if (this.finishPkt == null)
          this.finishPkt = new Packet((short) 51, 2);
        if (this.finishPkt.Address == 0)
          this.finishPkt.Address = this.mam.Allocate((int) this.finishPkt.Size);
        if (this.mam.ReadInt32(this.finishPkt.Address) == 0)
          this.mam.Write(this.finishPkt.Address, (object) this.finishPkt.Pkt);
        return this.finishPkt;
      }
      catch (Exception ex)
      {
        return (Packet) null;
      }
    }

    public Packet cSkillPkt(int ID, uint target)
    {
      try
      {
        if (this.cskillPkt == null)
          this.cskillPkt = new Packet((short) 80, 12);
        if (this.cskillPkt.Address == 0)
          this.cskillPkt.Address = this.mam.Allocate(4);
        if (this.mam.ReadInt32(this.cskillPkt.Address) == 0)
          this.mam.Write(this.cskillPkt.Address, (object) this.cskillPkt.Pkt);
        this.mam.Write(this.cskillPkt.Address + 2, (object) ID);
        this.mam.Write(this.cskillPkt.Address + 6, (object) (byte) 1);
        this.mam.Write(this.cskillPkt.Address + 7, (object) (byte) 1);
        this.mam.Write(this.cskillPkt.Address + 8, (object) target);
        return this.cskillPkt;
      }
      catch (Exception ex)
      {
        return (Packet) null;
      }
    }

    public Packet SkillPkt(int ID, uint target)
    {
      try
      {
        if (this.skillPkt == null)
          this.skillPkt = new Packet((short) 41, 12);
        if (this.skillPkt.Address == 0)
          this.skillPkt.Address = this.mam.Allocate(4);
        if (this.mam.ReadInt32(this.skillPkt.Address) == 0)
          this.mam.Write(this.skillPkt.Address, (object) this.skillPkt.Pkt);
        this.mam.Write(this.skillPkt.Address + 2, (object) ID);
        this.mam.Write(this.skillPkt.Address + 6, (object) (byte) 1);
        this.mam.Write(this.skillPkt.Address + 7, (object) (byte) 1);
        this.mam.Write(this.skillPkt.Address + 8, (object) target);
        return this.skillPkt;
      }
      catch (Exception ex)
      {
        return (Packet) null;
      }
    }
  }
}
