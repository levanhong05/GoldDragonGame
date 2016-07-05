namespace TroChoiRongVang
{
    partial class frmMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainForm));
            this.lblDiem = new System.Windows.Forms.Label();
            this.tmrDanhSachCauHoi = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblDapAnDung = new System.Windows.Forms.Label();
            this.picDapAnD = new System.Windows.Forms.PictureBox();
            this.picDapAnC = new System.Windows.Forms.PictureBox();
            this.picDapAnB = new System.Windows.Forms.PictureBox();
            this.picDapAnA = new System.Windows.Forms.PictureBox();
            this.picExit = new System.Windows.Forms.PictureBox();
            this.btnNhoNguoiThan = new System.Windows.Forms.Button();
            this.btnDoiCauHoi = new System.Windows.Forms.Button();
            this.btnTraLoi2Lan = new System.Windows.Forms.Button();
            this.picCauHoi = new System.Windows.Forms.PictureBox();
            this.tmrDapAnDung = new System.Windows.Forms.Timer(this.components);
            this.pnlDanhSachDiem = new System.Windows.Forms.Panel();
            this.lblCauHoi = new System.Windows.Forms.Label();
            this.lblLuaChonA = new System.Windows.Forms.Label();
            this.lblLuaChonB = new System.Windows.Forms.Label();
            this.lblLuaChonC = new System.Windows.Forms.Label();
            this.lblLuaChonD = new System.Windows.Forms.Label();
            this.lblDapAnA = new System.Windows.Forms.Label();
            this.lblDapAnB = new System.Windows.Forms.Label();
            this.lblDapAnC = new System.Windows.Forms.Label();
            this.lblDapAnD = new System.Windows.Forms.Label();
            this.tmrWait = new System.Windows.Forms.Timer(this.components);
            this.tmrWait2 = new System.Windows.Forms.Timer(this.components);
            this.wmpPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.wmpSound = new AxWMPLib.AxWindowsMediaPlayer();
            this.tmrMusic = new System.Windows.Forms.Timer(this.components);
            this.tmrSuyNghi = new System.Windows.Forms.Timer(this.components);
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDungChoi = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDapAnD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDapAnC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDapAnB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDapAnA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCauHoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpSound)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDiem
            // 
            this.lblDiem.BackColor = System.Drawing.Color.Transparent;
            this.lblDiem.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblDiem.Location = new System.Drawing.Point(190, 175);
            this.lblDiem.Name = "lblDiem";
            this.lblDiem.Size = new System.Drawing.Size(104, 31);
            this.lblDiem.TabIndex = 1;
            this.lblDiem.Text = "0";
            this.lblDiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrDanhSachCauHoi
            // 
            this.tmrDanhSachCauHoi.Enabled = true;
            this.tmrDanhSachCauHoi.Interval = 10;
            this.tmrDanhSachCauHoi.Tick += new System.EventHandler(this.tmrDanhSachCauHoi_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 60;
            // 
            // lblDapAnDung
            // 
            this.lblDapAnDung.AutoSize = true;
            this.lblDapAnDung.Location = new System.Drawing.Point(306, 243);
            this.lblDapAnDung.Name = "lblDapAnDung";
            this.lblDapAnDung.Size = new System.Drawing.Size(0, 13);
            this.lblDapAnDung.TabIndex = 8;
            // 
            // picDapAnD
            // 
            this.picDapAnD.BackColor = System.Drawing.Color.Transparent;
            this.picDapAnD.Image = ((System.Drawing.Image)(resources.GetObject("picDapAnD.Image")));
            this.picDapAnD.Location = new System.Drawing.Point(390, 481);
            this.picDapAnD.Name = "picDapAnD";
            this.picDapAnD.Size = new System.Drawing.Size(389, 41);
            this.picDapAnD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDapAnD.TabIndex = 13;
            this.picDapAnD.TabStop = false;
            this.picDapAnD.Click += new System.EventHandler(this.DapAnD);
            // 
            // picDapAnC
            // 
            this.picDapAnC.BackColor = System.Drawing.Color.Transparent;
            this.picDapAnC.Image = ((System.Drawing.Image)(resources.GetObject("picDapAnC.Image")));
            this.picDapAnC.Location = new System.Drawing.Point(5, 481);
            this.picDapAnC.Name = "picDapAnC";
            this.picDapAnC.Size = new System.Drawing.Size(388, 41);
            this.picDapAnC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDapAnC.TabIndex = 12;
            this.picDapAnC.TabStop = false;
            this.picDapAnC.Click += new System.EventHandler(this.DapAnC);
            // 
            // picDapAnB
            // 
            this.picDapAnB.BackColor = System.Drawing.Color.Transparent;
            this.picDapAnB.Image = ((System.Drawing.Image)(resources.GetObject("picDapAnB.Image")));
            this.picDapAnB.Location = new System.Drawing.Point(390, 431);
            this.picDapAnB.Name = "picDapAnB";
            this.picDapAnB.Size = new System.Drawing.Size(389, 41);
            this.picDapAnB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDapAnB.TabIndex = 11;
            this.picDapAnB.TabStop = false;
            this.picDapAnB.Click += new System.EventHandler(this.DapAnB);
            // 
            // picDapAnA
            // 
            this.picDapAnA.BackColor = System.Drawing.Color.Transparent;
            this.picDapAnA.Image = ((System.Drawing.Image)(resources.GetObject("picDapAnA.Image")));
            this.picDapAnA.Location = new System.Drawing.Point(5, 431);
            this.picDapAnA.Name = "picDapAnA";
            this.picDapAnA.Size = new System.Drawing.Size(388, 41);
            this.picDapAnA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDapAnA.TabIndex = 10;
            this.picDapAnA.TabStop = false;
            this.picDapAnA.Click += new System.EventHandler(this.DapAnA);
            // 
            // picExit
            // 
            this.picExit.BackColor = System.Drawing.Color.Transparent;
            this.picExit.Image = global::TroChoiRongVang.Properties.Resources.exit;
            this.picExit.Location = new System.Drawing.Point(10, 8);
            this.picExit.Name = "picExit";
            this.picExit.Size = new System.Drawing.Size(62, 52);
            this.picExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picExit.TabIndex = 3;
            this.picExit.TabStop = false;
            this.picExit.Click += new System.EventHandler(this.picExit_Click);
            // 
            // btnNhoNguoiThan
            // 
            this.btnNhoNguoiThan.BackColor = System.Drawing.Color.Transparent;
            this.btnNhoNguoiThan.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNhoNguoiThan.BackgroundImage")));
            this.btnNhoNguoiThan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNhoNguoiThan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhoNguoiThan.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnNhoNguoiThan.Location = new System.Drawing.Point(370, 12);
            this.btnNhoNguoiThan.Name = "btnNhoNguoiThan";
            this.btnNhoNguoiThan.Size = new System.Drawing.Size(77, 49);
            this.btnNhoNguoiThan.TabIndex = 0;
            this.btnNhoNguoiThan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhoNguoiThan.UseVisualStyleBackColor = false;
            this.btnNhoNguoiThan.Click += new System.EventHandler(this.btnNhoNguoiThan_Click);
            // 
            // btnDoiCauHoi
            // 
            this.btnDoiCauHoi.BackColor = System.Drawing.Color.Transparent;
            this.btnDoiCauHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoiCauHoi.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnDoiCauHoi.Image = global::TroChoiRongVang.Properties.Resources.reload;
            this.btnDoiCauHoi.Location = new System.Drawing.Point(457, 12);
            this.btnDoiCauHoi.Name = "btnDoiCauHoi";
            this.btnDoiCauHoi.Size = new System.Drawing.Size(77, 49);
            this.btnDoiCauHoi.TabIndex = 0;
            this.btnDoiCauHoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDoiCauHoi.UseVisualStyleBackColor = false;
            this.btnDoiCauHoi.Click += new System.EventHandler(this.btnDoiCauHoi_Click);
            // 
            // btnTraLoi2Lan
            // 
            this.btnTraLoi2Lan.BackColor = System.Drawing.Color.Transparent;
            this.btnTraLoi2Lan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTraLoi2Lan.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnTraLoi2Lan.Image = global::TroChoiRongVang.Properties.Resources.Star;
            this.btnTraLoi2Lan.Location = new System.Drawing.Point(283, 12);
            this.btnTraLoi2Lan.Name = "btnTraLoi2Lan";
            this.btnTraLoi2Lan.Size = new System.Drawing.Size(77, 49);
            this.btnTraLoi2Lan.TabIndex = 0;
            this.btnTraLoi2Lan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTraLoi2Lan.UseVisualStyleBackColor = false;
            this.btnTraLoi2Lan.Click += new System.EventHandler(this.btnTraLoi2Lan_Click);
            // 
            // picCauHoi
            // 
            this.picCauHoi.BackColor = System.Drawing.Color.Transparent;
            this.picCauHoi.Image = global::TroChoiRongVang.Properties.Resources.CauHoi;
            this.picCauHoi.Location = new System.Drawing.Point(5, 354);
            this.picCauHoi.Name = "picCauHoi";
            this.picCauHoi.Size = new System.Drawing.Size(774, 67);
            this.picCauHoi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCauHoi.TabIndex = 14;
            this.picCauHoi.TabStop = false;
            // 
            // tmrDapAnDung
            // 
            this.tmrDapAnDung.Interval = 200;
            this.tmrDapAnDung.Tick += new System.EventHandler(this.tmrDapAnDung_Tick);
            // 
            // pnlDanhSachDiem
            // 
            this.pnlDanhSachDiem.BackColor = System.Drawing.Color.Transparent;
            this.pnlDanhSachDiem.Location = new System.Drawing.Point(623, 12);
            this.pnlDanhSachDiem.Name = "pnlDanhSachDiem";
            this.pnlDanhSachDiem.Size = new System.Drawing.Size(149, 323);
            this.pnlDanhSachDiem.TabIndex = 16;
            // 
            // lblCauHoi
            // 
            this.lblCauHoi.BackColor = System.Drawing.Color.Black;
            this.lblCauHoi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCauHoi.ForeColor = System.Drawing.Color.Tomato;
            this.lblCauHoi.Location = new System.Drawing.Point(71, 359);
            this.lblCauHoi.Name = "lblCauHoi";
            this.lblCauHoi.Size = new System.Drawing.Size(627, 56);
            this.lblCauHoi.TabIndex = 17;
            this.lblCauHoi.Text = "Cau hoi";
            this.lblCauHoi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLuaChonA
            // 
            this.lblLuaChonA.AutoSize = true;
            this.lblLuaChonA.BackColor = System.Drawing.Color.Black;
            this.lblLuaChonA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuaChonA.ForeColor = System.Drawing.Color.Yellow;
            this.lblLuaChonA.Location = new System.Drawing.Point(58, 441);
            this.lblLuaChonA.Name = "lblLuaChonA";
            this.lblLuaChonA.Size = new System.Drawing.Size(26, 19);
            this.lblLuaChonA.TabIndex = 18;
            this.lblLuaChonA.Text = "A:";
            this.lblLuaChonA.Click += new System.EventHandler(this.DapAnA);
            // 
            // lblLuaChonB
            // 
            this.lblLuaChonB.AutoSize = true;
            this.lblLuaChonB.BackColor = System.Drawing.Color.Black;
            this.lblLuaChonB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuaChonB.ForeColor = System.Drawing.Color.Yellow;
            this.lblLuaChonB.Location = new System.Drawing.Point(408, 441);
            this.lblLuaChonB.Name = "lblLuaChonB";
            this.lblLuaChonB.Size = new System.Drawing.Size(27, 19);
            this.lblLuaChonB.TabIndex = 18;
            this.lblLuaChonB.Text = "B:";
            this.lblLuaChonB.Click += new System.EventHandler(this.DapAnB);
            // 
            // lblLuaChonC
            // 
            this.lblLuaChonC.AutoSize = true;
            this.lblLuaChonC.BackColor = System.Drawing.Color.Black;
            this.lblLuaChonC.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuaChonC.ForeColor = System.Drawing.Color.Yellow;
            this.lblLuaChonC.Location = new System.Drawing.Point(57, 491);
            this.lblLuaChonC.Name = "lblLuaChonC";
            this.lblLuaChonC.Size = new System.Drawing.Size(27, 19);
            this.lblLuaChonC.TabIndex = 18;
            this.lblLuaChonC.Text = "C:";
            this.lblLuaChonC.Click += new System.EventHandler(this.DapAnC);
            // 
            // lblLuaChonD
            // 
            this.lblLuaChonD.AutoSize = true;
            this.lblLuaChonD.BackColor = System.Drawing.Color.Black;
            this.lblLuaChonD.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuaChonD.ForeColor = System.Drawing.Color.Yellow;
            this.lblLuaChonD.Location = new System.Drawing.Point(409, 490);
            this.lblLuaChonD.Name = "lblLuaChonD";
            this.lblLuaChonD.Size = new System.Drawing.Size(27, 19);
            this.lblLuaChonD.TabIndex = 18;
            this.lblLuaChonD.Text = "D:";
            this.lblLuaChonD.Click += new System.EventHandler(this.DapAnD);
            // 
            // lblDapAnA
            // 
            this.lblDapAnA.BackColor = System.Drawing.Color.Black;
            this.lblDapAnA.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDapAnA.ForeColor = System.Drawing.Color.Yellow;
            this.lblDapAnA.Location = new System.Drawing.Point(81, 439);
            this.lblDapAnA.Name = "lblDapAnA";
            this.lblDapAnA.Size = new System.Drawing.Size(283, 24);
            this.lblDapAnA.TabIndex = 18;
            this.lblDapAnA.Text = "Dap an A";
            this.lblDapAnA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDapAnA.Click += new System.EventHandler(this.DapAnA);
            // 
            // lblDapAnB
            // 
            this.lblDapAnB.BackColor = System.Drawing.Color.Black;
            this.lblDapAnB.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDapAnB.ForeColor = System.Drawing.Color.Yellow;
            this.lblDapAnB.Location = new System.Drawing.Point(433, 438);
            this.lblDapAnB.Name = "lblDapAnB";
            this.lblDapAnB.Size = new System.Drawing.Size(283, 24);
            this.lblDapAnB.TabIndex = 18;
            this.lblDapAnB.Text = "Dap an B";
            this.lblDapAnB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDapAnB.Click += new System.EventHandler(this.DapAnB);
            // 
            // lblDapAnC
            // 
            this.lblDapAnC.BackColor = System.Drawing.Color.Black;
            this.lblDapAnC.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDapAnC.ForeColor = System.Drawing.Color.Yellow;
            this.lblDapAnC.Location = new System.Drawing.Point(80, 487);
            this.lblDapAnC.Name = "lblDapAnC";
            this.lblDapAnC.Size = new System.Drawing.Size(283, 24);
            this.lblDapAnC.TabIndex = 18;
            this.lblDapAnC.Text = "Dap an C";
            this.lblDapAnC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDapAnC.Click += new System.EventHandler(this.DapAnC);
            // 
            // lblDapAnD
            // 
            this.lblDapAnD.BackColor = System.Drawing.Color.Black;
            this.lblDapAnD.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDapAnD.ForeColor = System.Drawing.Color.Yellow;
            this.lblDapAnD.Location = new System.Drawing.Point(434, 487);
            this.lblDapAnD.Name = "lblDapAnD";
            this.lblDapAnD.Size = new System.Drawing.Size(283, 24);
            this.lblDapAnD.TabIndex = 18;
            this.lblDapAnD.Text = "Dap an D";
            this.lblDapAnD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDapAnD.Click += new System.EventHandler(this.DapAnD);
            // 
            // tmrWait
            // 
            this.tmrWait.Interval = 2500;
            this.tmrWait.Tick += new System.EventHandler(this.tmrWait_Tick);
            // 
            // tmrWait2
            // 
            this.tmrWait2.Interval = 200;
            this.tmrWait2.Tick += new System.EventHandler(this.tmrWait2_Tick);
            // 
            // wmpPlayer
            // 
            this.wmpPlayer.Enabled = true;
            this.wmpPlayer.Location = new System.Drawing.Point(48, 182);
            this.wmpPlayer.Name = "wmpPlayer";
            this.wmpPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpPlayer.OcxState")));
            this.wmpPlayer.Size = new System.Drawing.Size(36, 24);
            this.wmpPlayer.TabIndex = 19;
            this.wmpPlayer.Visible = false;
            // 
            // wmpSound
            // 
            this.wmpSound.Enabled = true;
            this.wmpSound.Location = new System.Drawing.Point(48, 212);
            this.wmpSound.Name = "wmpSound";
            this.wmpSound.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpSound.OcxState")));
            this.wmpSound.Size = new System.Drawing.Size(36, 24);
            this.wmpSound.TabIndex = 19;
            this.wmpSound.Visible = false;
            // 
            // tmrMusic
            // 
            this.tmrMusic.Enabled = true;
            this.tmrMusic.Tick += new System.EventHandler(this.tmrMusic_Tick);
            // 
            // tmrSuyNghi
            // 
            this.tmrSuyNghi.Interval = 1000;
            this.tmrSuyNghi.Tick += new System.EventHandler(this.tmrSuyNghi_Tick);
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.BackColor = System.Drawing.Color.Transparent;
            this.lblThoiGian.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoiGian.ForeColor = System.Drawing.Color.Yellow;
            this.lblThoiGian.Location = new System.Drawing.Point(373, 317);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(31, 34);
            this.lblThoiGian.TabIndex = 20;
            this.lblThoiGian.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(297, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "50 - 50";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(362, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Hỏi khán giả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(453, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Đổi câu hỏi";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(190, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 31);
            this.label4.TabIndex = 1;
            this.label4.Text = "ĐIỂM";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Kết thúc";
            // 
            // btnDungChoi
            // 
            this.btnDungChoi.BackColor = System.Drawing.Color.Transparent;
            this.btnDungChoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDungChoi.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.btnDungChoi.Image = global::TroChoiRongVang.Properties.Resources.button_cance;
            this.btnDungChoi.Location = new System.Drawing.Point(544, 12);
            this.btnDungChoi.Name = "btnDungChoi";
            this.btnDungChoi.Size = new System.Drawing.Size(77, 49);
            this.btnDungChoi.TabIndex = 0;
            this.btnDungChoi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDungChoi.UseVisualStyleBackColor = false;
            this.btnDungChoi.Click += new System.EventHandler(this.btnDungChoi_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(542, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 18);
            this.label6.TabIndex = 21;
            this.label6.Text = "Dừng chơi";
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TroChoiRongVang.Properties.Resources.BG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblThoiGian);
            this.Controls.Add(this.wmpSound);
            this.Controls.Add(this.wmpPlayer);
            this.Controls.Add(this.pnlDanhSachDiem);
            this.Controls.Add(this.lblLuaChonD);
            this.Controls.Add(this.lblLuaChonC);
            this.Controls.Add(this.lblLuaChonB);
            this.Controls.Add(this.lblDapAnD);
            this.Controls.Add(this.lblDapAnC);
            this.Controls.Add(this.lblDapAnB);
            this.Controls.Add(this.lblDapAnA);
            this.Controls.Add(this.lblLuaChonA);
            this.Controls.Add(this.lblCauHoi);
            this.Controls.Add(this.picDapAnD);
            this.Controls.Add(this.picDapAnC);
            this.Controls.Add(this.picDapAnB);
            this.Controls.Add(this.picDapAnA);
            this.Controls.Add(this.lblDapAnDung);
            this.Controls.Add(this.picExit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDiem);
            this.Controls.Add(this.btnNhoNguoiThan);
            this.Controls.Add(this.btnDungChoi);
            this.Controls.Add(this.btnDoiCauHoi);
            this.Controls.Add(this.btnTraLoi2Lan);
            this.Controls.Add(this.picCauHoi);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TRO CHOI RONG VANG";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDapAnD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDapAnC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDapAnB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDapAnA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCauHoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wmpSound)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTraLoi2Lan;
        private System.Windows.Forms.Button btnDoiCauHoi;
        private System.Windows.Forms.Button btnNhoNguoiThan;
        private System.Windows.Forms.PictureBox picExit;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lblDapAnDung;
        private System.Windows.Forms.PictureBox picDapAnA;
        private System.Windows.Forms.PictureBox picDapAnB;
        private System.Windows.Forms.PictureBox picDapAnD;
        private System.Windows.Forms.PictureBox picDapAnC;
        private System.Windows.Forms.PictureBox picCauHoi;
        private System.Windows.Forms.Panel pnlDanhSachDiem;
        private System.Windows.Forms.Label lblCauHoi;
        private System.Windows.Forms.Label lblLuaChonA;
        private System.Windows.Forms.Label lblLuaChonB;
        private System.Windows.Forms.Label lblLuaChonC;
        private System.Windows.Forms.Label lblLuaChonD;
        private System.Windows.Forms.Label lblDapAnA;
        private System.Windows.Forms.Label lblDapAnB;
        private System.Windows.Forms.Label lblDapAnC;
        private System.Windows.Forms.Label lblDapAnD;
        public System.Windows.Forms.Timer tmrDanhSachCauHoi;
        private System.Windows.Forms.Timer tmrWait;
        private System.Windows.Forms.Timer tmrWait2;
        public System.Windows.Forms.Timer tmrDapAnDung;
        public System.Windows.Forms.Label lblDiem;
        public AxWMPLib.AxWindowsMediaPlayer wmpPlayer;
        public AxWMPLib.AxWindowsMediaPlayer wmpSound;
        private System.Windows.Forms.Timer tmrMusic;
        private System.Windows.Forms.Label lblThoiGian;
        public System.Windows.Forms.Timer tmrSuyNghi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDungChoi;
        private System.Windows.Forms.Label label6;
    }
}

