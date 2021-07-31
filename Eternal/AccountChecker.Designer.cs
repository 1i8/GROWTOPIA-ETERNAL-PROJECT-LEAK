namespace Eternal
{
	// Token: 0x02000003 RID: 3
	public partial class AccountChecker : global::MaterialSkin.Controls.MaterialForm
	{
		// Token: 0x06000019 RID: 25 RVA: 0x000028EC File Offset: 0x00000AEC
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002924 File Offset: 0x00000B24
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Eternal.AccountChecker));
			this.materialTabControl1 = new global::MaterialSkin.Controls.MaterialTabControl();
			this.tabPage1 = new global::System.Windows.Forms.TabPage();
			this.groupBox3 = new global::System.Windows.Forms.GroupBox();
			this.checkinfo = new global::MaterialSkin.Controls.MaterialListView();
			this.id = new global::System.Windows.Forms.ColumnHeader();
			this.nme = new global::System.Windows.Forms.ColumnHeader();
			this.count = new global::System.Windows.Forms.ColumnHeader();
			this.price = new global::System.Windows.Forms.ColumnHeader();
			this.equip = new global::System.Windows.Forms.ColumnHeader();
			this.materialContextMenuStrip1 = new global::MaterialSkin.Controls.MaterialContextMenuStrip();
			this.processPricesToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.total = new global::MaterialSkin.Controls.MaterialLabel();
			this.wltext = new global::MaterialSkin.Controls.MaterialLabel();
			this.gem = new global::MaterialSkin.Controls.MaterialLabel();
			this.level = new global::MaterialSkin.Controls.MaterialLabel();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.materialButton2 = new global::MaterialSkin.Controls.MaterialButton();
			this.materialButton1 = new global::MaterialSkin.Controls.MaterialButton();
			this.stats = new global::MaterialSkin.Controls.MaterialLabel();
			this.growdi = new global::MaterialSkin.Controls.MaterialTextBox();
			this.pass = new global::MaterialSkin.Controls.MaterialTextBox();
			this.tabPage2 = new global::System.Windows.Forms.TabPage();
			this.WORLDS = new global::MaterialSkin.Controls.MaterialListView();
			this.columnHeader1 = new global::System.Windows.Forms.ColumnHeader();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.materialLabel6 = new global::MaterialSkin.Controls.MaterialLabel();
			this.materialButton3 = new global::MaterialSkin.Controls.MaterialButton();
			this.materialLabel7 = new global::MaterialSkin.Controls.MaterialLabel();
			this.Settings = new global::System.Windows.Forms.TabPage();
			this.groupBox7 = new global::System.Windows.Forms.GroupBox();
			this.groupBox6 = new global::System.Windows.Forms.GroupBox();
			this.materialLabel1 = new global::MaterialSkin.Controls.MaterialLabel();
			this.groupBox5 = new global::System.Windows.Forms.GroupBox();
			this.maclar = new global::MaterialSkin.Controls.MaterialComboBox();
			this.materialButton5 = new global::MaterialSkin.Controls.MaterialButton();
			this.groupBox4 = new global::System.Windows.Forms.GroupBox();
			this.materialButton4 = new global::MaterialSkin.Controls.MaterialButton();
			this.serverip = new global::MaterialSkin.Controls.MaterialTextBox();
			this.serverport = new global::MaterialSkin.Controls.MaterialTextBox();
			this.materialTabSelector1 = new global::MaterialSkin.Controls.MaterialTabSelector();
			this.materialTabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.materialContextMenuStrip1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.Settings.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox4.SuspendLayout();
			base.SuspendLayout();
			this.materialTabControl1.Alignment = global::System.Windows.Forms.TabAlignment.Bottom;
			this.materialTabControl1.Controls.Add(this.tabPage1);
			this.materialTabControl1.Controls.Add(this.tabPage2);
			this.materialTabControl1.Controls.Add(this.Settings);
			this.materialTabControl1.Depth = 0;
			this.materialTabControl1.ImeMode = global::System.Windows.Forms.ImeMode.Off;
			this.materialTabControl1.Location = new global::System.Drawing.Point(0, 98);
			this.materialTabControl1.MouseState = global::MaterialSkin.MouseState.HOVER;
			this.materialTabControl1.Multiline = true;
			this.materialTabControl1.Name = "materialTabControl1";
			this.materialTabControl1.SelectedIndex = 0;
			this.materialTabControl1.Size = new global::System.Drawing.Size(796, 379);
			this.materialTabControl1.TabIndex = 0;
			this.tabPage1.BackColor = global::System.Drawing.Color.FromArgb(50, 50, 50);
			this.tabPage1.Controls.Add(this.groupBox3);
			this.tabPage1.Controls.Add(this.groupBox2);
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Location = new global::System.Drawing.Point(4, 4);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new global::System.Drawing.Size(788, 353);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Main";
			this.groupBox3.Controls.Add(this.checkinfo);
			this.groupBox3.Location = new global::System.Drawing.Point(8, 164);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new global::System.Drawing.Size(772, 183);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Inventory";
			this.checkinfo.AutoSizeTable = false;
			this.checkinfo.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 255);
			this.checkinfo.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.checkinfo.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.id,
				this.nme,
				this.count,
				this.price,
				this.equip
			});
			this.checkinfo.ContextMenuStrip = this.materialContextMenuStrip1;
			this.checkinfo.Depth = 0;
			this.checkinfo.FullRowSelect = true;
			this.checkinfo.HideSelection = false;
			this.checkinfo.Location = new global::System.Drawing.Point(6, 19);
			this.checkinfo.MinimumSize = new global::System.Drawing.Size(11, 10);
			this.checkinfo.MouseLocation = new global::System.Drawing.Point(-1, -1);
			this.checkinfo.MouseState = global::MaterialSkin.MouseState.OUT;
			this.checkinfo.Name = "checkinfo";
			this.checkinfo.OwnerDraw = true;
			this.checkinfo.Size = new global::System.Drawing.Size(760, 158);
			this.checkinfo.TabIndex = 42;
			this.checkinfo.UseCompatibleStateImageBehavior = false;
			this.checkinfo.View = global::System.Windows.Forms.View.Details;
			this.id.Text = "ID";
			this.id.Width = 50;
			this.nme.Text = "Name";
			this.nme.Width = 370;
			this.count.Text = "Count";
			this.count.Width = 100;
			this.price.Text = "Price";
			this.price.Width = 120;
			this.equip.Text = "Equipped";
			this.equip.Width = 100;
			this.materialContextMenuStrip1.BackColor = global::System.Drawing.Color.FromArgb(242, 242, 242);
			this.materialContextMenuStrip1.Depth = 0;
			this.materialContextMenuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.processPricesToolStripMenuItem
			});
			this.materialContextMenuStrip1.MouseState = global::MaterialSkin.MouseState.HOVER;
			this.materialContextMenuStrip1.Name = "materialContextMenuStrip1";
			this.materialContextMenuStrip1.Size = new global::System.Drawing.Size(149, 26);
			this.processPricesToolStripMenuItem.Name = "processPricesToolStripMenuItem";
			this.processPricesToolStripMenuItem.Size = new global::System.Drawing.Size(148, 22);
			this.processPricesToolStripMenuItem.Text = "Process Prices";
			this.processPricesToolStripMenuItem.Click += new global::System.EventHandler(this.processPricesToolStripMenuItem_Click);
			this.groupBox2.Controls.Add(this.total);
			this.groupBox2.Controls.Add(this.wltext);
			this.groupBox2.Controls.Add(this.gem);
			this.groupBox2.Controls.Add(this.level);
			this.groupBox2.Location = new global::System.Drawing.Point(528, 6);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new global::System.Drawing.Size(252, 152);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Account Information";
			this.total.AutoSize = true;
			this.total.Depth = 0;
			this.total.Font = new global::System.Drawing.Font("Roboto", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Pixel);
			this.total.Location = new global::System.Drawing.Point(6, 114);
			this.total.MouseState = global::MaterialSkin.MouseState.HOVER;
			this.total.Name = "total";
			this.total.Size = new global::System.Drawing.Size(112, 19);
			this.total.TabIndex = 3;
			this.total.Text = "Hours Played: 0";
			this.wltext.AutoSize = true;
			this.wltext.Depth = 0;
			this.wltext.Font = new global::System.Drawing.Font("Roboto", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Pixel);
			this.wltext.Location = new global::System.Drawing.Point(7, 82);
			this.wltext.MouseState = global::MaterialSkin.MouseState.HOVER;
			this.wltext.Name = "wltext";
			this.wltext.Size = new global::System.Drawing.Size(105, 19);
			this.wltext.TabIndex = 2;
			this.wltext.Text = "World Locks: 0";
			this.gem.AutoSize = true;
			this.gem.Depth = 0;
			this.gem.Font = new global::System.Drawing.Font("Roboto", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Pixel);
			this.gem.Location = new global::System.Drawing.Point(7, 52);
			this.gem.MouseState = global::MaterialSkin.MouseState.HOVER;
			this.gem.Name = "gem";
			this.gem.Size = new global::System.Drawing.Size(59, 19);
			this.gem.TabIndex = 1;
			this.gem.Text = "Gems: 0";
			this.level.AutoSize = true;
			this.level.Depth = 0;
			this.level.Font = new global::System.Drawing.Font("Roboto", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Pixel);
			this.level.Location = new global::System.Drawing.Point(7, 21);
			this.level.MouseState = global::MaterialSkin.MouseState.HOVER;
			this.level.Name = "level";
			this.level.Size = new global::System.Drawing.Size(182, 19);
			this.level.TabIndex = 0;
			this.level.Text = "Level: 0 - Supporter: False";
			this.groupBox1.Controls.Add(this.materialButton2);
			this.groupBox1.Controls.Add(this.materialButton1);
			this.groupBox1.Controls.Add(this.stats);
			this.groupBox1.Controls.Add(this.growdi);
			this.groupBox1.Controls.Add(this.pass);
			this.groupBox1.Location = new global::System.Drawing.Point(8, 6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(514, 152);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Login Panel";
			this.groupBox1.Enter += new global::System.EventHandler(this.groupBox1_Enter);
			this.materialButton2.AutoSize = false;
			this.materialButton2.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.materialButton2.BackColor = global::System.Drawing.Color.FromArgb(50, 50, 50);
			this.materialButton2.Depth = 0;
			this.materialButton2.DrawShadows = true;
			this.materialButton2.ForeColor = global::System.Drawing.Color.FromArgb(222, 255, 255, 255);
			this.materialButton2.HighEmphasis = true;
			this.materialButton2.Icon = null;
			this.materialButton2.Location = new global::System.Drawing.Point(284, 104);
			this.materialButton2.Margin = new global::System.Windows.Forms.Padding(4, 6, 4, 6);
			this.materialButton2.MouseState = global::MaterialSkin.MouseState.HOVER;
			this.materialButton2.Name = "materialButton2";
			this.materialButton2.Size = new global::System.Drawing.Size(101, 36);
			this.materialButton2.TabIndex = 47;
			this.materialButton2.Text = "Settings";
			this.materialButton2.Type = global::MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.materialButton2.UseAccentColor = false;
			this.materialButton2.UseVisualStyleBackColor = false;
			this.materialButton2.Click += new global::System.EventHandler(this.materialButton2_Click_1);
			this.materialButton1.AutoSize = false;
			this.materialButton1.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.materialButton1.BackColor = global::System.Drawing.Color.FromArgb(50, 50, 50);
			this.materialButton1.Depth = 0;
			this.materialButton1.DrawShadows = true;
			this.materialButton1.ForeColor = global::System.Drawing.Color.FromArgb(222, 255, 255, 255);
			this.materialButton1.HighEmphasis = true;
			this.materialButton1.Icon = null;
			this.materialButton1.Location = new global::System.Drawing.Point(393, 104);
			this.materialButton1.Margin = new global::System.Windows.Forms.Padding(4, 6, 4, 6);
			this.materialButton1.MouseState = global::MaterialSkin.MouseState.HOVER;
			this.materialButton1.Name = "materialButton1";
			this.materialButton1.Size = new global::System.Drawing.Size(101, 36);
			this.materialButton1.TabIndex = 46;
			this.materialButton1.Text = "Check";
			this.materialButton1.Type = global::MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.materialButton1.UseAccentColor = false;
			this.materialButton1.UseVisualStyleBackColor = false;
			this.materialButton1.Click += new global::System.EventHandler(this.materialButton1_Click);
			this.stats.AutoSize = true;
			this.stats.Depth = 0;
			this.stats.Font = new global::System.Drawing.Font("Roboto", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Pixel);
			this.stats.Location = new global::System.Drawing.Point(20, 114);
			this.stats.MouseState = global::MaterialSkin.MouseState.HOVER;
			this.stats.Name = "stats";
			this.stats.Size = new global::System.Drawing.Size(80, 19);
			this.stats.TabIndex = 2;
			this.stats.Text = "Status: Idle";
			this.growdi.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.growdi.Depth = 0;
			this.growdi.Font = new global::System.Drawing.Font("Roboto", 12f);
			this.growdi.Hint = "GrowID";
			this.growdi.Location = new global::System.Drawing.Point(6, 19);
			this.growdi.MaxLength = 50;
			this.growdi.MouseState = global::MaterialSkin.MouseState.OUT;
			this.growdi.Multiline = false;
			this.growdi.Name = "growdi";
			this.growdi.Size = new global::System.Drawing.Size(488, 36);
			this.growdi.TabIndex = 1;
			this.growdi.Text = "";
			this.growdi.UseTallSize = false;
			this.pass.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.pass.Depth = 0;
			this.pass.Font = new global::System.Drawing.Font("Roboto", 12f);
			this.pass.Hint = "Password";
			this.pass.Location = new global::System.Drawing.Point(6, 61);
			this.pass.MaxLength = 50;
			this.pass.MouseState = global::MaterialSkin.MouseState.OUT;
			this.pass.Multiline = false;
			this.pass.Name = "pass";
			this.pass.Password = true;
			this.pass.Size = new global::System.Drawing.Size(488, 36);
			this.pass.TabIndex = 0;
			this.pass.Text = "";
			this.pass.UseTallSize = false;
			this.pass.TextChanged += new global::System.EventHandler(this.materialTextBox1_TextChanged);
			this.tabPage2.BackColor = global::System.Drawing.Color.FromArgb(50, 50, 50);
			this.tabPage2.Controls.Add(this.WORLDS);
			this.tabPage2.Controls.Add(this.pictureBox1);
			this.tabPage2.Controls.Add(this.materialLabel6);
			this.tabPage2.Controls.Add(this.materialButton3);
			this.tabPage2.Controls.Add(this.materialLabel7);
			this.tabPage2.Location = new global::System.Drawing.Point(4, 4);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new global::System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new global::System.Drawing.Size(788, 353);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Worlds";
			this.WORLDS.Alignment = global::System.Windows.Forms.ListViewAlignment.Left;
			this.WORLDS.AllowColumnReorder = true;
			this.WORLDS.AutoSizeTable = false;
			this.WORLDS.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 255);
			this.WORLDS.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.WORLDS.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
			{
				this.columnHeader1
			});
			this.WORLDS.Depth = 0;
			this.WORLDS.FullRowSelect = true;
			this.WORLDS.HideSelection = false;
			this.WORLDS.Location = new global::System.Drawing.Point(3, 51);
			this.WORLDS.MinimumSize = new global::System.Drawing.Size(11, 10);
			this.WORLDS.MouseLocation = new global::System.Drawing.Point(-1, -1);
			this.WORLDS.MouseState = global::MaterialSkin.MouseState.OUT;
			this.WORLDS.Name = "WORLDS";
			this.WORLDS.OwnerDraw = true;
			this.WORLDS.Size = new global::System.Drawing.Size(205, 296);
			this.WORLDS.TabIndex = 50;
			this.WORLDS.UseCompatibleStateImageBehavior = false;
			this.WORLDS.View = global::System.Windows.Forms.View.Details;
			this.columnHeader1.Text = "Worlds";
			this.columnHeader1.Width = 220;
			this.pictureBox1.Location = new global::System.Drawing.Point(214, 51);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(570, 296);
			this.pictureBox1.TabIndex = 49;
			this.pictureBox1.TabStop = false;
			this.materialLabel6.AutoSize = true;
			this.materialLabel6.Depth = 0;
			this.materialLabel6.Font = new global::System.Drawing.Font("Roboto", 16f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel6.FontType = global::MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
			this.materialLabel6.Location = new global::System.Drawing.Point(468, 14);
			this.materialLabel6.MouseState = global::MaterialSkin.MouseState.HOVER;
			this.materialLabel6.Name = "materialLabel6";
			this.materialLabel6.Size = new global::System.Drawing.Size(80, 19);
			this.materialLabel6.TabIndex = 48;
			this.materialLabel6.Text = "World View";
			this.materialButton3.AutoSize = false;
			this.materialButton3.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.materialButton3.BackColor = global::System.Drawing.Color.FromArgb(50, 50, 50);
			this.materialButton3.Depth = 0;
			this.materialButton3.DrawShadows = true;
			this.materialButton3.Enabled = false;
			this.materialButton3.ForeColor = global::System.Drawing.Color.FromArgb(222, 255, 255, 255);
			this.materialButton3.HighEmphasis = true;
			this.materialButton3.Icon = null;
			this.materialButton3.Location = new global::System.Drawing.Point(682, 6);
			this.materialButton3.Margin = new global::System.Windows.Forms.Padding(4, 6, 4, 6);
			this.materialButton3.MouseState = global::MaterialSkin.MouseState.HOVER;
			this.materialButton3.Name = "materialButton3";
			this.materialButton3.Size = new global::System.Drawing.Size(102, 36);
			this.materialButton3.TabIndex = 47;
			this.materialButton3.Text = "Render";
			this.materialButton3.Type = global::MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.materialButton3.UseAccentColor = false;
			this.materialButton3.UseVisualStyleBackColor = false;
			this.materialButton3.Click += new global::System.EventHandler(this.materialButton3_Click);
			this.materialLabel7.AutoSize = true;
			this.materialLabel7.Depth = 0;
			this.materialLabel7.Font = new global::System.Drawing.Font("Roboto", 16f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel7.FontType = global::MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
			this.materialLabel7.Location = new global::System.Drawing.Point(57, 12);
			this.materialLabel7.MouseState = global::MaterialSkin.MouseState.HOVER;
			this.materialLabel7.Name = "materialLabel7";
			this.materialLabel7.Size = new global::System.Drawing.Size(80, 19);
			this.materialLabel7.TabIndex = 2;
			this.materialLabel7.Text = "World List: ";
			this.Settings.BackColor = global::System.Drawing.Color.FromArgb(50, 50, 50);
			this.Settings.Controls.Add(this.groupBox7);
			this.Settings.Controls.Add(this.groupBox6);
			this.Settings.Controls.Add(this.groupBox5);
			this.Settings.Controls.Add(this.groupBox4);
			this.Settings.Location = new global::System.Drawing.Point(4, 4);
			this.Settings.Name = "Settings";
			this.Settings.Size = new global::System.Drawing.Size(788, 353);
			this.Settings.TabIndex = 2;
			this.Settings.Text = "Settings";
			this.groupBox7.Location = new global::System.Drawing.Point(8, 217);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new global::System.Drawing.Size(310, 131);
			this.groupBox7.TabIndex = 48;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "Configuration";
			this.groupBox6.Controls.Add(this.materialLabel1);
			this.groupBox6.Location = new global::System.Drawing.Point(324, 4);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new global::System.Drawing.Size(456, 344);
			this.groupBox6.TabIndex = 48;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "View Packets";
			this.materialLabel1.AutoSize = true;
			this.materialLabel1.Depth = 0;
			this.materialLabel1.Font = new global::System.Drawing.Font("Roboto", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Pixel);
			this.materialLabel1.Location = new global::System.Drawing.Point(210, 134);
			this.materialLabel1.MouseState = global::MaterialSkin.MouseState.HOVER;
			this.materialLabel1.Name = "materialLabel1";
			this.materialLabel1.Size = new global::System.Drawing.Size(150, 19);
			this.materialLabel1.TabIndex = 0;
			this.materialLabel1.Text = "not available for now";
			this.groupBox5.Controls.Add(this.maclar);
			this.groupBox5.Controls.Add(this.materialButton5);
			this.groupBox5.Location = new global::System.Drawing.Point(8, 122);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new global::System.Drawing.Size(310, 89);
			this.groupBox5.TabIndex = 2;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "AAP Bypass";
			this.maclar.AutoCompleteSource = global::System.Windows.Forms.AutoCompleteSource.ListItems;
			this.maclar.AutoResize = false;
			this.maclar.BackColor = global::System.Drawing.Color.FromArgb(255, 255, 255);
			this.maclar.Depth = 0;
			this.maclar.DrawMode = global::System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.maclar.DropDownHeight = 118;
			this.maclar.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.maclar.DropDownWidth = 121;
			this.maclar.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Pixel);
			this.maclar.ForeColor = global::System.Drawing.Color.FromArgb(222, 0, 0, 0);
			this.maclar.FormattingEnabled = true;
			this.maclar.Hint = "Mac Address";
			this.maclar.IntegralHeight = false;
			this.maclar.ItemHeight = 29;
			this.maclar.Location = new global::System.Drawing.Point(6, 31);
			this.maclar.MaxDropDownItems = 4;
			this.maclar.MouseState = global::MaterialSkin.MouseState.OUT;
			this.maclar.Name = "maclar";
			this.maclar.Size = new global::System.Drawing.Size(185, 35);
			this.maclar.Sorted = true;
			this.maclar.TabIndex = 1;
			this.maclar.UseTallSize = false;
			this.materialButton5.AutoSize = false;
			this.materialButton5.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.materialButton5.BackColor = global::System.Drawing.Color.FromArgb(50, 50, 50);
			this.materialButton5.Depth = 0;
			this.materialButton5.DrawShadows = true;
			this.materialButton5.ForeColor = global::System.Drawing.Color.FromArgb(222, 255, 255, 255);
			this.materialButton5.HighEmphasis = true;
			this.materialButton5.Icon = null;
			this.materialButton5.Location = new global::System.Drawing.Point(198, 31);
			this.materialButton5.Margin = new global::System.Windows.Forms.Padding(4, 6, 4, 6);
			this.materialButton5.MouseState = global::MaterialSkin.MouseState.HOVER;
			this.materialButton5.Name = "materialButton5";
			this.materialButton5.Size = new global::System.Drawing.Size(101, 36);
			this.materialButton5.TabIndex = 47;
			this.materialButton5.Text = "random";
			this.materialButton5.Type = global::MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.materialButton5.UseAccentColor = false;
			this.materialButton5.UseVisualStyleBackColor = false;
			this.materialButton5.Click += new global::System.EventHandler(this.materialButton5_Click);
			this.groupBox4.Controls.Add(this.materialButton4);
			this.groupBox4.Controls.Add(this.serverip);
			this.groupBox4.Controls.Add(this.serverport);
			this.groupBox4.Location = new global::System.Drawing.Point(8, 3);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new global::System.Drawing.Size(310, 113);
			this.groupBox4.TabIndex = 1;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Server";
			this.materialButton4.AutoSize = false;
			this.materialButton4.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.materialButton4.BackColor = global::System.Drawing.Color.FromArgb(50, 50, 50);
			this.materialButton4.Depth = 0;
			this.materialButton4.DrawShadows = true;
			this.materialButton4.ForeColor = global::System.Drawing.Color.FromArgb(222, 255, 255, 255);
			this.materialButton4.HighEmphasis = true;
			this.materialButton4.Icon = null;
			this.materialButton4.Location = new global::System.Drawing.Point(198, 61);
			this.materialButton4.Margin = new global::System.Windows.Forms.Padding(4, 6, 4, 6);
			this.materialButton4.MouseState = global::MaterialSkin.MouseState.HOVER;
			this.materialButton4.Name = "materialButton4";
			this.materialButton4.Size = new global::System.Drawing.Size(101, 36);
			this.materialButton4.TabIndex = 47;
			this.materialButton4.Text = "PULL DATA";
			this.materialButton4.Type = global::MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
			this.materialButton4.UseAccentColor = false;
			this.materialButton4.UseVisualStyleBackColor = false;
			this.materialButton4.Click += new global::System.EventHandler(this.materialButton4_Click);
			this.serverip.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.serverip.Depth = 0;
			this.serverip.Font = new global::System.Drawing.Font("Roboto", 12f);
			this.serverip.Hint = "Server Ip";
			this.serverip.Location = new global::System.Drawing.Point(6, 19);
			this.serverip.MaxLength = 50;
			this.serverip.MouseState = global::MaterialSkin.MouseState.OUT;
			this.serverip.Multiline = false;
			this.serverip.Name = "serverip";
			this.serverip.Size = new global::System.Drawing.Size(229, 36);
			this.serverip.TabIndex = 1;
			this.serverip.Text = "";
			this.serverip.UseTallSize = false;
			this.serverport.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			this.serverport.Depth = 0;
			this.serverport.Font = new global::System.Drawing.Font("Roboto", 12f);
			this.serverport.Hint = "Port";
			this.serverport.Location = new global::System.Drawing.Point(6, 61);
			this.serverport.MaxLength = 50;
			this.serverport.MouseState = global::MaterialSkin.MouseState.OUT;
			this.serverport.Multiline = false;
			this.serverport.Name = "serverport";
			this.serverport.Size = new global::System.Drawing.Size(185, 36);
			this.serverport.TabIndex = 0;
			this.serverport.Text = "";
			this.serverport.UseTallSize = false;
			this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
			this.materialTabSelector1.Depth = 0;
			this.materialTabSelector1.Font = new global::System.Drawing.Font("Roboto", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Pixel);
			this.materialTabSelector1.Location = new global::System.Drawing.Point(0, 64);
			this.materialTabSelector1.MouseState = global::MaterialSkin.MouseState.HOVER;
			this.materialTabSelector1.Name = "materialTabSelector1";
			this.materialTabSelector1.Size = new global::System.Drawing.Size(796, 32);
			this.materialTabSelector1.TabIndex = 1;
			this.materialTabSelector1.Text = "materialTabSelector1";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(796, 462);
			base.Controls.Add(this.materialTabSelector1);
			base.Controls.Add(this.materialTabControl1);
			base.Icon = (global::System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "AccountChecker";
			base.Sizable = false;
			this.Text = "Account Checker";
			base.Load += new global::System.EventHandler(this.AccountChecker_Load);
			this.materialTabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.materialContextMenuStrip1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.Settings.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000001 RID: 1
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000002 RID: 2
		private global::MaterialSkin.Controls.MaterialTabControl materialTabControl1;

		// Token: 0x04000003 RID: 3
		private global::System.Windows.Forms.TabPage tabPage1;

		// Token: 0x04000004 RID: 4
		private global::System.Windows.Forms.TabPage tabPage2;

		// Token: 0x04000005 RID: 5
		private global::MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x04000008 RID: 8
		private global::MaterialSkin.Controls.MaterialTextBox growdi;

		// Token: 0x04000009 RID: 9
		private global::MaterialSkin.Controls.MaterialTextBox pass;

		// Token: 0x0400000A RID: 10
		private global::MaterialSkin.Controls.MaterialLabel stats;

		// Token: 0x0400000B RID: 11
		private global::MaterialSkin.Controls.MaterialButton materialButton1;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.GroupBox groupBox3;

		// Token: 0x0400000D RID: 13
		private global::MaterialSkin.Controls.MaterialLabel total;

		// Token: 0x0400000E RID: 14
		private global::MaterialSkin.Controls.MaterialLabel wltext;

		// Token: 0x0400000F RID: 15
		private global::MaterialSkin.Controls.MaterialLabel gem;

		// Token: 0x04000010 RID: 16
		private global::MaterialSkin.Controls.MaterialLabel level;

		// Token: 0x04000011 RID: 17
		private global::MaterialSkin.Controls.MaterialListView checkinfo;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.ColumnHeader id;

		// Token: 0x04000013 RID: 19
		private global::System.Windows.Forms.ColumnHeader nme;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.ColumnHeader count;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.ColumnHeader price;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.ColumnHeader equip;

		// Token: 0x04000017 RID: 23
		private global::MaterialSkin.Controls.MaterialButton materialButton3;

		// Token: 0x04000018 RID: 24
		private global::MaterialSkin.Controls.MaterialLabel materialLabel7;

		// Token: 0x04000019 RID: 25
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400001A RID: 26
		private global::MaterialSkin.Controls.MaterialLabel materialLabel6;

		// Token: 0x0400001B RID: 27
		private global::MaterialSkin.Controls.MaterialListView WORLDS;

		// Token: 0x0400001C RID: 28
		private global::System.Windows.Forms.ColumnHeader columnHeader1;

		// Token: 0x0400001D RID: 29
		private global::System.Windows.Forms.TabPage Settings;

		// Token: 0x0400001E RID: 30
		private global::MaterialSkin.Controls.MaterialButton materialButton2;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.GroupBox groupBox7;

		// Token: 0x04000020 RID: 32
		private global::System.Windows.Forms.GroupBox groupBox6;

		// Token: 0x04000021 RID: 33
		private global::MaterialSkin.Controls.MaterialLabel materialLabel1;

		// Token: 0x04000022 RID: 34
		private global::System.Windows.Forms.GroupBox groupBox5;

		// Token: 0x04000023 RID: 35
		private global::MaterialSkin.Controls.MaterialButton materialButton5;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.GroupBox groupBox4;

		// Token: 0x04000025 RID: 37
		private global::MaterialSkin.Controls.MaterialButton materialButton4;

		// Token: 0x04000026 RID: 38
		private global::MaterialSkin.Controls.MaterialTextBox serverip;

		// Token: 0x04000027 RID: 39
		private global::MaterialSkin.Controls.MaterialTextBox serverport;

		// Token: 0x04000028 RID: 40
		private global::MaterialSkin.Controls.MaterialComboBox maclar;

		// Token: 0x04000029 RID: 41
		private global::MaterialSkin.Controls.MaterialContextMenuStrip materialContextMenuStrip1;

		// Token: 0x0400002A RID: 42
		private global::System.Windows.Forms.ToolStripMenuItem processPricesToolStripMenuItem;
	}
}
