using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using Eternal.Properties;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Eternal
{
	// Token: 0x0200000B RID: 11
	public partial class Update : MaterialForm
	{
		// Token: 0x06000098 RID: 152 RVA: 0x000112E8 File Offset: 0x0000F4E8
		public Update(string link)
		{
			IniParser parser = new IniParser("config.ini");
			string save = parser.GetSetting("MainForm", "Style");
			string darkmode = parser.GetSetting("MainForm", "DarkMode");
			MaterialSkinManager skinManager = MaterialSkinManager.Instance;
			try
			{
				bool flag = save == "3";
				if (flag)
				{
					base.SkinManager.AddFormToManage(this);
					base.SkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green800, Primary.Green900, Accent.Green100, TextShade.WHITE);
				}
				bool flag2 = save == "0" || save == "1";
				if (flag2)
				{
					base.SkinManager.AddFormToManage(this);
					base.SkinManager.ColorScheme = new ColorScheme(Primary.Blue600, Primary.Blue800, Primary.Blue900, Accent.Blue100, TextShade.WHITE);
				}
				bool flag3 = save == "2";
				if (flag3)
				{
					base.SkinManager.AddFormToManage(this);
					base.SkinManager.ColorScheme = new ColorScheme(Primary.Cyan600, Primary.Cyan800, Primary.Cyan900, Accent.Cyan100, TextShade.WHITE);
				}
				bool flag4 = save == "4";
				if (flag4)
				{
					base.SkinManager.AddFormToManage(this);
					base.SkinManager.ColorScheme = new ColorScheme(Primary.LightBlue600, Primary.LightBlue800, Primary.LightBlue900, Accent.LightBlue100, TextShade.WHITE);
				}
				bool flag5 = darkmode == "1";
				if (flag5)
				{
					base.SkinManager.Theme = MaterialSkinManager.Themes.DARK;
				}
				else
				{
					base.SkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
				}
			}
			catch
			{
				base.SkinManager.AddFormToManage(this);
				base.SkinManager.Theme = MaterialSkinManager.Themes.DARK;
				base.SkinManager.ColorScheme = new ColorScheme(Primary.Blue600, Primary.Blue800, Primary.Blue900, Accent.Blue100, TextShade.WHITE);
				base.SkinManager.Theme = MaterialSkinManager.Themes.DARK;
			}
			Eternal.Update.otz = link;
			this.InitializeComponent();
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0001152C File Offset: 0x0000F72C
		private void startDownload(string a)
		{
			Thread thread = new Thread(delegate()
			{
				WebClient client = new WebClient();
				client.DownloadProgressChanged += this.client_DownloadProgressChanged;
				client.DownloadFileCompleted += this.client_DownloadFileCompleted;
				client.DownloadFileAsync(new Uri(a), Application.StartupPath + "\\Eternal.zip");
			});
			thread.Start();
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00011568 File Offset: 0x0000F768
		private void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			base.BeginInvoke(new MethodInvoker(delegate()
			{
				double bytesIn = double.Parse(e.BytesReceived.ToString());
				double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
				double percentage = bytesIn / totalBytes * 100.0;
				this.materialLabel2.Text = "Downloading requirements...";
				this.progressBar1.Value = int.Parse(Math.Truncate(percentage).ToString());
			}));
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0001159D File Offset: 0x0000F79D
		private void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
		{
			base.BeginInvoke(new MethodInvoker(delegate()
			{
				this.materialLabel2.Text = "Status: Completed";
			}));
			ZipFile.ExtractToDirectory("Eternal.zip", Application.StartupPath);
			File.Delete("Eternal.zip");
			Environment.Exit(-1);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x000115D5 File Offset: 0x0000F7D5
		private void Update_Load(object sender, EventArgs e)
		{
			base.BeginInvoke(new MethodInvoker(delegate()
			{
				this.startDownload(Eternal.Update.otz);
			}));
		}

		// Token: 0x0600009D RID: 157 RVA: 0x000115EB File Offset: 0x0000F7EB
		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x040000D7 RID: 215
		public static string otz;
	}
}
