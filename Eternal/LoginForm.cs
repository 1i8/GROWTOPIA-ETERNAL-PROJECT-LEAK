using System;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Eternal.Extensions;
using Eternal.Properties;
using IWshRuntimeLibrary;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.CSharp.RuntimeBinder;
using Microsoft.Win32;

namespace Eternal
{
	// Token: 0x02000008 RID: 8
	public partial class LoginForm : MaterialForm
	{
		// Token: 0x06000033 RID: 51 RVA: 0x00006548 File Offset: 0x00004748
		public LoginForm()
		{
			base.SkinManager.AddFormToManage(this);
			base.SkinManager.Theme = MaterialSkinManager.Themes.DARK;
			base.SkinManager.ColorScheme = new ColorScheme(Primary.Blue600, Primary.Blue800, Primary.Blue900, Accent.Blue100, TextShade.WHITE);
			base.SkinManager.Theme = MaterialSkinManager.Themes.DARK;
			bool flag = !File.Exists("config.ini");
			if (flag)
			{
				File.Create("config.ini").Close();
				IniParser parser = new IniParser("config.ini");
				parser.AddSetting("MainForm", "DarkMode", "1");
				parser.AddSetting("MainForm", "Style", "0");
				parser.SaveSettings();
			}
			this.InitializeComponent();
		}

		// Token: 0x06000034 RID: 52 RVA: 0x00006620 File Offset: 0x00004820
		private void CreateShortcut()
		{
			//object shDesktop = "Desktop";
			//WshShell shell = (WshShell)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("72C24DD5-D70A-438B-8A42-98424B88AFB8")));
			//if (LoginForm.<>o__1.<>p__0 == null)
			//{
			//	LoginForm.<>o__1.<>p__0 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(string), typeof(LoginForm)));
			//}
			//string shortcutAddress = LoginForm.<>o__1.<>p__0.Target(LoginForm.<>o__1.<>p__0, shell.SpecialFolders.Item(ref shDesktop)) + "\\Eternal.lnk";
			//bool flag = !File.Exists(shortcutAddress);
			//if (flag)
			//{
			//	if (LoginForm.<>o__1.<>p__1 == null)
			//	{
			//		LoginForm.<>o__1.<>p__1 = CallSite<Func<CallSite, object, IWshShortcut>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(IWshShortcut), typeof(LoginForm)));
			//	}
			//	IWshShortcut shortcut = LoginForm.<>o__1.<>p__1.Target(LoginForm.<>o__1.<>p__1, shell.CreateShortcut(shortcutAddress));
			//	shortcut.Description = "New shortcut for a Eternal";
			//	shortcut.TargetPath = Application.StartupPath + "\\Eternal.exe";
			//	shortcut.Save();
			//}
		}

