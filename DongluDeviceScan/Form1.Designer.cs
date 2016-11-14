namespace DongluDeviceScan
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.skinTabPage1 = new CCWin.SkinControl.SkinTabPage();
            this.skinProgressBar1 = new CCWin.SkinControl.SkinProgressBar();
            this.skinTreeView1 = new CCWin.SkinControl.SkinTreeView();
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.skinButton2 = new CCWin.SkinControl.SkinButton();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.skinTextBox2 = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinTextBox1 = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinTabControl1 = new CCWin.SkinControl.SkinTabControl();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinTextBox3 = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinTextBox4 = new CCWin.SkinControl.SkinTextBox();
            this.skinButton3 = new CCWin.SkinControl.SkinButton();
            this.skinTabPage1.SuspendLayout();
            this.skinPanel1.SuspendLayout();
            this.skinTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "search_16.png");
            this.imageList2.Images.SetKeyName(1, "system_software_update_16.png");
            this.imageList2.Images.SetKeyName(2, "open_16.png");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "search_32.png");
            this.imageList1.Images.SetKeyName(1, "version_32.png");
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // skinTabPage1
            // 
            this.skinTabPage1.BackColor = System.Drawing.Color.Silver;
            this.skinTabPage1.BorderColor = System.Drawing.Color.Silver;
            this.skinTabPage1.Controls.Add(this.skinButton3);
            this.skinTabPage1.Controls.Add(this.skinTextBox4);
            this.skinTabPage1.Controls.Add(this.skinLabel4);
            this.skinTabPage1.Controls.Add(this.skinButton2);
            this.skinTabPage1.Controls.Add(this.skinTextBox3);
            this.skinTabPage1.Controls.Add(this.skinLabel3);
            this.skinTabPage1.Controls.Add(this.skinProgressBar1);
            this.skinTabPage1.Controls.Add(this.skinTreeView1);
            this.skinTabPage1.Controls.Add(this.skinPanel1);
            this.skinTabPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabPage1.ImageIndex = 0;
            this.skinTabPage1.Location = new System.Drawing.Point(90, 0);
            this.skinTabPage1.Name = "skinTabPage1";
            this.skinTabPage1.Size = new System.Drawing.Size(714, 418);
            this.skinTabPage1.TabIndex = 0;
            this.skinTabPage1.TabItemImage = null;
            this.skinTabPage1.Text = "设备扫描";
            // 
            // skinProgressBar1
            // 
            this.skinProgressBar1.Back = null;
            this.skinProgressBar1.BackColor = System.Drawing.Color.Transparent;
            this.skinProgressBar1.BarBack = null;
            this.skinProgressBar1.BarRadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.skinProgressBar1.ForeColor = System.Drawing.Color.Black;
            this.skinProgressBar1.Location = new System.Drawing.Point(0, 395);
            this.skinProgressBar1.Name = "skinProgressBar1";
            this.skinProgressBar1.RadiusStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinProgressBar1.Size = new System.Drawing.Size(714, 23);
            this.skinProgressBar1.TabIndex = 2;
            // 
            // skinTreeView1
            // 
            this.skinTreeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skinTreeView1.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinTreeView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.skinTreeView1.Location = new System.Drawing.Point(0, 72);
            this.skinTreeView1.Margin = new System.Windows.Forms.Padding(0);
            this.skinTreeView1.Name = "skinTreeView1";
            this.skinTreeView1.Size = new System.Drawing.Size(714, 320);
            this.skinTreeView1.TabIndex = 1;
            this.skinTreeView1.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.afterCheck);
            this.skinTreeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.skinTreeView1_NodeMouseClick);
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.Transparent;
            this.skinPanel1.Controls.Add(this.skinButton1);
            this.skinPanel1.Controls.Add(this.skinTextBox2);
            this.skinPanel1.Controls.Add(this.skinLabel2);
            this.skinPanel1.Controls.Add(this.skinTextBox1);
            this.skinPanel1.Controls.Add(this.skinLabel1);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(0, 0);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(714, 38);
            this.skinPanel1.TabIndex = 0;
            // 
            // skinButton2
            // 
            this.skinButton2.BackColor = System.Drawing.Color.Transparent;
            this.skinButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton2.DownBack = null;
            this.skinButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.skinButton2.ImageIndex = 1;
            this.skinButton2.ImageList = this.imageList2;
            this.skinButton2.Location = new System.Drawing.Point(632, 44);
            this.skinButton2.MouseBack = null;
            this.skinButton2.Name = "skinButton2";
            this.skinButton2.NormlBack = null;
            this.skinButton2.Size = new System.Drawing.Size(62, 26);
            this.skinButton2.TabIndex = 5;
            this.skinButton2.Text = "升级";
            this.skinButton2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.skinButton2.UseVisualStyleBackColor = false;
            this.skinButton2.Click += new System.EventHandler(this.skinButton2_Click);
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.skinButton1.ImageIndex = 0;
            this.skinButton1.ImageList = this.imageList2;
            this.skinButton1.Location = new System.Drawing.Point(563, 6);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(131, 26);
            this.skinButton1.TabIndex = 4;
            this.skinButton1.Text = "扫描";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // skinTextBox2
            // 
            this.skinTextBox2.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox2.DownBack = null;
            this.skinTextBox2.Icon = null;
            this.skinTextBox2.IconIsButton = false;
            this.skinTextBox2.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox2.IsPasswordChat = '\0';
            this.skinTextBox2.IsSystemPasswordChar = false;
            this.skinTextBox2.Lines = new string[0];
            this.skinTextBox2.Location = new System.Drawing.Point(348, 4);
            this.skinTextBox2.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox2.MaxLength = 32767;
            this.skinTextBox2.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox2.MouseBack = null;
            this.skinTextBox2.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox2.Multiline = false;
            this.skinTextBox2.Name = "skinTextBox2";
            this.skinTextBox2.NormlBack = null;
            this.skinTextBox2.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox2.ReadOnly = false;
            this.skinTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox2.Size = new System.Drawing.Size(212, 28);
            // 
            // 
            // 
            this.skinTextBox2.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox2.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox2.SkinTxt.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.skinTextBox2.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox2.SkinTxt.Name = "BaseText";
            this.skinTextBox2.SkinTxt.Size = new System.Drawing.Size(118, 18);
            this.skinTextBox2.SkinTxt.TabIndex = 0;
            this.skinTextBox2.SkinTxt.Text = "192.168.1.255";
            this.skinTextBox2.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox2.SkinTxt.WaterText = "";
            this.skinTextBox2.TabIndex = 3;
            this.skinTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox2.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox2.WaterText = "";
            this.skinTextBox2.WordWrap = true;
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(292, 11);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(53, 14);
            this.skinLabel2.TabIndex = 2;
            this.skinLabel2.Text = "截止IP";
            // 
            // skinTextBox1
            // 
            this.skinTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox1.DownBack = null;
            this.skinTextBox1.Icon = null;
            this.skinTextBox1.IconIsButton = false;
            this.skinTextBox1.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox1.IsPasswordChat = '\0';
            this.skinTextBox1.IsSystemPasswordChar = false;
            this.skinTextBox1.Lines = new string[0];
            this.skinTextBox1.Location = new System.Drawing.Point(59, 4);
            this.skinTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox1.MaxLength = 32767;
            this.skinTextBox1.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox1.MouseBack = null;
            this.skinTextBox1.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox1.Multiline = false;
            this.skinTextBox1.Name = "skinTextBox1";
            this.skinTextBox1.NormlBack = null;
            this.skinTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox1.ReadOnly = false;
            this.skinTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox1.Size = new System.Drawing.Size(213, 28);
            // 
            // 
            // 
            this.skinTextBox1.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox1.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox1.SkinTxt.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.skinTextBox1.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox1.SkinTxt.Name = "BaseText";
            this.skinTextBox1.SkinTxt.Size = new System.Drawing.Size(137, 18);
            this.skinTextBox1.SkinTxt.TabIndex = 0;
            this.skinTextBox1.SkinTxt.Text = "192.168.1.1";
            this.skinTextBox1.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox1.SkinTxt.WaterText = "";
            this.skinTextBox1.TabIndex = 1;
            this.skinTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox1.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox1.WaterText = "";
            this.skinTextBox1.WordWrap = true;
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(4, 11);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(53, 14);
            this.skinLabel1.TabIndex = 0;
            this.skinLabel1.Text = "起始IP";
            // 
            // skinTabControl1
            // 
            this.skinTabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.skinTabControl1.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.skinTabControl1.BackColor = System.Drawing.Color.Silver;
            this.skinTabControl1.CloseRect = new System.Drawing.Rectangle(0, 0, 12, 12);
            this.skinTabControl1.Controls.Add(this.skinTabPage1);
            this.skinTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.skinTabControl1.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinTabControl1.HeadBack = null;
            this.skinTabControl1.HeadBackRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.skinTabControl1.ImageList = this.imageList1;
            this.skinTabControl1.ImgSize = new System.Drawing.Size(32, 32);
            this.skinTabControl1.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.skinTabControl1.ItemSize = new System.Drawing.Size(90, 90);
            this.skinTabControl1.Location = new System.Drawing.Point(4, 39);
            this.skinTabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.skinTabControl1.Multiline = true;
            this.skinTabControl1.Name = "skinTabControl1";
            this.skinTabControl1.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageArrowDown")));
            this.skinTabControl1.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageArrowHover")));
            this.skinTabControl1.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageCloseHover")));
            this.skinTabControl1.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageCloseNormal")));
            this.skinTabControl1.PageDown = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageDown")));
            this.skinTabControl1.PageHover = ((System.Drawing.Image)(resources.GetObject("skinTabControl1.PageHover")));
            this.skinTabControl1.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Top;
            this.skinTabControl1.PageNorml = null;
            this.skinTabControl1.SelectedIndex = 0;
            this.skinTabControl1.Size = new System.Drawing.Size(804, 418);
            this.skinTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.skinTabControl1.TabIndex = 0;
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(3, 50);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(53, 14);
            this.skinLabel3.TabIndex = 6;
            this.skinLabel3.Text = "设备IP";
            // 
            // skinTextBox3
            // 
            this.skinTextBox3.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox3.DownBack = null;
            this.skinTextBox3.Icon = null;
            this.skinTextBox3.IconIsButton = false;
            this.skinTextBox3.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox3.IsPasswordChat = '\0';
            this.skinTextBox3.IsSystemPasswordChar = false;
            this.skinTextBox3.Lines = new string[0];
            this.skinTextBox3.Location = new System.Drawing.Point(60, 43);
            this.skinTextBox3.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox3.MaxLength = 32767;
            this.skinTextBox3.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox3.MouseBack = null;
            this.skinTextBox3.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox3.Multiline = false;
            this.skinTextBox3.Name = "skinTextBox3";
            this.skinTextBox3.NormlBack = null;
            this.skinTextBox3.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox3.ReadOnly = false;
            this.skinTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox3.Size = new System.Drawing.Size(212, 28);
            // 
            // 
            // 
            this.skinTextBox3.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox3.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox3.SkinTxt.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.skinTextBox3.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox3.SkinTxt.Name = "BaseText";
            this.skinTextBox3.SkinTxt.Size = new System.Drawing.Size(136, 18);
            this.skinTextBox3.SkinTxt.TabIndex = 0;
            this.skinTextBox3.SkinTxt.Text = "192.168.1.1";
            this.skinTextBox3.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox3.SkinTxt.WaterText = "";
            this.skinTextBox3.TabIndex = 2;
            this.skinTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox3.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox3.WaterText = "";
            this.skinTextBox3.WordWrap = true;
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(277, 50);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(67, 14);
            this.skinLabel4.TabIndex = 7;
            this.skinLabel4.Text = "升级文件";
            // 
            // skinTextBox4
            // 
            this.skinTextBox4.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox4.DownBack = null;
            this.skinTextBox4.Icon = null;
            this.skinTextBox4.IconIsButton = false;
            this.skinTextBox4.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox4.IsPasswordChat = '\0';
            this.skinTextBox4.IsSystemPasswordChar = false;
            this.skinTextBox4.Lines = new string[0];
            this.skinTextBox4.Location = new System.Drawing.Point(347, 43);
            this.skinTextBox4.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox4.MaxLength = 32767;
            this.skinTextBox4.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox4.MouseBack = null;
            this.skinTextBox4.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox4.Multiline = false;
            this.skinTextBox4.Name = "skinTextBox4";
            this.skinTextBox4.NormlBack = null;
            this.skinTextBox4.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox4.ReadOnly = false;
            this.skinTextBox4.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox4.Size = new System.Drawing.Size(214, 28);
            // 
            // 
            // 
            this.skinTextBox4.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox4.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox4.SkinTxt.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.skinTextBox4.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox4.SkinTxt.Name = "BaseText";
            this.skinTextBox4.SkinTxt.Size = new System.Drawing.Size(119, 18);
            this.skinTextBox4.SkinTxt.TabIndex = 0;
            this.skinTextBox4.SkinTxt.Text = "192.168.1.1";
            this.skinTextBox4.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox4.SkinTxt.WaterText = "";
            this.skinTextBox4.TabIndex = 3;
            this.skinTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox4.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox4.WaterText = "";
            this.skinTextBox4.WordWrap = true;
            // 
            // skinButton3
            // 
            this.skinButton3.BackColor = System.Drawing.Color.Transparent;
            this.skinButton3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton3.DownBack = null;
            this.skinButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.skinButton3.ImageIndex = 2;
            this.skinButton3.ImageList = this.imageList2;
            this.skinButton3.Location = new System.Drawing.Point(564, 44);
            this.skinButton3.MouseBack = null;
            this.skinButton3.Name = "skinButton3";
            this.skinButton3.NormlBack = null;
            this.skinButton3.Size = new System.Drawing.Size(62, 26);
            this.skinButton3.TabIndex = 8;
            this.skinButton3.Text = "选择";
            this.skinButton3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.skinButton3.UseVisualStyleBackColor = false;
            this.skinButton3.Click += new System.EventHandler(this.skinButton3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BorderRectangle = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.ClientSize = new System.Drawing.Size(812, 461);
            this.Controls.Add(this.skinTabControl1);
            this.EffectWidth = 0;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0);
            this.Text = "局域网设备升级";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.skinTabPage1.ResumeLayout(false);
            this.skinTabPage1.PerformLayout();
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.skinTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private CCWin.SkinControl.SkinTabPage skinTabPage1;
        private CCWin.SkinControl.SkinProgressBar skinProgressBar1;
        private CCWin.SkinControl.SkinTreeView skinTreeView1;
        private CCWin.SkinControl.SkinPanel skinPanel1;
        private CCWin.SkinControl.SkinButton skinButton2;
        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinTextBox skinTextBox2;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinTextBox skinTextBox1;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinTabControl skinTabControl1;
        private CCWin.SkinControl.SkinTextBox skinTextBox3;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinButton skinButton3;
        private CCWin.SkinControl.SkinTextBox skinTextBox4;
        private CCWin.SkinControl.SkinLabel skinLabel4;
    }
}