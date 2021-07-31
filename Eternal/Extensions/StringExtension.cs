using System;
using System.IO;
using System.IO.Compression;
using System.Security.Cryptography;
using System.Text;

namespace Eternal.Extensions
{
	// Token: 0x02000013 RID: 19
	public static class StringExtension
	{
		// Token: 0x060000F9 RID: 249 RVA: 0x00012908 File Offset: 0x00010B08
		public static string Base64Encode(this string plainText)
		{
			byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
			return Convert.ToBase64String(plainTextBytes);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0001292C File Offset: 0x00010B2C
		public static string Base64Decode(this string base64EncodedData)
		{
			byte[] base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
			return Encoding.UTF8.GetString(base64EncodedBytes);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x00012950 File Offset: 0x00010B50
		public static string b64d(this string base64EncodedData)
		{
			byte[] base64EncodedBytes = Convert.FromBase64String(base64EncodedData);
			return Encoding.UTF8.GetString(base64EncodedBytes);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x00012974 File Offset: 0x00010B74
		public static string CreateMD5(this string input)
		{
			string result;
			using (MD5 md5 = MD5.Create())
			{
				byte[] inputBytes = Encoding.ASCII.GetBytes(input);
				byte[] hashBytes = md5.ComputeHash(inputBytes);
				StringBuilder sb = new StringBuilder();
				for (int i = 0; i < hashBytes.Length; i++)
				{
					sb.Append(hashBytes[i].ToString("X2"));
				}
				result = sb.ToString().ToLower();
			}
			return result;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x00012A04 File Offset: 0x00010C04
		public static string Hash(this string str)
		{
			SHA1Managed sha = new SHA1Managed();
			byte[] hash = sha.ComputeHash(Encoding.UTF8.GetBytes(str));
			StringBuilder sb = new StringBuilder(hash.Length * 2);
			foreach (byte b in hash)
			{
				sb.Append(b.ToString("X2"));
			}
			return sb.ToString();
		}

		// Token: 0x060000FE RID: 254 RVA: 0x00012A74 File Offset: 0x00010C74
		public static string Byte2String(this byte[] str)
		{
			return Encoding.Default.GetString(str);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x00012A94 File Offset: 0x00010C94
		public static double NextDouble(this Random RandGenerator, double MinValue, double MaxValue)
		{
			return RandGenerator.NextDouble() * (MaxValue - MinValue) + MinValue;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00012AB4 File Offset: 0x00010CB4
		public static string DecompressString(this string compressedText)
		{
			byte[] array = Convert.FromBase64String(compressedText);
			string @string;
			using (MemoryStream memoryStream = new MemoryStream())
			{
				int num = BitConverter.ToInt32(array, 0);
				memoryStream.Write(array, 4, array.Length - 4);
				byte[] array2 = new byte[num];
				memoryStream.Position = 0L;
				using (GZipStream gzipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
				{
					gzipStream.Read(array2, 0, array2.Length);
				}
				@string = Encoding.UTF8.GetString(array2);
			}
			return @string;
		}
	}
}
