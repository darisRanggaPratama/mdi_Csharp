namespace mdi_sample_cSharp
{
	partial class AboutForm
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.lblTitle = new System.Windows.Forms.Label();
			this.linkLabel = new System.Windows.Forms.LinkLabel();
			this.btnClose = new System.Windows.Forms.Button();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// imageList1
			// 
			this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.Location = new System.Drawing.Point(456, 8);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(174, 57);
			this.lblTitle.TabIndex = 1;
			this.lblTitle.Text = "AutoBot";
			// 
			// linkLabel
			// 
			this.linkLabel.AutoSize = true;
			this.linkLabel.Location = new System.Drawing.Point(504, 80);
			this.linkLabel.Name = "linkLabel";
			this.linkLabel.Size = new System.Drawing.Size(85, 13);
			this.linkLabel.TabIndex = 2;
			this.linkLabel.TabStop = true;
			this.linkLabel.Text = "www.hyvoy.com";
			this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
			// 
			// btnClose
			// 
			this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnClose.Location = new System.Drawing.Point(520, 408);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 32);
			this.btnClose.TabIndex = 3;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// pictureBox
			// 
			this.pictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.BackgroundImage")));
			this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox.Location = new System.Drawing.Point(8, 8);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(352, 392);
			this.pictureBox.TabIndex = 4;
			this.pictureBox.TabStop = false;
			// 
			// AboutForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.pictureBox);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.linkLabel);
			this.Controls.Add(this.lblTitle);
			this.Name = "AboutForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "About Us";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ImageList imageList1;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.LinkLabel linkLabel;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.PictureBox pictureBox;
	}
}

