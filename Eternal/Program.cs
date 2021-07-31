using System;
using System.IO;
using System.Net;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using Eternal.Properties;

namespace Eternal
{
	// Token: 0x0200000A RID: 10
	internal static class Program
	{
		// Token: 0x06000095 RID: 149 RVA: 0x000110B8 File Offset: 0x0000F2B8
		public static bool IsSingleInstance()
		{
			Program._mutex = new Mutex(false, Assembly.GetExecutingAssembly().GetName().Name);
			GC.KeepAlive(Program._mutex);
			bool result;
			try
			{
				result = Program._mutex.WaitOne(0, false);
			}
			catch (AbandonedMutexException)
			{
				Program._mutex.ReleaseMutex();
				result = Program._mutex.WaitOne(0, false);
			}
			return result;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00011128 File Offset: 0x0000F328
		[STAThread]
		private static void Main()
		{
			try
			{
				Variables.basedata = "MzcuMTIzLjk3LjEwNw==";
			}
			catch
			{
				Variables.basedata = "MzcuMTIzLjk3LjEwNw==";
			}
			bool flag = !Program.IsSingleInstance();
			if (flag)
			{
				MessageBox.Show("One instance of the Project Eternal is already running, go use that one!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Environment.Exit(-1);
			}
			else
			{
				ServicePointManager.Expect100Continue = true;
				ServicePointManager.SecurityProtocol = (SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12);
				bool flag2 = !File.Exists("WebDriver.dll");
				if (flag2)
				{
					File.WriteAllBytes("WebDriver.dll", Resources.WebDriver);
				}
				bool flag3 = !File.Exists("AccCheckerLib.dll");
				if (flag3)
				{
					File.WriteAllBytes("AccCheckerLib.dll", Resources.AccCheckerLib);
				}
				bool flag4 = !File.Exists("ENet.Managed.dll");
				if (flag4)
				{
					File.WriteAllBytes("ENet.Managed.dll", Resources.ENet_Managed);
				}
				bool flag5 = !File.Exists("System.Buffers.dll");
				if (flag5)
				{
					File.WriteAllBytes("System.Buffers.dll", Resources.System_Buffers);
				}
				bool flag6 = !File.Exists("WebAPI.dll");
				if (flag6)
				{
					File.WriteAllBytes("WebAPI.dll", Resources.WebAPI);
				}
				bool flag7 = !File.Exists("Newtonsoft.Json.dll");
				if (flag7)
				{
					File.WriteAllBytes("Newtonsoft.Json.dll", Resources.Newtonsoft_Json);
				}
				bool flag8 = !File.Exists("WebDriver.Support.dll");
				if (flag8)
				{
					File.WriteAllBytes("WebDriver.Support.dll", Resources.WebDriver_Support);
				}
				bool flag9 = !File.Exists("discord-rpc-w32.dll");
				if (flag9)
				{
					File.WriteAllBytes("discord-rpc-w32.dll", Resources.discord_rpc_w32);
				}
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run(new MainForm());
			}
		}

		// Token: 0x040000D5 RID: 213
		public static EternalClient client = new EternalClient();

		// Token: 0x040000D6 RID: 214
		private static Mutex _mutex;
	}
}
