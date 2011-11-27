namespace Statki
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.menuStrip2 = new System.Windows.Forms.MenuStrip();
      this.GameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.GameNewToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
      this.GameEndToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
      this.OptionsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.OptionsSoundToolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
      this.OptionsSoundOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.OptionsSoundOnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.OptionsAnimationToolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
      this.OptionsAnimationOffToolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
      this.OptionsAnimationOnToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.RecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.button_Start = new System.Windows.Forms.Button();
      this.richTextBox1 = new System.Windows.Forms.RichTextBox();
      this.menuStrip2.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Location = new System.Drawing.Point(12, 423);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(386, 329);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "groupBox1";
      // 
      // groupBox2
      // 
      this.groupBox2.Location = new System.Drawing.Point(408, 423);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(386, 329);
      this.groupBox2.TabIndex = 1;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "groupBox2";
      // 
      // menuStrip2
      // 
      this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GameToolStripMenuItem,
            this.OptionsToolStripMenuItem2,
            this.RecordsToolStripMenuItem});
      this.menuStrip2.Location = new System.Drawing.Point(0, 0);
      this.menuStrip2.Name = "menuStrip2";
      this.menuStrip2.Size = new System.Drawing.Size(882, 24);
      this.menuStrip2.TabIndex = 7;
      this.menuStrip2.Text = "menuStrip2";
      // 
      // GameToolStripMenuItem
      // 
      this.GameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GameNewToolStripMenuItem3,
            this.GameEndToolStripMenuItem4});
      this.GameToolStripMenuItem.Name = "GameToolStripMenuItem";
      this.GameToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.GameToolStripMenuItem.Text = "Gra";
      // 
      // GameNewToolStripMenuItem3
      // 
      this.GameNewToolStripMenuItem3.Name = "GameNewToolStripMenuItem3";
      this.GameNewToolStripMenuItem3.Size = new System.Drawing.Size(110, 22);
      this.GameNewToolStripMenuItem3.Text = "Nowa";
      this.GameNewToolStripMenuItem3.Click += new System.EventHandler(this.GameNewToolStripMenuItem3_Click);
      // 
      // GameEndToolStripMenuItem4
      // 
      this.GameEndToolStripMenuItem4.Name = "GameEndToolStripMenuItem4";
      this.GameEndToolStripMenuItem4.Size = new System.Drawing.Size(110, 22);
      this.GameEndToolStripMenuItem4.Text = "Koniec";
      this.GameEndToolStripMenuItem4.Click += new System.EventHandler(this.GameEndToolStripMenuItem4_Click);
      // 
      // OptionsToolStripMenuItem2
      // 
      this.OptionsToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OptionsSoundToolStripMenuItem6,
            this.OptionsAnimationToolStripMenuItem7});
      this.OptionsToolStripMenuItem2.Name = "OptionsToolStripMenuItem2";
      this.OptionsToolStripMenuItem2.Size = new System.Drawing.Size(50, 20);
      this.OptionsToolStripMenuItem2.Text = "Opcje";
      // 
      // OptionsSoundToolStripMenuItem6
      // 
      this.OptionsSoundToolStripMenuItem6.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OptionsSoundOffToolStripMenuItem,
            this.OptionsSoundOnToolStripMenuItem});
      this.OptionsSoundToolStripMenuItem6.Name = "OptionsSoundToolStripMenuItem6";
      this.OptionsSoundToolStripMenuItem6.Size = new System.Drawing.Size(124, 22);
      this.OptionsSoundToolStripMenuItem6.Text = "Dźwięk";
      // 
      // OptionsSoundOffToolStripMenuItem
      // 
      this.OptionsSoundOffToolStripMenuItem.Name = "OptionsSoundOffToolStripMenuItem";
      this.OptionsSoundOffToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
      this.OptionsSoundOffToolStripMenuItem.Text = "Wyłacz";
      this.OptionsSoundOffToolStripMenuItem.Click += new System.EventHandler(this.OptionsSoundOffToolStripMenuItem_Click);
      // 
      // OptionsSoundOnToolStripMenuItem
      // 
      this.OptionsSoundOnToolStripMenuItem.Name = "OptionsSoundOnToolStripMenuItem";
      this.OptionsSoundOnToolStripMenuItem.Size = new System.Drawing.Size(111, 22);
      this.OptionsSoundOnToolStripMenuItem.Text = "Włacz";
      this.OptionsSoundOnToolStripMenuItem.Click += new System.EventHandler(this.OptionsSoundOnToolStripMenuItem_Click);
      // 
      // OptionsAnimationToolStripMenuItem7
      // 
      this.OptionsAnimationToolStripMenuItem7.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OptionsAnimationOffToolStripMenuItem8,
            this.OptionsAnimationOnToolStripMenuItem1});
      this.OptionsAnimationToolStripMenuItem7.Name = "OptionsAnimationToolStripMenuItem7";
      this.OptionsAnimationToolStripMenuItem7.Size = new System.Drawing.Size(124, 22);
      this.OptionsAnimationToolStripMenuItem7.Text = "Animacje";
      // 
      // OptionsAnimationOffToolStripMenuItem8
      // 
      this.OptionsAnimationOffToolStripMenuItem8.Name = "OptionsAnimationOffToolStripMenuItem8";
      this.OptionsAnimationOffToolStripMenuItem8.Size = new System.Drawing.Size(111, 22);
      this.OptionsAnimationOffToolStripMenuItem8.Text = "Wylacz";
      this.OptionsAnimationOffToolStripMenuItem8.Click += new System.EventHandler(this.OptionsAnimationOffToolStripMenuItem8_Click);
      // 
      // OptionsAnimationOnToolStripMenuItem1
      // 
      this.OptionsAnimationOnToolStripMenuItem1.Name = "OptionsAnimationOnToolStripMenuItem1";
      this.OptionsAnimationOnToolStripMenuItem1.Size = new System.Drawing.Size(111, 22);
      this.OptionsAnimationOnToolStripMenuItem1.Text = "Włacz";
      this.OptionsAnimationOnToolStripMenuItem1.Click += new System.EventHandler(this.OptionsAnimationOnToolStripMenuItem1_Click);
      // 
      // RecordsToolStripMenuItem
      // 
      this.RecordsToolStripMenuItem.Name = "RecordsToolStripMenuItem";
      this.RecordsToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
      this.RecordsToolStripMenuItem.Text = "Rekordy";
      this.RecordsToolStripMenuItem.Click += new System.EventHandler(this.RecordsToolStripMenuItem_Click);
      // 
      // button_Start
      // 
      this.button_Start.Location = new System.Drawing.Point(465, 241);
      this.button_Start.Name = "button_Start";
      this.button_Start.Size = new System.Drawing.Size(65, 27);
      this.button_Start.TabIndex = 8;
      this.button_Start.Text = "START";
      this.button_Start.UseVisualStyleBackColor = true;
      // 
      // richTextBox1
      // 
      this.richTextBox1.Location = new System.Drawing.Point(12, 232);
      this.richTextBox1.Name = "richTextBox1";
      this.richTextBox1.Size = new System.Drawing.Size(390, 185);
      this.richTextBox1.TabIndex = 10;
      this.richTextBox1.Text = "";
      // 
      // MainForm
      // 
      this.AllowDrop = true;
      this.ClientSize = new System.Drawing.Size(882, 764);
      this.Controls.Add(this.richTextBox1);
      this.Controls.Add(this.button_Start);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.menuStrip2);
      this.Controls.Add(this.groupBox1);
      this.MainMenuStrip = this.menuStrip2;
      this.Name = "MainForm";
      this.menuStrip2.ResumeLayout(false);
      this.menuStrip2.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem nowaToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem koniecToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem opcjeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem animacjeToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem wylaczToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem wlaczToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem dźwiękToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem wylaczToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem wlaczToolStripMenuItem1;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.MenuStrip menuStrip2;
    private System.Windows.Forms.ToolStripMenuItem GameToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem GameNewToolStripMenuItem3;
    private System.Windows.Forms.ToolStripMenuItem GameEndToolStripMenuItem4;
    private System.Windows.Forms.ToolStripMenuItem OptionsToolStripMenuItem2;
    private System.Windows.Forms.ToolStripMenuItem OptionsSoundToolStripMenuItem6;
    private System.Windows.Forms.ToolStripMenuItem OptionsSoundOffToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem OptionsSoundOnToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem OptionsAnimationToolStripMenuItem7;
    private System.Windows.Forms.ToolStripMenuItem OptionsAnimationOffToolStripMenuItem8;
    private System.Windows.Forms.ToolStripMenuItem OptionsAnimationOnToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem RecordsToolStripMenuItem;
    private System.Windows.Forms.Button button_Start;
    private System.Windows.Forms.RichTextBox richTextBox1;
  }
}

