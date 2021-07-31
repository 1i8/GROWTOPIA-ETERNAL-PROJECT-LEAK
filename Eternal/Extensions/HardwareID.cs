using System;
using System.Diagnostics;
using System.Management;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;

namespace Eternal.Extensions
{
	// Token: 0x02000011 RID: 17
	public class HardwareID
	{
		// Token: 0x060000E4 RID: 228 RVA: 0x00011EDC File Offset: 0x000100DC
		public static string Value()
		{
			bool flag = string.IsNullOrEmpty(HardwareID.fingerPrint);
			if (flag)
			{
				HardwareID.fingerPrint = HardwareID.GetHash(string.Concat(new string[]
				{
					"CPU >> ",
					HardwareID.cpuId(),
					"\nBIOS >> ",
					HardwareID.biosId(),
					"\nBASE >> ",
					HardwareID.baseId()
				}));
			}
			return HardwareID.fingerPrint;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x00011F48 File Offset: 0x00010148
		private static string GetHash(string s)
		{
			MD5 sec = new MD5CryptoServiceProvider();
			ASCIIEncoding enc = new ASCIIEncoding();
			byte[] bt = enc.GetBytes(s);
			return HardwareID.GetHexString(sec.ComputeHash(bt));
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00011F7C File Offset: 0x0001017C
		[DebuggerStepThrough]
		public static void sh1tprotect(string suckname)
		{
			//HardwareID.<sh1tprotect>d__3 <sh1tprotect>d__ = new HardwareID.<sh1tprotect>d__3();
			//<sh1tprotect>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
			//<sh1tprotect>d__.suckname = suckname;
			//<sh1tprotect>d__.<>1__state = -1;
			//<sh1tprotect>d__.<>t__builder.Start<HardwareID.<sh1tprotect>d__3>(ref <sh1tprotect>d__);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00011FB8 File Offset: 0x000101B8
		public static void CheckAll()
		{
			HardwareID.sh1tprotect("HxD");
			HardwareID.sh1tprotect("X64NetDumper");
			HardwareID.sh1tprotect("MegaDumper");
			HardwareID.sh1tprotect("fiddler");
			HardwareID.sh1tprotect("wireshark");
			HardwareID.sh1tprotect("ida");
			HardwareID.sh1tprotect("httpanalyzer");
			HardwareID.sh1tprotect("dnspy");
			HardwareID.sh1tprotect("process hacker 2");
			HardwareID.sh1tprotect("process hacker");
			HardwareID.sh1tprotect("http");
			HardwareID.sh1tprotect("debugger");
			HardwareID.sh1tprotect("ILSpy");
			HardwareID.sh1tprotect("x32_dbg");
			HardwareID.sh1tprotect("x64_dbg");
			HardwareID.sh1tprotect("x64dbg");
			HardwareID.sh1tprotect("x32dbg");
			HardwareID.sh1tprotect("X64NetDumper");
			HardwareID.sh1tprotect("x64netdumper");
			HardwareID.sh1tprotect("PhantOm");
			HardwareID.sh1tprotect("strongod");
			HardwareID.sh1tprotect("dbg");
			HardwareID.sh1tprotect("x96dbg");
			HardwareID.sh1tprotect("reverse");
			HardwareID.sh1tprotect("procmon64");
			HardwareID.sh1tprotect("ollydbg");
			HardwareID.sh1tprotect("peek");
			HardwareID.sh1tprotect("process monitor");
			HardwareID.sh1tprotect("WPE PRO");
			HardwareID.sh1tprotect("ghidra");
			HardwareID.sh1tprotect("de4dotmodded");
			HardwareID.sh1tprotect("brute");
			HardwareID.sh1tprotect("zed");
			HardwareID.sh1tprotect("exeinfope");
			HardwareID.sh1tprotect("james");
			HardwareID.sh1tprotect("sniffer");
			HardwareID.sh1tprotect("dbx");
			HardwareID.sh1tprotect("dbgclr");
			HardwareID.sh1tprotect("kdb");
			HardwareID.sh1tprotect("kgdb");
			HardwareID.sh1tprotect("mdb");
			HardwareID.sh1tprotect("httpdebug");
			HardwareID.sh1tprotect("HTTPDebuggerUI");
			HardwareID.sh1tprotect("PacketEditor");
			HardwareID.sh1tprotect("de4dot");
			HardwareID.sh1tprotect("pexplorer");
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x000121C0 File Offset: 0x000103C0
		private static string GetHexString(byte[] bt)
		{
			string s = string.Empty;
			for (int i = 0; i < bt.Length; i++)
			{
				byte b = bt[i];
				int j = (int)b;
				int n = j & 15;
				int n2 = j >> 4 & 15;
				bool flag = n2 > 9;
				if (flag)
				{
					s += ((char)(n2 - 10 + 65)).ToString();
				}
				else
				{
					s += n2.ToString();
				}
				bool flag2 = n > 9;
				if (flag2)
				{
					s += ((char)(n - 10 + 65)).ToString();
				}
				else
				{
					s += n.ToString();
				}
				bool flag3 = i + 1 != bt.Length && (i + 1) % 2 == 0;
				if (flag3)
				{
					s += "-";
				}
			}
			return s;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0001229C File Offset: 0x0001049C
		private static string identifier(string wmiClass, string wmiProperty, string wmiMustBeTrue)
		{
			string result = "";
			ManagementClass mc = new ManagementClass(wmiClass);
			ManagementObjectCollection moc = mc.GetInstances();
			foreach (ManagementBaseObject managementBaseObject in moc)
			{
				ManagementObject mo = (ManagementObject)managementBaseObject;
				bool flag = mo[wmiMustBeTrue].ToString() == "True";
				if (flag)
				{
					bool flag2 = result == "";
					if (flag2)
					{
						try
						{
							result = mo[wmiProperty].ToString();
							break;
						}
						catch
						{
						}
					}
				}
			}
			return result;
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00012358 File Offset: 0x00010558
		private static string identifier(string wmiClass, string wmiProperty)
		{
			string result = "";
			ManagementClass mc = new ManagementClass(wmiClass);
			ManagementObjectCollection moc = mc.GetInstances();
			foreach (ManagementBaseObject managementBaseObject in moc)
			{
				ManagementObject mo = (ManagementObject)managementBaseObject;
				bool flag = result == "";
				if (flag)
				{
					try
					{
						bool flag2 = mo[wmiProperty] != null;
						if (flag2)
						{
							result = mo[wmiProperty].ToString();
						}
						break;
					}
					catch
					{
					}
				}
			}
			return result;
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00012408 File Offset: 0x00010608
		private static string cpuId()
		{
			string retVal = HardwareID.identifier("Win32_Processor", "UniqueId");
			bool flag = retVal == "";
			if (flag)
			{
				retVal = HardwareID.identifier("Win32_Processor", "ProcessorId");
				bool flag2 = retVal == "";
				if (flag2)
				{
					retVal = HardwareID.identifier("Win32_Processor", "Name");
					bool flag3 = retVal == "";
					if (flag3)
					{
						retVal = HardwareID.identifier("Win32_Processor", "Manufacturer");
					}
					retVal += HardwareID.identifier("Win32_Processor", "MaxClockSpeed");
				}
			}
			return retVal;
		}

		// Token: 0x060000EC RID: 236 RVA: 0x000124A8 File Offset: 0x000106A8
		private static string biosId()
		{
			return string.Concat(new string[]
			{
				HardwareID.identifier("Win32_BIOS", "Manufacturer"),
				HardwareID.identifier("Win32_BIOS", "SMBIOSBIOSVersion"),
				HardwareID.identifier("Win32_BIOS", "IdentificationCode"),
				HardwareID.identifier("Win32_BIOS", "SerialNumber"),
				HardwareID.identifier("Win32_BIOS", "ReleaseDate"),
				HardwareID.identifier("Win32_BIOS", "Version")
			});
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00012534 File Offset: 0x00010734
		private static string diskId()
		{
			return HardwareID.identifier("Win32_DiskDrive", "Model") + HardwareID.identifier("Win32_DiskDrive", "Manufacturer") + HardwareID.identifier("Win32_DiskDrive", "Signature") + HardwareID.identifier("Win32_DiskDrive", "TotalHeads");
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00012588 File Offset: 0x00010788
		private static string baseId()
		{
			return HardwareID.identifier("Win32_BaseBoard", "Model") + HardwareID.identifier("Win32_BaseBoard", "Manufacturer") + HardwareID.identifier("Win32_BaseBoard", "Name") + HardwareID.identifier("Win32_BaseBoard", "SerialNumber");
		}

		// Token: 0x060000EF RID: 239 RVA: 0x000125DC File Offset: 0x000107DC
		private static string videoId()
		{
			return HardwareID.identifier("Win32_VideoController", "DriverVersion") + HardwareID.identifier("Win32_VideoController", "Name");
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00012614 File Offset: 0x00010814
		private static string macId()
		{
			return HardwareID.identifier("Win32_NetworkAdapterConfiguration", "MACAddress", "IPEnabled");
		}

		// Token: 0x040000F6 RID: 246
		private static string fingerPrint = string.Empty;
	}
}
