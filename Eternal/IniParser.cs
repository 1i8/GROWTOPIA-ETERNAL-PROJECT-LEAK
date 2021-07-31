using System;
using System.Collections;
using System.IO;

namespace Eternal
{
	// Token: 0x02000006 RID: 6
	public class IniParser
	{
		// Token: 0x06000025 RID: 37 RVA: 0x00005AD8 File Offset: 0x00003CD8
		public IniParser(string iniPath)
		{
			TextReader iniFile = null;
			string currentRoot = null;
			this.iniFilePath = iniPath;
			bool flag = File.Exists(iniPath);
			if (flag)
			{
				try
				{
					iniFile = new StreamReader(iniPath);
					for (string strLine = iniFile.ReadLine(); strLine != null; strLine = iniFile.ReadLine())
					{
						strLine = strLine.Trim();
						bool flag2 = strLine != "";
						if (flag2)
						{
							bool flag3 = strLine.StartsWith("[") && strLine.EndsWith("]");
							if (flag3)
							{
								currentRoot = strLine.Substring(1, strLine.Length - 2);
							}
							else
							{
								string[] keyPair = strLine.Split(new char[]
								{
									'='
								}, 2);
								string value = null;
								bool flag4 = currentRoot == null;
								if (flag4)
								{
									currentRoot = "ROOT";
								}
								IniParser.SectionPair sectionPair;
								sectionPair.Section = currentRoot;
								sectionPair.Key = keyPair[0];
								bool flag5 = keyPair.Length > 1;
								if (flag5)
								{
									value = keyPair[1];
								}
								this.keyPairs.Add(sectionPair, value);
							}
						}
					}
				}
				catch (Exception ex)
				{
					throw ex;
				}
				finally
				{
					bool flag6 = iniFile != null;
					if (flag6)
					{
						iniFile.Close();
					}
				}
				return;
			}
			throw new FileNotFoundException("Unable to locate " + iniPath);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00005C44 File Offset: 0x00003E44
		public string GetSetting(string sectionName, string settingName)
		{
			IniParser.SectionPair sectionPair;
			sectionPair.Section = sectionName;
			sectionPair.Key = settingName;
			return (string)this.keyPairs[sectionPair];
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00005C7C File Offset: 0x00003E7C
		public string[] EnumSection(string sectionName)
		{
			ArrayList tmpArray = new ArrayList();
			foreach (object obj in this.keyPairs.Keys)
			{
				IniParser.SectionPair pair = (IniParser.SectionPair)obj;
				bool flag = pair.Section == sectionName;
				if (flag)
				{
					tmpArray.Add(pair.Key);
				}
			}
			return (string[])tmpArray.ToArray(typeof(string));
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00005D1C File Offset: 0x00003F1C
		public void AddSetting(string sectionName, string settingName, string settingValue)
		{
			IniParser.SectionPair sectionPair;
			sectionPair.Section = sectionName;
			sectionPair.Key = settingName;
			bool flag = this.keyPairs.ContainsKey(sectionPair);
			if (flag)
			{
				this.keyPairs.Remove(sectionPair);
			}
			this.keyPairs.Add(sectionPair, settingValue);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00005D74 File Offset: 0x00003F74
		public void AddSetting(string sectionName, string settingName)
		{
			this.AddSetting(sectionName, settingName, null);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00005D84 File Offset: 0x00003F84
		public void DeleteSetting(string sectionName, string settingName)
		{
			IniParser.SectionPair sectionPair;
			sectionPair.Section = sectionName;
			sectionPair.Key = settingName;
			bool flag = this.keyPairs.ContainsKey(sectionPair);
			if (flag)
			{
				this.keyPairs.Remove(sectionPair);
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00005DCC File Offset: 0x00003FCC
		public void SaveSettings(string newFilePath)
		{
			ArrayList sections = new ArrayList();
			string strToSave = "";
			foreach (object obj in this.keyPairs.Keys)
			{
				IniParser.SectionPair sectionPair = (IniParser.SectionPair)obj;
				bool flag = !sections.Contains(sectionPair.Section);
				if (flag)
				{
					sections.Add(sectionPair.Section);
				}
			}
			foreach (object obj2 in sections)
			{
				string section = (string)obj2;
				strToSave = strToSave + "[" + section + "]\r\n";
				foreach (object obj3 in this.keyPairs.Keys)
				{
					IniParser.SectionPair sectionPair2 = (IniParser.SectionPair)obj3;
					bool flag2 = sectionPair2.Section == section;
					if (flag2)
					{
						string tmpValue = (string)this.keyPairs[sectionPair2];
						bool flag3 = tmpValue != null;
						if (flag3)
						{
							tmpValue = "=" + tmpValue;
						}
						strToSave = strToSave + sectionPair2.Key + tmpValue + "\r\n";
					}
				}
				strToSave += "\r\n";
			}
			try
			{
				TextWriter tw = new StreamWriter(newFilePath);
				tw.Write(strToSave);
				tw.Close();
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00005FAC File Offset: 0x000041AC
		public void SaveSettings()
		{
			this.SaveSettings(this.iniFilePath);
		}

		// Token: 0x0400003C RID: 60
		private Hashtable keyPairs = new Hashtable();

		// Token: 0x0400003D RID: 61
		private string iniFilePath;

		// Token: 0x02000024 RID: 36
		private struct SectionPair
		{
			// Token: 0x04000144 RID: 324
			public string Section;

			// Token: 0x04000145 RID: 325
			public string Key;
		}
	}
}
