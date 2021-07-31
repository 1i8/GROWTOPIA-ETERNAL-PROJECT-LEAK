using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Eternal.Properties;

namespace Eternal
{
	// Token: 0x02000007 RID: 7
	public class ItemDatabase
	{
		// Token: 0x0600002D RID: 45 RVA: 0x00005FBC File Offset: 0x000041BC
		public static bool isBackground(int itemID)
		{
			ItemDatabase.ItemDefinition def = ItemDatabase.GetItemDef(itemID);
			byte actType = def.actionType;
			return actType == 18 || actType == 23 || actType == 28;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00005FF0 File Offset: 0x000041F0
		public static ItemDatabase.ItemDefinition GetItemDef(int itemID)
		{
			bool flag = itemID < 0 || itemID > ItemDatabase.itemDefs.Count<ItemDatabase.ItemDefinition>();
			ItemDatabase.ItemDefinition result;
			if (flag)
			{
				result = ItemDatabase.itemDefs[0];
			}
			else
			{
				ItemDatabase.ItemDefinition def = ItemDatabase.itemDefs[itemID];
				bool flag2 = (int)def.id != itemID;
				if (flag2)
				{
					foreach (ItemDatabase.ItemDefinition d in ItemDatabase.itemDefs)
					{
						bool flag3 = (int)d.id == itemID;
						if (flag3)
						{
							return d;
						}
					}
				}
				result = def;
			}
			return result;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x000060A0 File Offset: 0x000042A0
		public static bool RequiresTileExtra(int id)
		{
			ItemDatabase.ItemDefinition def = ItemDatabase.GetItemDef(id);
			return def.actionType == 2 || def.actionType == 3 || def.actionType == 10 || def.actionType == 13 || def.actionType == 19 || def.actionType == 26 || def.actionType == 33 || def.actionType == 34 || def.actionType == 36 || def.actionType == 36 || def.actionType == 38 || def.actionType == 40 || def.actionType == 43 || def.actionType == 46 || def.actionType == 47 || def.actionType == 49 || def.actionType == 50 || def.actionType == 51 || def.actionType == 52 || def.actionType == 53 || def.actionType == 54 || def.actionType == 55 || def.actionType == 56 || def.id == 2246 || def.actionType == 57 || def.actionType == 59 || def.actionType == 61 || def.actionType == 62 || def.actionType == 63 || def.id == 3760 || def.actionType == 66 || def.actionType == 67 || def.actionType == 73 || def.actionType == 74 || def.actionType == 76 || def.actionType == 78 || def.actionType == 80 || def.actionType == 81 || def.actionType == 83 || def.actionType == 84 || def.actionType == 85 || def.actionType == 86 || def.actionType == 87 || def.actionType == 88 || def.actionType == 89 || def.actionType == 91 || def.actionType == 93 || def.actionType == 97 || def.actionType == 100 || def.actionType == 101 || def.actionType == 111 || def.actionType == 113 || def.actionType == 115 || def.actionType == 116 || def.actionType == 127 || def.actionType == 130 || (def.id % 2 == 0 && def.id >= 5818 && def.id <= 5932);
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000063AC File Offset: 0x000045AC
		public static void SetupItemDefs()
		{
			string a = "unused|11\nitemCount|9142";
			List<string> aaa = a.Split(new char[]
			{
				'|'
			}).ToList<string>();
			bool flag = aaa.Count < 3;
			if (!flag)
			{
				int itemCount = -1;
				int.TryParse(aaa[2], out itemCount);
				bool flag2 = itemCount == -1;
				if (!flag2)
				{
					short id = 0;
					ItemDatabase.itemDefs.Clear();
					ItemDatabase.ItemDefinition def = default(ItemDatabase.ItemDefinition);
					using (StringReader sr = new StringReader(Resources.item_defs))
					{
						string s = string.Empty;
						while ((s = sr.ReadLine()) != null)
						{
							bool flag3 = s.Length < 2;
							if (!flag3)
							{
								bool flag4 = s.Contains("//");
								if (!flag4)
								{
									List<string> infos = s.Split(new char[]
									{
										'\\'
									}).ToList<string>();
									bool flag5 = infos[0] != "add_item";
									if (!flag5)
									{
										def.id = short.Parse(infos[1]);
										def.actionType = byte.Parse(infos[4]);
										def.itemName = infos[6];
										bool flag6 = def.id != id;
										if (flag6)
										{
										}
										ItemDatabase.itemDefs.Add(def);
										id += 1;
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0400003E RID: 62
		public static List<ItemDatabase.ItemDefinition> itemDefs = new List<ItemDatabase.ItemDefinition>();

		// Token: 0x02000025 RID: 37
		public struct ItemDefinition
		{
			// Token: 0x04000146 RID: 326
			public short id;

			// Token: 0x04000147 RID: 327
			public byte editType;

			// Token: 0x04000148 RID: 328
			public byte editCategory;

			// Token: 0x04000149 RID: 329
			public byte actionType;

			// Token: 0x0400014A RID: 330
			public byte hitSound;

			// Token: 0x0400014B RID: 331
			public string itemName;

			// Token: 0x0400014C RID: 332
			public string fileName;

			// Token: 0x0400014D RID: 333
			public int texHash;

			// Token: 0x0400014E RID: 334
			public byte itemKind;

			// Token: 0x0400014F RID: 335
			public byte texX;

			// Token: 0x04000150 RID: 336
			public byte texY;

			// Token: 0x04000151 RID: 337
			public byte sprType;

			// Token: 0x04000152 RID: 338
			public byte isStripey;

			// Token: 0x04000153 RID: 339
			public byte collType;

			// Token: 0x04000154 RID: 340
			public byte hitsTaken;

			// Token: 0x04000155 RID: 341
			public byte dropChance;

			// Token: 0x04000156 RID: 342
			public int clothingType;

			// Token: 0x04000157 RID: 343
			public short rarity;

			// Token: 0x04000158 RID: 344
			public short toolKind;

			// Token: 0x04000159 RID: 345
			public string audioFile;

			// Token: 0x0400015A RID: 346
			public int audioHash;

			// Token: 0x0400015B RID: 347
			public short audioVol;

			// Token: 0x0400015C RID: 348
			public byte seedBase;

			// Token: 0x0400015D RID: 349
			public byte seedOver;

			// Token: 0x0400015E RID: 350
			public byte treeBase;

			// Token: 0x0400015F RID: 351
			public byte treeOver;

			// Token: 0x04000160 RID: 352
			public byte color1R;

			// Token: 0x04000161 RID: 353
			public byte color1G;

			// Token: 0x04000162 RID: 354
			public byte color1B;

			// Token: 0x04000163 RID: 355
			public byte color1A;

			// Token: 0x04000164 RID: 356
			public byte color2R;

			// Token: 0x04000165 RID: 357
			public byte color2G;

			// Token: 0x04000166 RID: 358
			public byte color2B;

			// Token: 0x04000167 RID: 359
			public byte color2A;

			// Token: 0x04000168 RID: 360
			public short ing1;

			// Token: 0x04000169 RID: 361
			public short ing2;

			// Token: 0x0400016A RID: 362
			public int growTime;

			// Token: 0x0400016B RID: 363
			public string extraUnk01;

			// Token: 0x0400016C RID: 364
			public string extraUnk02;

			// Token: 0x0400016D RID: 365
			public string extraUnk03;

			// Token: 0x0400016E RID: 366
			public string extraUnk04;

			// Token: 0x0400016F RID: 367
			public string extraUnk05;

			// Token: 0x04000170 RID: 368
			public string extraUnk11;

			// Token: 0x04000171 RID: 369
			public string extraUnk12;

			// Token: 0x04000172 RID: 370
			public string extraUnk13;

			// Token: 0x04000173 RID: 371
			public string extraUnk14;

			// Token: 0x04000174 RID: 372
			public string extraUnk15;

			// Token: 0x04000175 RID: 373
			public short extraUnkShort1;

			// Token: 0x04000176 RID: 374
			public short extraUnkShort2;

			// Token: 0x04000177 RID: 375
			public int extraUnkInt1;
		}
	}
}
