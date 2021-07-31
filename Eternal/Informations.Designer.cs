namespace Eternal
{
	// Token: 0x02000005 RID: 5
	public partial class Informations : global::MaterialSkin.Controls.MaterialForm
	{
		// Token: 0x06000023 RID: 35 RVA: 0x00004D88 File Offset: 0x00002F88
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00004DC0 File Offset: 0x00002FC0
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Eternal.Informations));
			this.materialLabel1 = new global::MaterialSkin.Controls.MaterialLabel();
			this.gidtxt = new global::MaterialSkin.Controls.MaterialLabel();
			this.pwdtxt = new global::MaterialSkin.Controls.MaterialLabel();
			this.materialLabel4 = new global::MaterialSkin.Controls.MaterialLabel();
			this.materialLabel5 = new global::MaterialSkin.Controls.MaterialLabel();
			this.materialLabel6 = new global::MaterialSkin.Controls.MaterialLabel();
			this.materialContextMenuStrip1 = new global::MaterialSkin.Controls.MaterialContextMenuStrip();
			this.openOnBrowserToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.materialTextBox4 = new global::MaterialSkin.Controls.MaterialTextBox();
			this.materialButton9 = new global::MaterialSkin.Controls.MaterialButton();
			this.columnHeader1 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new global::System.Windows.Forms.ColumnHeader();
			this.columnHeader3 = new global::System.Windows.Forms.ColumnHeader();
			this.materialListView1 = new global::MaterialSkin.Controls.MaterialListView();
			this.materialButton1 = new global::MaterialSkin.Controls.MaterialButton();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.materialContextMenuStrip1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.materialLabel1.AutoSize = true;
			this.materialLabel1.Depth = 0;
			this.materialLabel1.Font = new global::System.Drawing.Font("Roboto Medium", 20f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel1.FontType = global::MaterialSkin.MaterialSkinManager.fontType.H6;
			this.materialLabel1.Location = new global::System.Drawing.Point(483, 264);
			this.materialLabel1.MouseState = global::MaterialSkin.MouseState.HOVER;
			this.materialLabel1.Name = "materialLabel1";
			this.materialLabel1.Size = new global::System.Drawing.Size(270, 24);
			this.materialLabel1.TabIndex = 0;
			this.materialLabel1.Text = "Discord Token: (Click to copy!)";
			this.materialLabel1.Click += new global::System.EventHandler(this.materialLabel1_Click);
			this.gidtxt.AutoSize = true;
			this.gidtxt.Depth = 0;
			this.gidtxt.Font = new global::System.Drawing.Font("Roboto Medium", 20f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Pixel);
			this.gidtxt.FontType = global::MaterialSkin.MaterialSkinManager.fontType.H6;
			this.gidtxt.Location = new global::System.Drawing.Point(483, 75);
			this.gidtxt.MouseState = global::MaterialSkin.MouseState.HOVER;
			this.gidtxt.Name = "gidtxt";
			this.gidtxt.Size = new global::System.Drawing.Size(77, 24);
			this.gidtxt.TabIndex = 1;
			this.gidtxt.Text = "GrowID: ";
			this.pwdtxt.AutoSize = true;
			this.pwdtxt.Depth = 0;
			this.pwdtxt.Font = new global::System.Drawing.Font("Roboto Medium", 20f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Pixel);
			this.pwdtxt.FontType = global::MaterialSkin.MaterialSkinManager.fontType.H6;
			this.pwdtxt.Location = new global::System.Drawing.Point(483, 109);
			this.pwdtxt.MouseState = global::MaterialSkin.MouseState.HOVER;
			this.pwdtxt.Name = "pwdtxt";
			this.pwdtxt.Size = new global::System.Drawing.Size(99, 24);
			this.pwdtxt.TabIndex = 2;
			this.pwdtxt.Text = "Password: ";
			this.materialLabel4.AutoSize = true;
			this.materialLabel4.Depth = 0;
			this.materialLabel4.Font = new global::System.Drawing.Font("Roboto Medium", 20f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel4.FontType = global::MaterialSkin.MaterialSkinManager.fontType.H6;
			this.materialLabel4.Location = new global::System.Drawing.Point(483, 149);
			this.materialLabel4.MouseState = global::MaterialSkin.MouseState.HOVER;
			this.materialLabel4.Name = "materialLabel4";
			this.materialLabel4.Size = new global::System.Drawing.Size(30, 24);
			this.materialLabel4.TabIndex = 3;
			this.materialLabel4.Text = "IP: ";
			this.materialLabel5.AutoSize = true;
			this.materialLabel5.Depth = 0;
			this.materialLabel5.Font = new global::System.Drawing.Font("Roboto Medium", 20f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel5.FontType = global::MaterialSkin.MaterialSkinManager.fontType.H6;
			this.materialLabel5.Location = new global::System.Drawing.Point(483, 186);
			this.materialLabel5.MouseState = global::MaterialSkin.MouseState.HOVER;
			this.materialLabel5.Name = "materialLabel5";
			this.materialLabel5.Size = new global::System.Drawing.Size(55, 24);
			this.materialLabel5.TabIndex = 4;
			this.materialLabel5.Text = "MAC: ";
			this.materialLabel6.AutoSize = true;
			this.materialLabel6.Depth = 0;
			this.materialLabel6.Font = new global::System.Drawing.Font("Roboto Medium", 20f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel6.FontType = global::MaterialSkin.MaterialSkinManager.fontType.H6;
			this.materialLabel6.Location = new global::System.Drawing.Point(483, 222);
			this.materialLabel6.MouseState = global::MaterialSkin.MouseState.HOVER;
			this.materialLabel6.Name = "materialLabel6";
			this.materialLabel6.Size = new global::System.Drawing.Size(129, 24);
			this.materialLabel6.TabIndex = 5;
			this.materialLabel6.Text = "Device Name: ";
			this.materialContextMenuStrip1.BackColor = global::System.Drawing.Color.FromArgb(242, 242, 242);
			this.materialContextMenuStrip1.Depth = 0;
			this.materialContextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.openOnBrowserToolStripMenuItem
			});
			this.materialContextMenuStrip1.MouseState = global::MaterialSkin.MouseState.HOVER;
			this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
			this.materialContextMenuStrip1.Size = new global::System.Drawing.Size(166, 26);
			this.openOnBrowserToolStripMenuItem.Name = "openOnBrowserToolStripMenuItem";
			this.openOnBrowserToolStripMenuItem.Size = new global::System.Drawing.Size(165, 22);
			this.openOnBrowserToolStripMenuItem.Text = "Open on browser";
			this.openOnBrowserToolStripMenuItem.Click += new global::System.EventHandler(this.openOnBrowserToolStripMenuItem_Click);
			this.materialTextBox4.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.materialTextBox4.Depth = 0;
			this.materialTextBox4.Enabled = false;
			this.materialTextBox4.Font = new global::System.Drawing.Font("Roboto", 12f);
			this.materialTextBox4.Hint = "Search for anything...";
			this.materialTextBox4.Location = new global::System.Drawing.Point(12, 418);
			this.materialTextBox4.MaxLength = 50;
			this.materialTextBox4.MouseState = global::MaterialSkin.MouseState.OUT;
			this.materialTextBox4.Multiline = false;
			this.materialTextBox4.Name = "materialTextBox4";
			this.materialTextBox4.Size = new global::System.Drawing.Size(297, 36);
			this.materialTextBox4.TabIndex = 44;
			this.materialTextBox4.Text = "";
			this.materialTextBox4.UseTallSize = false;
			this.materialButton9.AutoSize = false;
			this.materialButton9.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.materialButton9.BackColor = global::System.Drawing.Color.FromArgb(50, 50, 50);
			this.materialButton9.Depth = 0;
			this.materialButton9.DrawShadows = true;
			this.materialButton9.Enabled = false;
			this.materialButton9.ForeColor = global::System.Drawing.Color.FromArgb(222, 255, 255, 255);
			this.materialButton9.HighEmphasis = true;
			this.materialButton9.Icon = null;
			this.materialButton9.Location = new global::System.Drawing.Point(316, 416);
			this.materialButton9.Margin = new global::System.Windows.Forms.Padding(4, 6, 4, 6);
			this.materialButton9.MouseState = global::MaterialSkin.MouseState.HOVER;
			this.materialButton9.Name = "materialButton9";
			this.materialButton9.Size = new global::System.Drawing.Size(147, 40);
			this.materialButton9.TabIndex = 43;
			this.materialButton9.Text = "Export";
			this.materialButton9.Type = global::MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.materialButton9.UseAccentColor = false;
			this.materialButton9.UseVisualStyleBackColor = false;
			this.columnHeader1.Text = "URL";
			this.columnHeader1.Width = 150;
			this.columnHeader2.Text = "Username";
			this.columnHeader2.Width = 150;
			this.columnHeader3.Text = "Password";
			this.columnHeader3.Width = 152;
			this.materialListView1.AutoSizeTable = false;
			this.materialListView1.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 255);
			this.materialListView1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.materialListView1.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader1,
				this.columnHeader2,
				this.columnHeader3
			});
			this.materialListView1.Depth = 0;
			this.materialListView1.FullRowSelect = true;
			this.materialListView1.HideSelection = false;
			this.materialListView1.Location = new global::System.Drawing.Point(12, 75);
			this.materialListView1.MinimumSize = new global::System.Drawing.Size(200, 100);
			this.materialListView1.MouseLocation = new global::System.Drawing.Point(-1, -1);
			this.materialListView1.MouseState = global::MaterialSkin.MouseState.OUT;
			this.materialListView1.Name = "materialListView1";
			this.materialListView1.OwnerDraw = true;
			this.materialListView1.Size = new global::System.Drawing.Size(451, 287);
			this.materialListView1.TabIndex = 7;
			this.materialListView1.UseCompatibleStateImageBehavior = false;
			this.materialListView1.View = global::System.Windows.Forms.View.Details;
			this.materialButton1.AutoSize = false;
			this.materialButton1.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.materialButton1.BackColor = global::System.Drawing.Color.FromArgb(50, 50, 50);
			this.materialButton1.Depth = 0;
			this.materialButton1.DrawShadows = true;
			this.materialButton1.ForeColor = global::System.Drawing.Color.FromArgb(222, 255, 255, 255);
			this.materialButton1.HighEmphasis = true;
			this.materialButton1.Icon = null;
			this.materialButton1.Location = new global::System.Drawing.Point(316, 371);
			this.materialButton1.Margin = new global::System.Windows.Forms.Padding(4, 6, 4, 6);
			this.materialButton1.MouseState = global::MaterialSkin.MouseState.HOVER;
			this.materialButton1.Name = "materialButton1";
			this.materialButton1.Size = new global::System.Drawing.Size(147, 40);
			this.materialButton1.TabIndex = 45;
			this.materialButton1.Text = "Credentıals";
			this.materialButton1.Type = global::MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.materialButton1.UseAccentColor = false;
			this.materialButton1.UseVisualStyleBackColor = false;
			this.materialButton1.Click += new global::System.EventHandler(this.materialButton1_Click);
			this.pictureBox1.ContextMenuStrip = this.materialContextMenuStrip1;
			this.pictureBox1.Location = new global::System.Drawing.Point(485, 302);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(284, 157);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(800, 471);
			base.Controls.Add(this.materialButton1);
			base.Controls.Add(this.materialTextBox4);
			base.Controls.Add(this.materialButton9);
			base.Controls.Add(this.materialListView1);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.materialLabel6);
			base.Controls.Add(this.materialLabel5);
			base.Controls.Add(this.materialLabel4);
			base.Controls.Add(this.pwdtxt);
			base.Controls.Add(this.gidtxt);
			base.Controls.Add(this.materialLabel1);
			base.Icon = (global::System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "Informations";
			base.Sizable = false;
			this.Text = "Account Information";
			base.Load += new global::System.EventHandler(this.Informations_Load);
			this.materialContextMenuStrip1.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400002B RID: 43
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400002C RID: 44
		private global::MaterialSkin.Controls.MaterialLabel materialLabel1;

		// Token: 0x0400002D RID: 45
		private global::MaterialSkin.Controls.MaterialLabel gidtxt;

		// Token: 0x0400002E RID: 46
		private global::MaterialSkin.Controls.MaterialLabel pwdtxt;

		// Token: 0x0400002F RID: 47
		private global::MaterialSkin.Controls.MaterialLabel materialLabel4;

		// Token: 0x04000030 RID: 48
		private global::MaterialSkin.Controls.MaterialLabel materialLabel5;

		// Token: 0x04000031 RID: 49
		private global::MaterialSkin.Controls.MaterialLabel materialLabel6;

		// Token: 0x04000032 RID: 50
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000033 RID: 51
		private global::MaterialSkin.Controls.MaterialTextBox materialTextBox4;

		// Token: 0x04000034 RID: 52
		private global::MaterialSkin.Controls.MaterialButton materialButton9;

		// Token: 0x04000035 RID: 53
		private global::MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;

		// Token: 0x04000036 RID: 54
		private global::System.Windows.Forms.ToolStripMenuItem openOnBrowserToolStripMenuItem;

		// Token: 0x04000037 RID: 55
		private global::System.Windows.Forms.ColumnHeader columnHeader1;

		// Token: 0x04000038 RID: 56
		private global::System.Windows.Forms.ColumnHeader columnHeader2;

		// Token: 0x04000039 RID: 57
		private global::System.Windows.Forms.ColumnHeader columnHeader3;

		// Token: 0x0400003A RID: 58
		private global::MaterialSkin.Controls.MaterialListView materialListView1;

		// Token: 0x0400003B RID: 59
		private global::MaterialSkin.Controls.MaterialButton materialButton1;
	}
}
