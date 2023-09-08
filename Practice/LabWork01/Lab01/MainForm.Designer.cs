namespace Lab01
{
  partial class MainForm
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      menuStrip1 = new MenuStrip();
      файлToolStripMenuItem = new ToolStripMenuItem();
      loadToolStripMenuItem = new ToolStripMenuItem();
      task1ToolStripMenuItem = new ToolStripMenuItem();
      statusStrip1 = new StatusStrip();
      toolStripStatusLabel1 = new ToolStripStatusLabel();
      toolStripStatusLabelNumber = new ToolStripStatusLabel();
      tbResult = new TextBox();
      groupBox1 = new GroupBox();
      label1 = new Label();
      tbSurname = new TextBox();
      menuStrip1.SuspendLayout();
      statusStrip1.SuspendLayout();
      groupBox1.SuspendLayout();
      SuspendLayout();
      // 
      // menuStrip1
      // 
      menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem });
      menuStrip1.Location = new Point(0, 0);
      menuStrip1.Name = "menuStrip1";
      menuStrip1.Size = new Size(934, 24);
      menuStrip1.TabIndex = 0;
      menuStrip1.Text = "menuStrip1";
      // 
      // файлToolStripMenuItem
      // 
      файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadToolStripMenuItem, task1ToolStripMenuItem });
      файлToolStripMenuItem.Name = "файлToolStripMenuItem";
      файлToolStripMenuItem.Size = new Size(48, 20);
      файлToolStripMenuItem.Text = "Файл";
      // 
      // loadToolStripMenuItem
      // 
      loadToolStripMenuItem.Name = "loadToolStripMenuItem";
      loadToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
      loadToolStripMenuItem.Size = new Size(263, 22);
      loadToolStripMenuItem.Text = "Load";
      loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
      // 
      // task1ToolStripMenuItem
      // 
      task1ToolStripMenuItem.Name = "task1ToolStripMenuItem";
      task1ToolStripMenuItem.Size = new Size(263, 22);
      task1ToolStripMenuItem.Text = "Task 1: Знайти викладачів студента";
      task1ToolStripMenuItem.Click += task1ToolStripMenuItem_Click;
      // 
      // statusStrip1
      // 
      statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabelNumber });
      statusStrip1.Location = new Point(0, 619);
      statusStrip1.Name = "statusStrip1";
      statusStrip1.Size = new Size(934, 22);
      statusStrip1.TabIndex = 2;
      statusStrip1.Text = "statusStrip1";
      // 
      // toolStripStatusLabel1
      // 
      toolStripStatusLabel1.Name = "toolStripStatusLabel1";
      toolStripStatusLabel1.Size = new Size(66, 17);
      toolStripStatusLabel1.Text = "Line count:";
      // 
      // toolStripStatusLabelNumber
      // 
      toolStripStatusLabelNumber.Name = "toolStripStatusLabelNumber";
      toolStripStatusLabelNumber.Size = new Size(49, 17);
      toolStripStatusLabelNumber.Text = "number";
      // 
      // tbResult
      // 
      tbResult.Dock = DockStyle.Right;
      tbResult.Location = new Point(431, 24);
      tbResult.Multiline = true;
      tbResult.Name = "tbResult";
      tbResult.Size = new Size(503, 595);
      tbResult.TabIndex = 3;
      // 
      // groupBox1
      // 
      groupBox1.Controls.Add(label1);
      groupBox1.Controls.Add(tbSurname);
      groupBox1.Location = new Point(12, 40);
      groupBox1.Name = "groupBox1";
      groupBox1.Size = new Size(413, 120);
      groupBox1.TabIndex = 4;
      groupBox1.TabStop = false;
      groupBox1.Text = "Task 1";
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(6, 26);
      label1.Name = "label1";
      label1.Size = new Size(54, 15);
      label1.TabIndex = 1;
      label1.Text = "Surname";
      // 
      // tbSurname
      // 
      tbSurname.Location = new Point(66, 23);
      tbSurname.Name = "tbSurname";
      tbSurname.Size = new Size(341, 23);
      tbSurname.TabIndex = 0;
      // 
      // MainForm
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(934, 641);
      Controls.Add(groupBox1);
      Controls.Add(tbResult);
      Controls.Add(statusStrip1);
      Controls.Add(menuStrip1);
      MainMenuStrip = menuStrip1;
      Name = "MainForm";
      Text = "Form1";
      menuStrip1.ResumeLayout(false);
      menuStrip1.PerformLayout();
      statusStrip1.ResumeLayout(false);
      statusStrip1.PerformLayout();
      groupBox1.ResumeLayout(false);
      groupBox1.PerformLayout();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private MenuStrip menuStrip1;
    private ToolStripMenuItem файлToolStripMenuItem;
    private ToolStripMenuItem loadToolStripMenuItem;
    private StatusStrip statusStrip1;
    private ToolStripStatusLabel toolStripStatusLabel1;
    private ToolStripStatusLabel toolStripStatusLabelNumber;
    private TextBox tbResult;
    private ToolStripMenuItem task1ToolStripMenuItem;
    private GroupBox groupBox1;
    private Label label1;
    private TextBox tbSurname;
  }
}