namespace picjudge
{
	partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.pbImage = new System.Windows.Forms.PictureBox();
			this.btnNoGood = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.btnLoad = new System.Windows.Forms.Button();
			this.btnBack = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
			this.SuspendLayout();
			// 
			// pbImage
			// 
			this.pbImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pbImage.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.pbImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.pbImage.Location = new System.Drawing.Point(12, 12);
			this.pbImage.Name = "pbImage";
			this.pbImage.Size = new System.Drawing.Size(521, 230);
			this.pbImage.TabIndex = 0;
			this.pbImage.TabStop = false;
			// 
			// btnNoGood
			// 
			this.btnNoGood.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnNoGood.BackColor = System.Drawing.Color.Red;
			this.btnNoGood.Enabled = false;
			this.btnNoGood.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
			this.btnNoGood.Location = new System.Drawing.Point(12, 248);
			this.btnNoGood.Name = "btnNoGood";
			this.btnNoGood.Size = new System.Drawing.Size(218, 97);
			this.btnNoGood.TabIndex = 1;
			this.btnNoGood.Text = "No good";
			this.btnNoGood.UseVisualStyleBackColor = false;
			this.btnNoGood.Click += new System.EventHandler(this.btnNoGood_Click);
			// 
			// btnNext
			// 
			this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNext.BackColor = System.Drawing.Color.Lime;
			this.btnNext.Enabled = false;
			this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNext.Location = new System.Drawing.Point(315, 248);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(218, 97);
			this.btnNext.TabIndex = 2;
			this.btnNext.Text = "Next";
			this.btnNext.UseVisualStyleBackColor = false;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btnLoad
			// 
			this.btnLoad.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnLoad.Location = new System.Drawing.Point(236, 248);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(73, 31);
			this.btnLoad.TabIndex = 3;
			this.btnLoad.Text = "Load";
			this.btnLoad.UseVisualStyleBackColor = true;
			this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// btnBack
			// 
			this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.btnBack.Enabled = false;
			this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
			this.btnBack.Location = new System.Drawing.Point(236, 285);
			this.btnBack.Name = "btnBack";
			this.btnBack.Size = new System.Drawing.Size(73, 60);
			this.btnBack.TabIndex = 4;
			this.btnBack.Text = "Back";
			this.btnBack.UseVisualStyleBackColor = true;
			this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(545, 357);
			this.Controls.Add(this.btnBack);
			this.Controls.Add(this.btnLoad);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.btnNoGood);
			this.Controls.Add(this.pbImage);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "picjudge";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
			this.Resize += new System.EventHandler(this.Form1_Resize);
			((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pbImage;
		private System.Windows.Forms.Button btnNoGood;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.Button btnBack;
	}
}

