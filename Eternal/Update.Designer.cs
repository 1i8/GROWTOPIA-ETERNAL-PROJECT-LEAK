namespace Eternal
{
	// Token: 0x0200000B RID: 11
	public partial class Update : global::MaterialSkin.Controls.MaterialForm
	{
		// Token: 0x0600009E RID: 158 RVA: 0x000115F0 File Offset: 0x0000F7F0
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00011628 File Offset: 0x0000F828
		private void InitializeComponent()
		{
			this.progressBar1 = new global::System.Windows.Forms.ProgressBar();
			this.materialLabel1 = new global::MaterialSkin.Controls.MaterialLabel();
			this.materialLabel2 = new global::MaterialSkin.Controls.MaterialLabel();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.progressBar1.Location = new global::System.Drawing.Point(12, 230);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new global::System.Drawing.Size(553, 41);
			this.progressBar1.TabIndex = 0;
			this.materialLabel1.AutoSize = true;
			this.materialLabel1.Depth = 0;
			this.materialLabel1.Font = new global::System.Drawing.Font("Roboto", 24f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel1.FontType = global::MaterialSkin.MaterialSkinManager.fontType.H5;
			this.materialLabel1.Location = new global::System.Drawing.Point(60, 138);
			this.materialLabel1.MouseState = global::MaterialSkin.MouseState.HOVER;
			this.materialLabel1.Name = "materialLabel1";
			this.materialLabel1.Size = new global::System.Drawing.Size(308, 29);
			this.materialLabel1.TabIndex = 1;
			this.materialLabel1.Text = "Updating, please be patient...";
			this.materialLabel2.AutoSize = true;
			this.materialLabel2.Depth = 0;
			this.materialLabel2.Font = new global::System.Drawing.Font("Roboto", 16f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel2.FontType = global::MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
			this.materialLabel2.Location = new global::System.Drawing.Point(12, 208);
			this.materialLabel2.MouseState = global::MaterialSkin.MouseState.HOVER;
			this.materialLabel2.Name = "materialLabel2";
			this.materialLabel2.Size = new global::System.Drawing.Size(55, 19);
			this.materialLabel2.TabIndex = 2;
			this.materialLabel2.Text = "Status: ";
			this.pictureBox1.Image = global::Eternal.Properties.Resources.eter;
			this.pictureBox1.Location = new global::System.Drawing.Point(397, 79);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(168, 145);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new global::System.EventHandler(this.pictureBox1_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(577, 283);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.materialLabel2);
			base.Controls.Add(this.materialLabel1);
			base.Controls.Add(this.progressBar1);
			base.MaximizeBox = false;
			base.Name = "Update";
			base.Sizable = false;
			this.Text = "Update Wizard";
			base.Load += new global::System.EventHandler(this.Update_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040000D8 RID: 216
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040000D9 RID: 217
		private global::System.Windows.Forms.ProgressBar progressBar1;

		// Token: 0x040000DA RID: 218
		private global::MaterialSkin.Controls.MaterialLabel materialLabel1;

		// Token: 0x040000DB RID: 219
		private global::MaterialSkin.Controls.MaterialLabel materialLabel2;

		// Token: 0x040000DC RID: 220
		private global::System.Windows.Forms.PictureBox pictureBox1;
	}
}
