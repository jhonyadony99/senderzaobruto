// Decompiled with JetBrains decompiler
// Type: Skill_Sender.SenderON
// Assembly: SS 1.6.5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53A40850-8FD5-4E75-B8A2-8BAE16B1E02D
// Assembly location: C:\Users\USUARIO\Documents\LUTOBIXA\111S 1.6.5.exe

using System;
using System.Threading;
using System.Threading.Tasks;

namespace Skill_Sender
{
  internal class SenderON
  {
    private ADR aDR;
    private bool Charge1;
    private bool Running;
    private bool mirar;
    private Task t2;
    private Task t1;

    public SenderON(ADR elementclient) => this.aDR = elementclient;

    public void StartSender()
    {
      this.Running = true;
      this.t1 = new Task((Action) (() => this.Skillsender()));
      this.t1.Start();
    }

    public void StartMirar()
    {
      this.mirar = true;
      this.Charge1 = true;
      this.t2 = new Task((Action) (() => this.MirarFull()));
      this.t2.Start();
    }

    private void Skillsender()
    {
label_7:
      while (this.Running)
      {
        Thread.Sleep(1);
        int queuePtr = this.aDR.QueuePtr;
        int queueSkillId = this.aDR.QueueSkillID;
        if (queuePtr != 0 && this.aDR.QueueType == 2 && this.aDR.QueueSkillType != (byte) 8 && this.aDR.QueueTarget != 0U)
        {
          if (this.aDR.QueueSkillCType == (byte) 0)
            this.aDR.SendPacket(this.aDR.SkillPkt(queueSkillId, this.aDR.QueueTarget));
          else
            this.aDR.SendPacket(this.aDR.cSkillPkt(queueSkillId, this.aDR.QueueTarget));
          while (true)
          {
            if (this.aDR.QueueSkillID == queueSkillId && this.Running)
              Thread.Sleep(1);
            else
              goto label_7;
          }
        }
      }
    }

    private void MirarFull()
    {
label_5:
      while (this.mirar)
      {
        Thread.Sleep(1);
        if (this.Charge1 && this.aDR.Charging)
        {
          this.aDR.MirarFull();
          while (true)
          {
            if (this.aDR.Charging && this.mirar)
              Thread.Sleep(TimeSpan.FromTicks(1L));
            else
              goto label_5;
          }
        }
      }
    }

    public void AbortSender() => this.Running = false;

    public void AbortMirar() => this.mirar = false;
  }
}
