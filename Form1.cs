// Decompiled with JetBrains decompiler
// Type: Skill_Sender.Form1
// Assembly: SS 1.6.5, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53A40850-8FD5-4E75-B8A2-8BAE16B1E02D
// Assembly location: C:\Users\USUARIO\Documents\LUTOBIXA\111S 1.6.5.exe

using Flay_Haker;
using Read_Write_ProcessMemory;
using Skill_Sender.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Skill_Sender
{
  public class Form1 : Form
  {
    private Memoria main;
    private Memory mam;
    private int X;
    private int Y;
    private ProcessList processList;
    private ADR aDR;
    private SenderON senderON;
    private IntPtr hwnd;
    private int ProcessID;
    private Task t;
    private IContainer components;
    private ComboBox cb_cliente;
    private GroupBox groupBox1;
    private Label lb_name;
    private GroupBox groupBox2;
    private CheckBox chb_sender;
    private CheckBox chb_mirar;
    private Panel panel1;
    private Button btn_minimize;
    private Button tbn_close;
    private Label label1;
    private Button button1;
    private Label label4;
    private Label label3;

    public Form1()
    {
      this.InitializeComponent();
      this.groupBox1.BackColor = Color.FromArgb(100, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
      this.groupBox2.BackColor = Color.FromArgb(100, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
      this.panel1.BackColor = Color.FromArgb(50, (int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
      Control.CheckForIllegalCrossThreadCalls = false;
    }

    private void cb_cliente_SelectedIndexChanged(object sender, EventArgs e)
    {
      foreach (ClientWindow clientWindow in this.cb_cliente.Items)
      {
        if (clientWindow.Name == this.cb_cliente.SelectedItem.ToString())
        {
          this.hwnd = MemFunctions.OpenProcess(clientWindow.ProcessId);
          this.aDR = new ADR(this.hwnd);
          this.senderON = new SenderON(this.aDR);
          this.lb_name.Text = clientWindow.Name;
          this.mam = new Memory(this.hwnd);
          this.ProcessID = clientWindow.ProcessId;
          this.main = new Memoria(clientWindow.ProcessId);
        }
      }
    }

    private void cb_cliente_DropDown(object sender, EventArgs e)
    {
      this.cb_cliente.Items.Clear();
      this.processList = new ProcessList();
      foreach (object clientWindow in this.processList.ClientWindows)
        this.cb_cliente.Items.Add(clientWindow);
    }

    private void chb_sender_CheckedChanged(object sender, EventArgs e)
    {
      if (this.cb_cliente.Text != "")
      {
        if (this.chb_sender.Checked)
        {
          this.senderON.StartSender();
          this.chb_sender.Text = "Sender ON";
        }
        else
        {
          this.chb_sender.Text = "Sender OFF";
          this.senderON.AbortSender();
        }
      }
      else
        this.chb_sender.Checked = false;
    }

    private void chb_mirar_CheckedChanged(object sender, EventArgs e)
    {
      if (this.cb_cliente.Text != "")
      {
        if (this.chb_mirar.Checked)
        {
          this.senderON.StartMirar();
          this.chb_mirar.Text = "Mirar ON";
        }
        else
        {
          this.senderON.AbortMirar();
          this.chb_mirar.Text = "Mirar OFF";
        }
      }
      else
        this.chb_mirar.Checked = false;
    }

    private void panel1_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      int left = this.Left;
      Point mousePosition = Control.MousePosition;
      int x = mousePosition.X;
      this.X = left - x;
      int top = this.Top;
      mousePosition = Control.MousePosition;
      int y = mousePosition.Y;
      this.Y = top - y;
    }

    private void tbn_close_Click(object sender, EventArgs e) => Application.Exit();

    private void btn_minimize_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

    private void label1_MouseDown(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      int left = this.Left;
      Point mousePosition = Control.MousePosition;
      int x = mousePosition.X;
      this.X = left - x;
      int top = this.Top;
      mousePosition = Control.MousePosition;
      int y = mousePosition.Y;
      this.Y = top - y;
    }

    private void label1_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      int x1 = this.X;
      Point mousePosition = Control.MousePosition;
      int x2 = mousePosition.X;
      this.Left = x1 + x2;
      int y1 = this.Y;
      mousePosition = Control.MousePosition;
      int y2 = mousePosition.Y;
      this.Top = y1 + y2;
    }

    private void button1_Click(object sender, EventArgs e)
    {
    }

    private void label2_Click(object sender, EventArgs e)
    {
    }

    private void label3_Click(object sender, EventArgs e)
    {
    }

    private void label4_Click(object sender, EventArgs e)
    {
    }

    private void label7_Click(object sender, EventArgs e)
    {
    }

    private void groupBox2_Enter(object sender, EventArgs e)
    {
    }

    private void label1_Click(object sender, EventArgs e)
    {
    }

    private void panel1_MouseMove(object sender, MouseEventArgs e)
    {
      if (e.Button != MouseButtons.Left)
        return;
      int x1 = this.X;
      Point mousePosition = Control.MousePosition;
      int x2 = mousePosition.X;
      this.Left = x1 + x2;
      int y1 = this.Y;
      mousePosition = Control.MousePosition;
      int y2 = mousePosition.Y;
      this.Top = y1 + y2;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form1));
      this.cb_cliente = new ComboBox();
      this.groupBox1 = new GroupBox();
      this.lb_name = new Label();
      this.groupBox2 = new GroupBox();
      this.label4 = new Label();
      this.label3 = new Label();
      this.button1 = new Button();
      this.chb_mirar = new CheckBox();
      this.chb_sender = new CheckBox();
      this.panel1 = new Panel();
      this.label1 = new Label();
      this.btn_minimize = new Button();
      this.tbn_close = new Button();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      this.cb_cliente.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cb_cliente.FlatStyle = FlatStyle.System;
      this.cb_cliente.FormattingEnabled = true;
      this.cb_cliente.Location = new Point(12, 33);
      this.cb_cliente.Name = "cb_cliente";
      this.cb_cliente.Size = new Size(283, 21);
      this.cb_cliente.TabIndex = 0;
      this.cb_cliente.DropDown += new EventHandler(this.cb_cliente_DropDown);
      this.cb_cliente.SelectedIndexChanged += new EventHandler(this.cb_cliente_SelectedIndexChanged);
      this.groupBox1.BackColor = SystemColors.ButtonFace;
      this.groupBox1.Controls.Add((Control) this.lb_name);
      this.groupBox1.Controls.Add((Control) this.cb_cliente);
      this.groupBox1.ForeColor = SystemColors.ActiveCaptionText;
      this.groupBox1.Location = new Point(0, 22);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new Size(355, 126);
      this.groupBox1.TabIndex = 1;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Client";
      this.lb_name.AutoSize = true;
      this.lb_name.BackColor = Color.White;
      this.lb_name.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.lb_name.Location = new Point(12, 68);
      this.lb_name.Name = "lb_name";
      this.lb_name.Size = new Size(19, 13);
      this.lb_name.TabIndex = 2;
      this.lb_name.Text = "...";
      this.groupBox2.BackColor = SystemColors.ButtonFace;
      this.groupBox2.BackgroundImageLayout = ImageLayout.Center;
      this.groupBox2.Controls.Add((Control) this.label4);
      this.groupBox2.Controls.Add((Control) this.label3);
      this.groupBox2.Controls.Add((Control) this.button1);
      this.groupBox2.Controls.Add((Control) this.chb_mirar);
      this.groupBox2.Controls.Add((Control) this.chb_sender);
      this.groupBox2.ForeColor = SystemColors.ActiveCaptionText;
      this.groupBox2.Location = new Point(0, 148);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new Size(355, 148);
      this.groupBox2.TabIndex = 2;
      this.groupBox2.TabStop = false;
      this.groupBox2.Enter += new EventHandler(this.groupBox2_Enter);
      this.label4.AutoSize = true;
      this.label4.Location = new Point(9, (int) sbyte.MaxValue);
      this.label4.Name = "label4";
      this.label4.Size = new Size(101, 13);
      this.label4.TabIndex = 6;
      this.label4.Text = "SOURCE BY EVAN";
      this.label3.AutoSize = true;
      this.label3.Location = new Point(9, 104);
      this.label3.Name = "label3";
      this.label3.Size = new Size(214, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "BYPASS AND REFORMULED BY MEDEIA";
      this.button1.ForeColor = SystemColors.ControlText;
      this.button1.Location = new Point(5, 66);
      this.button1.Name = "button1";
      this.button1.Size = new Size(308, 23);
      this.button1.TabIndex = 4;
      this.button1.Text = "Active/Update";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new EventHandler(this.button1_Click);
      this.chb_mirar.AutoSize = true;
      this.chb_mirar.BackColor = Color.Transparent;
      this.chb_mirar.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.chb_mirar.ForeColor = SystemColors.ActiveCaptionText;
      this.chb_mirar.Location = new Point(6, 43);
      this.chb_mirar.Name = "chb_mirar";
      this.chb_mirar.Size = new Size(138, 17);
      this.chb_mirar.TabIndex = 4;
      this.chb_mirar.Text = "Auto-complete charging";
      this.chb_mirar.UseVisualStyleBackColor = false;
      this.chb_mirar.CheckedChanged += new EventHandler(this.chb_mirar_CheckedChanged);
      this.chb_sender.AutoSize = true;
      this.chb_sender.BackColor = Color.Transparent;
      this.chb_sender.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.chb_sender.ForeColor = SystemColors.ActiveCaptionText;
      this.chb_sender.Location = new Point(6, 20);
      this.chb_sender.Name = "chb_sender";
      this.chb_sender.Size = new Size(119, 17);
      this.chb_sender.TabIndex = 3;
      this.chb_sender.Text = "Turn off SkillSender";
      this.chb_sender.UseVisualStyleBackColor = false;
      this.chb_sender.CheckedChanged += new EventHandler(this.chb_sender_CheckedChanged);
      this.panel1.Controls.Add((Control) this.label1);
      this.panel1.Controls.Add((Control) this.btn_minimize);
      this.panel1.Controls.Add((Control) this.tbn_close);
      this.panel1.Dock = DockStyle.Top;
      this.panel1.Location = new Point(0, 0);
      this.panel1.Name = "panel1";
      this.panel1.Size = new Size(355, 23);
      this.panel1.TabIndex = 3;
      this.panel1.MouseDown += new MouseEventHandler(this.panel1_MouseDown);
      this.panel1.MouseMove += new MouseEventHandler(this.panel1_MouseMove);
      this.label1.AutoSize = true;
      this.label1.BackColor = Color.Transparent;
      this.label1.Location = new Point(9, 4);
      this.label1.Name = "label1";
      this.label1.Size = new Size(48, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "SS 1.6.5";
      this.label1.Click += new EventHandler(this.label1_Click);
      this.label1.MouseDown += new MouseEventHandler(this.label1_MouseDown);
      this.label1.MouseMove += new MouseEventHandler(this.label1_MouseMove);
      this.btn_minimize.BackColor = Color.Transparent;
      this.btn_minimize.FlatAppearance.BorderSize = 0;
      this.btn_minimize.FlatAppearance.CheckedBackColor = Color.Lime;
      this.btn_minimize.FlatAppearance.MouseDownBackColor = Color.Lime;
      this.btn_minimize.FlatAppearance.MouseOverBackColor = Color.Lime;
      this.btn_minimize.FlatStyle = FlatStyle.Flat;
      this.btn_minimize.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.btn_minimize.ForeColor = Color.Black;
      this.btn_minimize.Location = new Point(301, 1);
      this.btn_minimize.Name = "btn_minimize";
      this.btn_minimize.Size = new Size(21, 19);
      this.btn_minimize.TabIndex = 6;
      this.btn_minimize.Text = "-";
      this.btn_minimize.UseVisualStyleBackColor = false;
      this.btn_minimize.Click += new EventHandler(this.btn_minimize_Click);
      this.tbn_close.BackColor = Color.Transparent;
      this.tbn_close.FlatAppearance.BorderSize = 0;
      this.tbn_close.FlatAppearance.CheckedBackColor = Color.Lime;
      this.tbn_close.FlatAppearance.MouseDownBackColor = Color.Lime;
      this.tbn_close.FlatAppearance.MouseOverBackColor = Color.Lime;
      this.tbn_close.FlatStyle = FlatStyle.Flat;
      this.tbn_close.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.tbn_close.ForeColor = Color.Black;
      this.tbn_close.Location = new Point(328, 0);
      this.tbn_close.Name = "tbn_close";
      this.tbn_close.Size = new Size(21, 23);
      this.tbn_close.TabIndex = 5;
      this.tbn_close.Text = "X";
      this.tbn_close.UseVisualStyleBackColor = false;
      this.tbn_close.Click += new EventHandler(this.tbn_close_Click);
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackgroundImage = (Image) Resources.pw;
      this.BackgroundImageLayout = ImageLayout.Stretch;
      this.ClientSize = new Size(355, 300);
      this.Controls.Add((Control) this.panel1);
      this.Controls.Add((Control) this.groupBox2);
      this.Controls.Add((Control) this.groupBox1);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (Form1);
      this.Text = "ajsgdiauhsdiahwdhaisudhawhu";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);
    }
  }
}
