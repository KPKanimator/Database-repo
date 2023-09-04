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
      statusStrip1 = new StatusStrip();
      toolStripStatusLabel1 = new ToolStripStatusLabel();
      toolStripStatusLabelNumber = new ToolStripStatusLabel();
      textBox1 = new TextBox();
      menuStrip1.SuspendLayout();
      statusStrip1.SuspendLayout();
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
      файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadToolStripMenuItem });
      файлToolStripMenuItem.Name = "файлToolStripMenuItem";
      файлToolStripMenuItem.Size = new Size(48, 20);
      файлToolStripMenuItem.Text = "Файл";
      // 
      // loadToolStripMenuItem
      // 
      loadToolStripMenuItem.Name = "loadToolStripMenuItem";
      loadToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
      loadToolStripMenuItem.Size = new Size(143, 22);
      loadToolStripMenuItem.Text = "Load";
      loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
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
      // textBox1
      // 
      textBox1.Dock = DockStyle.Right;
      textBox1.Location = new Point(431, 24);
      textBox1.Multiline = true;
      textBox1.Name = "textBox1";
      textBox1.Size = new Size(503, 595);
      textBox1.TabIndex = 3;
      // 
      // MainForm
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(934, 641);
      Controls.Add(textBox1);
      Controls.Add(statusStrip1);
      Controls.Add(menuStrip1);
      MainMenuStrip = menuStrip1;
      Name = "MainForm";
      Text = "Form1";
      menuStrip1.ResumeLayout(false);
      menuStrip1.PerformLayout();
      statusStrip1.ResumeLayout(false);
      statusStrip1.PerformLayout();
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
    private TextBox textBox1;
  }
}