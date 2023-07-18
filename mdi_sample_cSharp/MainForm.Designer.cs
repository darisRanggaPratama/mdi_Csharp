namespace mdi_sample_cSharp
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.tsFile = new System.Windows.Forms.ToolStripMenuItem();
			this.tsExit = new System.Windows.Forms.ToolStripMenuItem();
			this.tsControls = new System.Windows.Forms.ToolStripMenuItem();
			this.tsExample = new System.Windows.Forms.ToolStripMenuItem();
			this.tsHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.tsAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.toolSp = new System.Windows.Forms.ToolStrip();
			this.tsbExit = new System.Windows.Forms.ToolStripButton();
			this.tsbHelp = new System.Windows.Forms.ToolStripButton();
			this.menuStrip.SuspendLayout();
			this.toolSp.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsFile,
            this.tsControls,
            this.tsHelp});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(800, 24);
			this.menuStrip.TabIndex = 1;
			this.menuStrip.Text = "MenuStrip";
			// 
			// tsFile
			// 
			this.tsFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsExit});
			this.tsFile.Name = "tsFile";
			this.tsFile.Size = new System.Drawing.Size(37, 20);
			this.tsFile.Text = "File";
			// 
			// tsExit
			// 
			this.tsExit.Name = "tsExit";
			this.tsExit.Size = new System.Drawing.Size(93, 22);
			this.tsExit.Text = "Exit";
			this.tsExit.Click += new System.EventHandler(this.tsExit_Click);
			// 
			// tsControls
			// 
			this.tsControls.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsExample});
			this.tsControls.Name = "tsControls";
			this.tsControls.Size = new System.Drawing.Size(64, 20);
			this.tsControls.Text = "Controls";
			// 
			// tsExample
			// 
			this.tsExample.Name = "tsExample";
			this.tsExample.Size = new System.Drawing.Size(119, 22);
			this.tsExample.Text = "Example";
			this.tsExample.Click += new System.EventHandler(this.tsExample_Click);
			// 
			// tsHelp
			// 
			this.tsHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAbout});
			this.tsHelp.Name = "tsHelp";
			this.tsHelp.Size = new System.Drawing.Size(44, 20);
			this.tsHelp.Text = "Help";
			// 
			// tsAbout
			// 
			this.tsAbout.Name = "tsAbout";
			this.tsAbout.Size = new System.Drawing.Size(123, 22);
			this.tsAbout.Text = "About Us";
			this.tsAbout.Click += new System.EventHandler(this.tsAbout_Click);
			// 
			// toolSp
			// 
			this.toolSp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbExit,
            this.tsbHelp});
			this.toolSp.Location = new System.Drawing.Point(0, 24);
			this.toolSp.Name = "toolSp";
			this.toolSp.Size = new System.Drawing.Size(800, 25);
			this.toolSp.TabIndex = 2;
			this.toolSp.Text = "toolStrip";
			// 
			// tsbExit
			// 
			this.tsbExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbExit.Image = ((System.Drawing.Image)(resources.GetObject("tsbExit.Image")));
			this.tsbExit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbExit.Name = "tsbExit";
			this.tsbExit.Size = new System.Drawing.Size(23, 22);
			this.tsbExit.Text = "Exit";
			this.tsbExit.Click += new System.EventHandler(this.tsbExit_Click);
			// 
			// tsbHelp
			// 
			this.tsbHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.tsbHelp.Image = ((System.Drawing.Image)(resources.GetObject("tsbHelp.Image")));
			this.tsbHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbHelp.Name = "tsbHelp";
			this.tsbHelp.Size = new System.Drawing.Size(23, 22);
			this.tsbHelp.Text = "Help";
			this.tsbHelp.Click += new System.EventHandler(this.tsbHelp_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.toolSp);
			this.Controls.Add(this.menuStrip);
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.menuStrip;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainForm";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.toolSp.ResumeLayout(false);
			this.toolSp.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem tsFile;
		private System.Windows.Forms.ToolStripMenuItem tsControls;
		private System.Windows.Forms.ToolStripMenuItem tsHelp;
		private System.Windows.Forms.ToolStripMenuItem tsExit;
		private System.Windows.Forms.ToolStripMenuItem tsExample;
		private System.Windows.Forms.ToolStripMenuItem tsAbout;
		private System.Windows.Forms.ToolStrip toolSp;
		private System.Windows.Forms.ToolStripButton tsbExit;
		private System.Windows.Forms.ToolStripButton tsbHelp;
	}
}