		// Token: 0x06000035 RID: 53 RVA: 0x00006730 File Offset: 0x00004930
		private void LoginForm_Load(object sender, EventArgs e)
		{
			Directory.SetCurrentDirectory(Application.StartupPath);
			this.CreateShortcut();
			HardwareID.CheckAll();
			ServicePointManager.Expect100Continue = true;
			ServicePointManager.SecurityProtocol = (SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12);
			using (RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Default).OpenSubKey("Eternal"))
			{
				bool flag = key != null;
				if (flag)
				{
					this.materialTextBox2.Text = key.GetValue("Username").ToString();
					this.materialTextBox1.Text = key.GetValue("Password").ToString();
				}
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000067E0 File Offset: 0x000049E0
		private void materialSwitch1_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.materialSwitch1.Checked;
			if (@checked)
			{
				this.materialButton1.Text = "REGISTER";
			}
			else
			{
				this.materialButton1.Text = "LOGIN";
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00006828 File Offset: 0x00004A28
		public static string RandomString(int length)
		{
			return new string((from s in Enumerable.Repeat<string>("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", length)
			select s[LoginForm.random.Next(s.Length)]).ToArray<char>());
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00006874 File Offset: 0x00004A74
		private void materialButton1_Click(object sender, EventArgs e)
		{
			HardwareID.CheckAll();
			try
			{
				bool flag = this.materialButton1.Text == "REGISTER";
				if (flag)
				{
					bool flag2 = this.materialTextBox2.Text.Length < 3 || this.materialTextBox1.Text.Length < 8;
					if (flag2)
					{
						MessageBox.Show("Minimun length for username is 3 and password is 8.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
					else
					{
						NameValueCollection register = new NameValueCollection();
						register["466811e681157718e06ab363ccb94ef7"] = this.materialTextBox2.Text.Base64Encode();
						register["249787af0a161ae95ec62e385b5e49cb"] = this.materialTextBox1.Text.Hash();
						register["fa6eeea2a6b5add63366a6cf9ab24738"] = HardwareID.Value().Base64Encode();
						register["8351db1dd1bc8e37b3dbd8cde98c5f91"] = "c6075913682cfd0b002cd83b2f505967";
						for (int i = 1; i <= 10; i++)
						{
							register[LoginForm.RandomString(40).ToLower()] = LoginForm.RandomString(40).ToLower();
						}
						byte[] rawresponse = Program.client.UploadValues("http://" + Variables.basedata.Base64Decode() + "/login/f602542fea54fe6d9e9315f89cf78cda.php", register);
						string response = Encoding.Default.GetString(rawresponse);
						Console.WriteLine("Register: " + response);
						string text = response;
						string a2 = text;
						if (!(a2 == "success"))
						{
							if (!(a2 == "overuse"))
							{
								if (!(a2 == "fail"))
								{
									if (!(a2 == "vpn"))
									{
										MessageBox.Show(response);
										MessageBox.Show("There is an error with our database. Please contact the developers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
									}
									else
									{
										MessageBox.Show("VPN/Any type of proxy are not allowed!", "VPN/Proxy are Prohibited", MessageBoxButtons.OK, MessageBoxIcon.Hand);
									}
								}
								else
								{
									MessageBox.Show("There is an error with our database. Please contact the developers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
								}
							}
							else
							{
								MessageBox.Show("The username is taken or your HWID already exists in the database.", "Multiple accounts are not allowed.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
							}
						}
						else
						{
							MessageBox.Show("Registered Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
							this.materialSwitch1.Checked = false;
						}
					}
				}
				else
				{
					NameValueCollection register2 = new NameValueCollection();
					string hwid = HardwareID.Value();
					register2["username"] = this.materialTextBox2.Text;
					register2["password"] = this.materialTextBox1.Text.Hash();
					register2["hwid"] = hwid;
					byte[] rawresponse2 = Program.client.UploadValues("http://" + Variables.basedata.Base64Decode() + "/login/052a7c9f173fe4291420ebc66985cfcc.php", register2);
					string response2 = Encoding.Default.GetString(rawresponse2).Base64Decode();
					Console.WriteLine(response2);
					bool flag3 = response2.Contains("success");
					if (flag3)
					{
						string[] split = response2.Split(new char[]
						{
							'|'
						});
						Variables.AccountType = Convert.ToInt32(split[1]);
						Variables.Username = this.materialTextBox2.Text;
						Variables.Password = this.materialTextBox1.Text;
						Variables.Hwid = hwid;
						using (RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Default).CreateSubKey("Eternal"))
						{
							bool flag4 = key != null;
							if (flag4)
							{
								key.SetValue("Username", this.materialTextBox2.Text);
								key.SetValue("Password", this.materialTextBox1.Text);
							}
						}
						bool flag5 = !File.Exists("config.ini");
						if (flag5)
						{
							FileStream fs = File.Open("config.ini", FileMode.OpenOrCreate);
							fs.Close();
						}
						base.Hide();
						MainForm mainForm = new MainForm();
						mainForm.Closed += delegate(object s, EventArgs args)
						{
							base.Close();
						};
						mainForm.Show();
					}
					else
					{
						string[] split2 = response2.Split(new char[]
						{
							'|'
						});
						string text2 = split2[0];
						string a3 = text2;
						if (!(a3 == "noacc"))
						{
							if (!(a3 == "ban"))
							{
								if (!(a3 == "fail"))
								{
									if (!(a3 == "stolen"))
									{
										MessageBox.Show("There is an error with our database. Please contact the developers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
									}
									else
									{
										MessageBox.Show("This is not your account or you are using a different device.", "Unknown device", MessageBoxButtons.OK, MessageBoxIcon.Hand);
									}
								}
								else
								{
									MessageBox.Show("There is an error with our database. Please contact the developers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
								}
							}
							else
							{
								MessageBox.Show("Sorry but you're banned/blacklisted.", "Your account has been banned.", MessageBoxButtons.OK, MessageBoxIcon.Hand);
							}
						}
						else
						{
							MessageBox.Show("Account doesn't find on server", "Eternal", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						}
					}
				}
			}
			catch (Exception a)
			{
				MessageBox.Show(a.Message + "\nNote: Close the fiddler or any shit!", "Eternal", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00006D70 File Offset: 0x00004F70
		private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			Environment.Exit(1);
		}

		// Token: 0x0400003F RID: 63
		private static Random random = new Random();
	}
}
