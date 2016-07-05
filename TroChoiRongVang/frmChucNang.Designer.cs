namespace TroChoiRongVang
{
    partial class frmChucNang
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
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.muCNTQ = new System.Windows.Forms.ToolStripMenuItem();
            this.miBatDau = new System.Windows.Forms.ToolStripMenuItem();
            this.miDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.muQTV = new System.Windows.Forms.ToolStripMenuItem();
            this.miDSCH = new System.Windows.Forms.ToolStripMenuItem();
            this.miTuyChinh = new System.Windows.Forms.ToolStripMenuItem();
            this.muThongTin = new System.Windows.Forms.ToolStripMenuItem();
            this.miHuongDan = new System.Windows.Forms.ToolStripMenuItem();
            this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.muCNTQ,
            this.muQTV,
            this.muThongTin});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(479, 24);
            this.mnuMain.TabIndex = 0;
            this.mnuMain.Text = "Menu";
            // 
            // muCNTQ
            // 
            this.muCNTQ.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miBatDau,
            this.miDangXuat});
            this.muCNTQ.Name = "muCNTQ";
            this.muCNTQ.Size = new System.Drawing.Size(63, 20);
            this.muCNTQ.Text = "Trò chơi";
            // 
            // miBatDau
            // 
            this.miBatDau.Name = "miBatDau";
            this.miBatDau.Size = new System.Drawing.Size(140, 22);
            this.miBatDau.Text = "Bắt đầu chơi";
            this.miBatDau.Click += new System.EventHandler(this.miBatDau_Click);
            // 
            // miDangXuat
            // 
            this.miDangXuat.Name = "miDangXuat";
            this.miDangXuat.Size = new System.Drawing.Size(140, 22);
            this.miDangXuat.Text = "Đăng xuất";
            this.miDangXuat.Click += new System.EventHandler(this.miDangXuat_Click);
            // 
            // muQTV
            // 
            this.muQTV.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miDSCH,
            this.miTuyChinh});
            this.muQTV.Name = "muQTV";
            this.muQTV.Size = new System.Drawing.Size(146, 20);
            this.muQTV.Text = "Chức năng quản trị viên";
            // 
            // miDSCH
            // 
            this.miDSCH.Name = "miDSCH";
            this.miDSCH.Size = new System.Drawing.Size(211, 22);
            this.miDSCH.Text = "Quản lí danh sách câu hỏi";
            this.miDSCH.Click += new System.EventHandler(this.miDSCH_Click);
            // 
            // miTuyChinh
            // 
            this.miTuyChinh.Name = "miTuyChinh";
            this.miTuyChinh.Size = new System.Drawing.Size(211, 22);
            this.miTuyChinh.Text = "Tùy chỉnh trò chơi";
            this.miTuyChinh.Click += new System.EventHandler(this.miTuyChinh_Click);
            // 
            // muThongTin
            // 
            this.muThongTin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miHuongDan,
            this.miAbout});
            this.muThongTin.Name = "muThongTin";
            this.muThongTin.Size = new System.Drawing.Size(71, 20);
            this.muThongTin.Text = "Thông tin";
            // 
            // miHuongDan
            // 
            this.miHuongDan.Name = "miHuongDan";
            this.miHuongDan.Size = new System.Drawing.Size(180, 22);
            this.miHuongDan.Text = "Hướng dẫn sử dụng";
            this.miHuongDan.Click += new System.EventHandler(this.miHuongDan_Click);
            // 
            // miAbout
            // 
            this.miAbout.Name = "miAbout";
            this.miAbout.Size = new System.Drawing.Size(180, 22);
            this.miAbout.Text = "Về chúng tôi";
            this.miAbout.Click += new System.EventHandler(this.miAbout_Click);
            // 
            // frmChucNang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TroChoiRongVang.Properties.Resources.rongvang;
            this.ClientSize = new System.Drawing.Size(479, 328);
            this.ControlBox = false;
            this.Controls.Add(this.mnuMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuMain;
            this.MaximizeBox = false;
            this.Name = "frmChucNang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lựa chọn chức năng";
            this.Load += new System.EventHandler(this.frmChucNang_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem muCNTQ;
        private System.Windows.Forms.ToolStripMenuItem muThongTin;
        private System.Windows.Forms.ToolStripMenuItem miBatDau;
        private System.Windows.Forms.ToolStripMenuItem miDSCH;
        private System.Windows.Forms.ToolStripMenuItem miHuongDan;
        private System.Windows.Forms.ToolStripMenuItem miDangXuat;
        private System.Windows.Forms.ToolStripMenuItem miAbout;
        public System.Windows.Forms.ToolStripMenuItem muQTV;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem miTuyChinh;
    }
}