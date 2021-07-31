using System;
using System.Drawing;
using System.Windows.Forms;

namespace Eternal.Extensions
{
	// Token: 0x02000014 RID: 20
	public static class Rainbow
	{
		// Token: 0x06000101 RID: 257 RVA: 0x00012B60 File Offset: 0x00010D60
		public static void change_color(params Control[] controls)
		{
			Rainbow.hsl.x += 0.005f;
			bool flag = Rainbow.hsl.x > 1f;
			if (flag)
			{
				Rainbow.hsl.x = 0f;
				Rainbow.hsl.y += (Rainbow.mode1 ? -0.099999994f : 0.099999994f);
			}
			bool flag2 = Rainbow.hsl.y > 1f || Rainbow.hsl.y < 0.4f;
			if (flag2)
			{
				bool flag3 = Rainbow.hsl.y > 1f;
				if (flag3)
				{
					Rainbow.mode1 = true;
					Rainbow.hsl.y -= 0.099999994f;
				}
				else
				{
					Rainbow.mode1 = false;
					Rainbow.hsl.y += 0.099999994f;
				}
				Rainbow.hsl.z += (Rainbow.mode2 ? -0.099999994f : 0.099999994f);
			}
			bool flag4 = Rainbow.hsl.z > 0.7f || Rainbow.hsl.z < 0.3f;
			if (flag4)
			{
				bool flag5 = Rainbow.hsl.z > 0.7f;
				if (flag5)
				{
					Rainbow.mode2 = true;
					Rainbow.hsl.z -= 0.099999994f;
				}
				else
				{
					Rainbow.mode2 = false;
					Rainbow.hsl.z += 0.099999994f;
				}
			}
			Color cl = Rainbow.hsl.to_rgb();
			foreach (Control c in controls)
			{
				bool flag6 = c is Panel;
				if (flag6)
				{
					c.BackColor = cl;
				}
				else
				{
					c.ForeColor = cl;
				}
			}
		}

		// Token: 0x040000F7 RID: 247
		private const float speed = 0.005f;

		// Token: 0x040000F8 RID: 248
		private const float speed_other = 0.099999994f;

		// Token: 0x040000F9 RID: 249
		private static bool mode1 = false;

		// Token: 0x040000FA RID: 250
		private static bool mode2 = false;

		// Token: 0x040000FB RID: 251
		private static Rainbow.Vector3 hsl = new Rainbow.Vector3(0f, 0.5f, 0.5f);

		// Token: 0x02000032 RID: 50
		public class Vector3
		{
			// Token: 0x06000157 RID: 343 RVA: 0x00015800 File Offset: 0x00013A00
			public Vector3(float x2, float y2, float z2)
			{
				this.x = x2;
				this.y = y2;
				this.z = z2;
			}

			// Token: 0x06000158 RID: 344 RVA: 0x00015820 File Offset: 0x00013A20
			public override string ToString()
			{
				return string.Format("{0}, {1}, {2}", Math.Round((double)this.x, 2), Math.Round((double)this.y, 2), Math.Round((double)this.z, 2));
			}

			// Token: 0x06000159 RID: 345 RVA: 0x00015870 File Offset: 0x00013A70
			public Color to_rgb()
			{
				double h = (double)this.x;
				double sl = (double)this.y;
				double i = (double)this.z;
				bool flag = h < 0.0;
				if (flag)
				{
					h = 1.0 - -h;
				}
				else
				{
					bool flag2 = h > 1.0;
					if (flag2)
					{
						h = -(-h + 1.0);
					}
				}
				double v = (i <= 0.5) ? (i * (1.0 + sl)) : (i + sl - i * sl);
				double r = i;
				double g = i;
				double b = i;
				bool flag3 = v > 0.0;
				if (flag3)
				{
					double j = i + i - v;
					double sv = (v - j) / v;
					h *= 6.0;
					int sextant = (int)h;
					double fract = h - (double)sextant;
					double vsf = v * sv * fract;
					double mid = j + vsf;
					double mid2 = v - vsf;
					switch (sextant)
					{
					case 0:
						r = v;
						g = mid;
						b = j;
						break;
					case 1:
						r = mid2;
						g = v;
						b = j;
						break;
					case 2:
						r = j;
						g = v;
						b = mid;
						break;
					case 3:
						r = j;
						g = mid2;
						b = v;
						break;
					case 4:
						r = mid;
						g = j;
						b = v;
						break;
					case 5:
						r = v;
						g = j;
						b = mid2;
						break;
					}
				}
				return Color.FromArgb((int)Convert.ToByte(r * 255.0), (int)Convert.ToByte(g * 255.0), (int)Convert.ToByte(b * 255.0));
			}

			// Token: 0x040001DB RID: 475
			public float x;

			// Token: 0x040001DC RID: 476
			public float y;

			// Token: 0x040001DD RID: 477
			public float z;
		}
	}
}
