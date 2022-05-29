// Decompiled with JetBrains decompiler
// Type: Skill_Sender.Memory
// Assembly: SS 1.6.5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53A40850-8FD5-4E75-B8A2-8BAE16B1E02D
// Assembly location: C:\Users\USUARIO\Documents\LUTOBIXA\111S 1.6.5.exe

using System;
using System.Collections.Generic;
using System.Linq;

namespace Skill_Sender
{
  internal class Memory
  {
    private IntPtr pHandle;

    public Memory(IntPtr pHandle) => this.pHandle = pHandle;

    public int ReadInt32(int address) => MemFunctions.MemReadInt(this.pHandle, address);

    public uint ReadUInt32(int address) => MemFunctions.MemReadUInt(this.pHandle, address);

    public float ReadFloat(int address) => MemFunctions.MemReadFloat(this.pHandle, address);

    public byte[] ReadBytes(int address, int amount) => MemFunctions.MemReadBytes(this.pHandle, address, amount);

    public string ReadUnicode(int address) => MemFunctions.MemReadUnicode(this.pHandle, address);

    public byte ReadByte(int address) => (byte) MemFunctions.MemReadInt(this.pHandle, address);

    public void Write(int address, object data, bool reverse)
    {
      if (data is byte num)
      {
        MemFunctions.MemWriteByte(this.pHandle, address, num);
      }
      else
      {
        byte[] source = (byte[]) null;
        if (data is int num1)
          source = BitConverter.GetBytes(num1);
        if (data is uint num2)
          source = BitConverter.GetBytes(num2);
        if (data is short num3)
          source = BitConverter.GetBytes(num3);
        if (data is float num4)
          source = BitConverter.GetBytes(num4);
        if (data is bool flag)
          source = BitConverter.GetBytes(flag);
        if (data is byte[])
          source = (byte[]) data;
        if (reverse && source != null)
          ((IEnumerable<byte>) source).Reverse<byte>();
        MemFunctions.MemWriteBytes(this.pHandle, address, source);
      }
    }

    public void Write(int address, object data) => this.Write(address, data, true);

    public int Allocate(int amount) => MemFunctions.AllocateMemory(this.pHandle, amount);

    public IntPtr CreateRemoteThread(int address) => MemFunctions.CreateRemoteThread(this.pHandle, address);

    public void WaitThread(IntPtr thread) => MemFunctions.WaitForSingleObject(thread);

    public void CloseThread(IntPtr thread) => MemFunctions.CloseProcess(thread);
  }
}
