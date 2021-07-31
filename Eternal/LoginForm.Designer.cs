namespace Eternal
{
	// Token: 0x02000008 RID: 8
	public partial class LoginForm : global::MaterialSkin.Controls.MaterialForm
	{
		// Token: 0x0600003A RID: 58 RVA: 0x00006D7C File Offset: 0x00004F7C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00006DB4 File Offset: 0x00004FB4
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Eternal.LoginForm));
			this.materialTextBox2 = new global::MaterialSkin.Controls.MaterialTextBox();
			this.materialTextBox1 = new global::MaterialSkin.Controls.MaterialTextBox();
			this.materialButton1 = new global::MaterialSkin.Controls.MaterialButton();
			this.materialSwitch1 = new global::MaterialSkin.Controls.MaterialSwitch();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.materialTextBox2.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.materialTextBox2.Depth = 0;
			this.materialTextBox2.Font = new global::System.Drawing.Font("Roboto", 12f);
			this.materialTextBox2.Hint = "Username";
			this.materialTextBox2.Location = new global::System.Drawing.Point(38, 309);
			this.materialTextBox2.MaxLength = 50;
			this.materialTextBox2.MouseState = global::MaterialSkin.MouseState.OUT;
			this.materialTextBox2.Multiline = false;
			this.materialTextBox2.Name = "materialTextBox2";
			this.materialTextBox2.Size = new global::System.Drawing.Size(319, 36);
			this.materialTextBox2.TabIndex = 2;
			this.materialTextBox2.Text = "";
			this.materialTextBox2.UseTallSize = false;
			this.materialTextBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.materialTextBox1.Depth = 0;
			this.materialTextBox1.Font = new global::System.Drawing.Font("Roboto", 12f);
			this.materialTextBox1.Hint = "Password";
			this.materialTextBox1.Location = new global::System.Drawing.Point(38, 362);
			this.materialTextBox1.MaxLength = 50;
			this.materialTextBox1.MouseState = global::MaterialSkin.MouseState.OUT;
			this.materialTextBox1.Multiline = false;
			this.materialTextBox1.Name = "materialTextBox1";
			this.materialTextBox1.Password = true;
			this.materialTextBox1.Size = new global::System.Drawing.Size(319, 36);
			this.materialTextBox1.TabIndex = 3;
			this.materialTextBox1.Text = "";
			this.materialTextBox1.UseTallSize = false;
			this.materialButton1.AutoSize = false;
			this.materialButton1.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.materialButton1.Depth = 0;
			this.materialButton1.DrawShadows = true;
			this.materialButton1.HighEmphasis = true;
			this.materialButton1.Icon = null;
			this.materialButton1.Location = new global::System.Drawing.Point(227, 407);
			this.materialButton1.Margin = new global::System.Windows.Forms.Padding(4, 6, 4, 6);
			this.materialButton1.MouseState = global::MaterialSkin.MouseState.HOVER;
			this.materialButton1.Name = "materialButton1";
			this.materialButton1.Size = new global::System.Drawing.Size(130, 36);
			this.materialButton1.TabIndex = 4;
			this.materialButton1.Text = "LOGIN";
			this.materialButton1.Type = global::MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.materialButton1.UseAccentColor = false;
			this.materialButton1.UseVisualStyleBackColor = true;
			this.materialButton1.Click += new global::System.EventHandler(this.materialButton1_Click);
			this.materialSwitch1.AutoSize = true;
			this.materialSwitch1.BackColor = global::System.Drawing.Color.FromArgb(50, 50, 50);
			this.materialSwitch1.Depth = 0;
			this.materialSwitch1.ForeColor = global::System.Drawing.Color.FromArgb(222, 255, 255, 255);
			this.materialSwitch1.Location = new global::System.Drawing.Point(38, 408);
			this.materialSwitch1.Margin = new global::System.Windows.Forms.Padding(0);
			this.materialSwitch1.MouseLocation = new global::System.Drawing.Point(-1, -1);
			this.materialSwitch1.MouseState = global::MaterialSkin.MouseState.HOVER;
			this.materialSwitch1.Name = "materialSwitch1";
			this.materialSwitch1.Ripple = true;
			this.materialSwitch1.Size = new global::System.Drawing.Size(159, 37);
			this.materialSwitch1.TabIndex = 5;
			this.materialSwitch1.Text = "Register Mode";
			this.materialSwitch1.UseVisualStyleBackColor = false;
			this.materialSwitch1.CheckedChanged += new global::System.EventHandler(this.materialSwitch1_CheckedChanged);
			this.pictureBox1.Image = global::Eternal.Properties.Resources.eter1;
			this.pictureBox1.Location = new global::System.Drawing.Point(3, 67);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(389, 289);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(395, 568);
			base.Controls.Add(this.materialSwitch1);
			base.Controls.Add(this.materialButton1);
			base.Controls.Add(this.materialTextBox1);
			base.Controls.Add(this.materialTextBox2);
			base.Controls.Add(this.pictureBox1);
			base.Icon = (global::System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "LoginForm";
			base.Sizable = false;
			this.Text = "Project Eternal";
			base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
			base.Load += new global::System.EventHandler(this.LoginForm_Load);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000040 RID: 64
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000041 RID: 65
		private global::MaterialSkin.Controls.MaterialTextBox materialTextBox2;

		// Token: 0x04000042 RID: 66
		private global::MaterialSkin.Controls.MaterialTextBox materialTextBox1;

		// Token: 0x04000043 RID: 67
		private global::MaterialSkin.Controls.MaterialButton materialButton1;

		// Token: 0x04000044 RID: 68
		private global::MaterialSkin.Controls.MaterialSwitch materialSwitch1;

		// Token: 0x04000045 RID: 69
		private global::System.Windows.Forms.PictureBox pictureBox1;
	}
}
