using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Windows.Forms;
using AccCheckerLib;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Eternal
{
	// Token: 0x02000003 RID: 3
	public partial class AccountChecker : MaterialForm
	{
		// Token: 0x06000007 RID: 7 RVA: 0x00002064 File Offset: 0x00000264
		public AccountChecker(string growid, string password)
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
			bool flag6 = !string.IsNullOrEmpty(growid) || !string.IsNullOrEmpty(password);
			if (flag6)
			{
				this.growdi.Text = growid;
				this.pass.Text = password;
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000022D8 File Offset: 0x000004D8
		public static bool IsAdministrator()
		{
			bool result;
			using (WindowsIdentity identity = WindowsIdentity.GetCurrent())
			{
				WindowsPrincipal principal = new WindowsPrincipal(identity);
				result = principal.IsInRole(WindowsBuiltInRole.Administrator);
			}
			return result;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002320 File Offset: 0x00000520
		public static void SaveSettings(string ip, string port)
		{
			IniParser parser = new IniParser("config.ini");
			parser.AddSetting("Checker", "ip", ip);
			parser.AddSetting("Checker", "port", port);
			parser.SaveSettings();
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002364 File Offset: 0x00000564
		public static string GetRandomMacAddress()
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

		// Token: 0x0600000B RID: 11 RVA: 0x000023CC File Offset: 0x000005CC
		private void AccountChecker_Load(object sender, EventArgs e)
		{
			this.serverport.Text = CheckerData.serverport;
			this.serverip.Text = CheckerData.serverip;
			try
			{
				this.maclar.SelectedIndex = 0;
			}
			catch
			{
				Application.DoEvents();
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002428 File Offset: 0x00000628
		private void Status_valueChanged(object sender, EventArgs e)
		{
			string txt = (sender as StringEvt).Text;
			this.stats.Text = "Status: " + txt;
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0000245C File Offset: 0x0000065C
		[DebuggerStepThrough]
		public void ProcessItemPrices()
		{
			//AccountChecker.<ProcessItemPrices>d__6 <ProcessItemPrices>d__ = new AccountChecker.<ProcessItemPrices>d__6();
			//<ProcessItemPrices>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			//<ProcessItemPrices>d__.<>4__this = this;
			//<ProcessItemPrices>d__.<>1__state = -1;
			//<ProcessItemPrices>d__.<>t__builder.Start<AccountChecker.<ProcessItemPrices>d__6>(ref <ProcessItemPrices>d__);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002498 File Offset: 0x00000698
		private void OnCheckingDone_CheckingDone(object sender, EventArgs e)
		{
			CheckingEvent evt = sender as CheckingEvent;
			bool flag = evt != null;
			if (flag)
			{
				UserInfo value = evt.UserInfo;
				bool success = value.Success;
				if (success)
				{
					this.wltext.Text = "World Locks: " + value.WorldLock_Balance;
					this.level.Text = "Level: " + value.PlayerLevel + " - Supporter: " + value.Supporter.ToString();
					this.gem.Text = "Gems: " + value.GemAmount;
					this.total.Text = "Hours Played: " + value.Hours_Played;
					foreach (PlayerInvItems items in value.InventoryItems)
					{
						string[] init = new string[5];
						ItemDatabase.ItemDefinition itemDef = ItemDatabase.GetItemDef((int)items.itemID);
						string[] array = init;
						int num = 0;
						short itemID = items.itemID;
						array[num] = itemID.ToString();
						init[1] = itemDef.itemName;
						string[] array2 = init;
						int num2 = 2;
						byte b = items.count;
						array2[num2] = b.ToString();
						init[3] = "Not Checked..";
						string[] array3 = init;
						int num3 = 4;
						bool equipped = items.equipped;
						array3[num3] = equipped.ToString();
						this.checkinfo.Items.Add(new ListViewItem(init));
					}
					foreach (string items2 in value.Worlds)
					{
						this.WORLDS.Items.Add(items2);
					}
					Console.WriteLine("Checking is done!");
					this.stats.Text = "Status: Idle";
				}
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002690 File Offset: 0x00000890
		private void materialTextBox1_TextChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002694 File Offset: 0x00000894
		private void materialButton1_Click(object sender, EventArgs e)
		{
			bool flag = string.IsNullOrEmpty(CheckerData.serverip) || string.IsNullOrEmpty(CheckerData.serverport);
			if (flag)
			{
				MessageBox.Show("Server ip or port not found. Please pull data on Settings Tab.", "Eternal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
			{
				bool flag2 = !string.IsNullOrEmpty(this.growdi.Text) || !string.IsNullOrEmpty(this.pass.Text);
				if (flag2)
				{
					this.WORLDS.Items.Clear();
					this.checkinfo.Items.Clear();
					this.level.Text = "Level: 0 - Supporter: false";
					this.gem.Text = "Gems: 0";
					this.wltext.Text = "World Locks: 0";
					this.total.Text = "Hours Played: 0";
					AccChecker acccheckerInstace = new AccChecker(this.growdi.Text, this.pass.Text, CheckerData.serverip, CheckerData.serverport, "4.20");
					acccheckerInstace.initialize(this.maclar.SelectedItem.ToString().Replace(":", ""));
					acccheckerInstace.status.valueChanged += this.Status_valueChanged;
					acccheckerInstace.OnCheckingDone.CheckingDone += this.OnCheckingDone_CheckingDone;
					acccheckerInstace.ConnectCurrent();
				}
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000027F9 File Offset: 0x000009F9
		private void materialButton3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000027FC File Offset: 0x000009FC
		private void materialButton2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000027FF File Offset: 0x000009FF
		private void groupBox1_Enter(object sender, EventArgs e)
		{
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002804 File Offset: 0x00000A04
		[DebuggerStepThrough]
		private void materialButton4_Click(object sender, EventArgs e)
		{
			//AccountChecker.<materialButton4_Click>d__13 <materialButton4_Click>d__ = new AccountChecker.<materialButton4_Click>d__13();
			//<materialButton4_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			//<materialButton4_Click>d__.<>4__this = this;
			//<materialButton4_Click>d__.sender = sender;
			//<materialButton4_Click>d__.e = e;
			//<materialButton4_Click>d__.<>1__state = -1;
			//<materialButton4_Click>d__.<>t__builder.Start<AccountChecker.<materialButton4_Click>d__13>(ref <materialButton4_Click>d__);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x0000284C File Offset: 0x00000A4C
		private void materialButton5_Click(object sender, EventArgs e)
		{
			string aa = AccountChecker.GetRandomMacAddress();
			this.maclar.Items.Clear();
			this.maclar.Items.Add(aa);
			this.maclar.SelectedItem = aa;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002890 File Offset: 0x00000A90
		private void materialButton2_Click_1(object sender, EventArgs e)
		{
			this.materialTabControl1.SelectedIndex = 2;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000028A0 File Offset: 0x00000AA0
		[DebuggerStepThrough]
		private void processPricesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			//AccountChecker.<processPricesToolStripMenuItem_Click>d__16 <processPricesToolStripMenuItem_Click>d__ = new AccountChecker.<processPricesToolStripMenuItem_Click>d__16();
			//<processPricesToolStripMenuItem_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			//<processPricesToolStripMenuItem_Click>d__.<>4__this = this;
			//<processPricesToolStripMenuItem_Click>d__.sender = sender;
			//<processPricesToolStripMenuItem_Click>d__.e = e;
			//<processPricesToolStripMenuItem_Click>d__.<>1__state = -1;
			//<processPricesToolStripMenuItem_Click>d__.<>t__builder.Start<AccountChecker.<processPricesToolStripMenuItem_Click>d__16>(ref <processPricesToolStripMenuItem_Click>d__);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000028E7 File Offset: 0x00000AE7
		private void materialLabel2_Click(object sender, EventArgs e)
		{
		}
	}
}
