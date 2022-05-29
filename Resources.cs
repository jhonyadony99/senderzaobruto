// Decompiled with JetBrains decompiler
// Type: Skill_Sender.Properties.Resources
// Assembly: SS 1.6.5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53A40850-8FD5-4E75-B8A2-8BAE16B1E02D
// Assembly location: C:\Users\USUARIO\Documents\LUTOBIXA\111S 1.6.5.exe

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Skill_Sender.Properties
{
  [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
  [DebuggerNonUserCode]
  [CompilerGenerated]
  internal class Resources
  {
    private static ResourceManager resourceMan;
    private static CultureInfo resourceCulture;

    internal Resources()
    {
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static ResourceManager ResourceManager
    {
      get
      {
        if (Skill_Sender.Properties.Resources.resourceMan == null)
          Skill_Sender.Properties.Resources.resourceMan = new ResourceManager("Skill_Sender.Properties.Resources", typeof (Skill_Sender.Properties.Resources).Assembly);
        return Skill_Sender.Properties.Resources.resourceMan;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Advanced)]
    internal static CultureInfo Culture
    {
      get => Skill_Sender.Properties.Resources.resourceCulture;
      set => Skill_Sender.Properties.Resources.resourceCulture = value;
    }

    internal static Bitmap pw => (Bitmap) Skill_Sender.Properties.Resources.ResourceManager.GetObject(nameof (pw), Skill_Sender.Properties.Resources.resourceCulture);
  }
}
