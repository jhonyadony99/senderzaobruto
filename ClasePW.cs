// Decompiled with JetBrains decompiler
// Type: Flay_Haker.ClasePW
// Assembly: SS 1.6.5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53A40850-8FD5-4E75-B8A2-8BAE16B1E02D
// Assembly location: C:\Users\USUARIO\Documents\LUTOBIXA\111S 1.6.5.exe

namespace Flay_Haker
{
  internal class ClasePW
  {
    public static string Classepw(int _class)
    {
      string str = "";
      switch (_class)
      {
        case 0:
          str = "Guerreiro";
          break;
        case 1:
          str = "Mago";
          break;
        case 2:
          str = "Espiritualista";
          break;
        case 3:
          str = "Feiticeira";
          break;
        case 4:
          str = "Barbaro";
          break;
        case 5:
          str = "Mercenario";
          break;
        case 6:
          str = "Arqueiro";
          break;
        case 7:
          str = "Sacerdote";
          break;
        case 8:
          str = "Arcano";
          break;
        case 9:
          str = "Mistco";
          break;
        case 10:
          str = "Retalhador";
          break;
        case 11:
          str = "Tormentador";
          break;
      }
      return str;
    }
  }
}
