namespace TroChoiRongVang
{
    partial class frmQuanTri
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
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.gpxThongTinCauhoi = new System.Windows.Forms.GroupBox();
            this.comboBoxMucDoChoi = new System.Windows.Forms.ComboBox();
            this.comboBoxDapAnDung = new System.Windows.Forms.ComboBox();
            this.txtMaCauHoi = new System.Windows.Forms.TextBox();
            this.txtNoiDungCauHoi = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDapAnD = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDapAnC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDapAnB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDapAnA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbxDanhSachCauHoi = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbChonMucDoChoi = new System.Windows.Forms.ComboBox();
            this.gpxThongTinCauhoi.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(328, 263);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 34);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(229, 263);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 34);
            this.btnXoa.TabIndex = 14;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(130, 263);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 34);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // gpxThongTinCauhoi
            // 
            this.gpxThongTinCauhoi.Controls.Add(this.btnSua);
            this.gpxThongTinCauhoi.Controls.Add(this.comboBoxMucDoChoi);
            this.gpxThongTinCauhoi.Controls.Add(this.btnXoa);
            this.gpxThongTinCauhoi.Controls.Add(this.btnThem);
            this.gpxThongTinCauhoi.Controls.Add(this.comboBoxDapAnDung);
            this.gpxThongTinCauhoi.Controls.Add(this.txtMaCauHoi);
            this.gpxThongTinCauhoi.Controls.Add(this.txtNoiDungCauHoi);
            this.gpxThongTinCauhoi.Controls.Add(this.label10);
            this.gpxThongTinCauhoi.Controls.Add(this.txtDapAnD);
            this.gpxThongTinCauhoi.Controls.Add(this.label9);
            this.gpxThongTinCauhoi.Controls.Add(this.txtDapAnC);
            this.gpxThongTinCauhoi.Controls.Add(this.label8);
            this.gpxThongTinCauhoi.Controls.Add(this.txtDapAnB);
            this.gpxThongTinCauhoi.Controls.Add(this.label7);
            this.gpxThongTinCauhoi.Controls.Add(this.txtDapAnA);
            this.gpxThongTinCauhoi.Controls.Add(this.label6);
            this.gpxThongTinCauhoi.Controls.Add(this.label3);
            this.gpxThongTinCauhoi.Controls.Add(this.label5);
            this.gpxThongTinCauhoi.Controls.Add(this.label4);
            this.gpxThongTinCauhoi.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpxThongTinCauhoi.Location = new System.Drawing.Point(361, 65);
            this.gpxThongTinCauhoi.Name = "gpxThongTinCauhoi";
            this.gpxThongTinCauhoi.Size = new System.Drawing.Size(480, 315);
            this.gpxThongTinCauhoi.TabIndex = 10;
            this.gpxThongTinCauhoi.TabStop = false;
            this.gpxThongTinCauhoi.Text = "Thông tin câu hỏi:";
            // 
            // comboBoxMucDoChoi
            // 
            this.comboBoxMucDoChoi.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMucDoChoi.FormattingEnabled = true;
            this.comboBoxMucDoChoi.Items.AddRange(new object[] {
            "De",
            "TrungBinh",
            "Kho"});
            this.comboBoxMucDoChoi.Location = new System.Drawing.Point(85, 224);
            this.comboBoxMucDoChoi.Name = "comboBoxMucDoChoi";
            this.comboBoxMucDoChoi.Size = new System.Drawing.Size(377, 24);
            this.comboBoxMucDoChoi.TabIndex = 7;
            // 
            // comboBoxDapAnDung
            // 
            this.comboBoxDapAnDung.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDapAnDung.FormattingEnabled = true;
            this.comboBoxDapAnDung.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D"});
            this.comboBoxDapAnDung.Location = new System.Drawing.Point(85, 194);
            this.comboBoxDapAnDung.Name = "comboBoxDapAnDung";
            this.comboBoxDapAnDung.Size = new System.Drawing.Size(377, 24);
            this.comboBoxDapAnDung.TabIndex = 6;
            // 
            // txtMaCauHoi
            // 
            this.txtMaCauHoi.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaCauHoi.Location = new System.Drawing.Point(85, 26);
            this.txtMaCauHoi.Name = "txtMaCauHoi";
            this.txtMaCauHoi.ReadOnly = true;
            this.txtMaCauHoi.Size = new System.Drawing.Size(377, 22);
            this.txtMaCauHoi.TabIndex = 1;
            // 
            // txtNoiDungCauHoi
            // 
            this.txtNoiDungCauHoi.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoiDungCauHoi.Location = new System.Drawing.Point(85, 54);
            this.txtNoiDungCauHoi.Name = "txtNoiDungCauHoi";
            this.txtNoiDungCauHoi.Size = new System.Drawing.Size(377, 22);
            this.txtNoiDungCauHoi.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Mức độ chơi:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDapAnD
            // 
            this.txtDapAnD.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDapAnD.Location = new System.Drawing.Point(85, 166);
            this.txtDapAnD.Name = "txtDapAnD";
            this.txtDapAnD.Size = new System.Drawing.Size(377, 22);
            this.txtDapAnD.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Đáp án đúng:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDapAnC
            // 
            this.txtDapAnC.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDapAnC.Location = new System.Drawing.Point(85, 138);
            this.txtDapAnC.Name = "txtDapAnC";
            this.txtDapAnC.Size = new System.Drawing.Size(377, 22);
            this.txtDapAnC.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Đáp án D:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDapAnB
            // 
            this.txtDapAnB.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDapAnB.Location = new System.Drawing.Point(85, 110);
            this.txtDapAnB.Name = "txtDapAnB";
            this.txtDapAnB.Size = new System.Drawing.Size(377, 22);
            this.txtDapAnB.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Đáp án C:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDapAnA
            // 
            this.txtDapAnA.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDapAnA.Location = new System.Drawing.Point(85, 82);
            this.txtDapAnA.Name = "txtDapAnA";
            this.txtDapAnA.Size = new System.Drawing.Size(377, 22);
            this.txtDapAnA.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Đáp án B:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã câu hỏi:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Đáp án A:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Câu hỏi:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbxDanhSachCauHoi
            // 
            this.lbxDanhSachCauHoi.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxDanhSachCauHoi.FormattingEnabled = true;
            this.lbxDanhSachCauHoi.ItemHeight = 16;
            this.lbxDanhSachCauHoi.Location = new System.Drawing.Point(15, 65);
            this.lbxDanhSachCauHoi.Name = "lbxDanhSachCauHoi";
            this.lbxDanhSachCauHoi.ScrollAlwaysVisible = true;
            this.lbxDanhSachCauHoi.Size = new System.Drawing.Size(340, 308);
            this.lbxDanhSachCauHoi.TabIndex = 9;
            this.lbxDanhSachCauHoi.SelectedIndexChanged += new System.EventHandler(this.lbxDanhSachCauHoi_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Danh sách câu hỏi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Danh sách câu hỏi theo mức độ:";
            // 
            // cmbChonMucDoChoi
            // 
            this.cmbChonMucDoChoi.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cmbChonMucDoChoi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChonMucDoChoi.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChonMucDoChoi.FormattingEnabled = true;
            this.cmbChonMucDoChoi.Items.AddRange(new object[] {
            "De",
            "TrungBinh",
            "Kho"});
            this.cmbChonMucDoChoi.Location = new System.Drawing.Point(184, 9);
            this.cmbChonMucDoChoi.Name = "cmbChonMucDoChoi";
            this.cmbChonMucDoChoi.Size = new System.Drawing.Size(657, 24);
            this.cmbChonMucDoChoi.TabIndex = 6;
            this.cmbChonMucDoChoi.SelectedIndexChanged += new System.EventHandler(this.cmbChonMucDoChoi_SelectedIndexChanged);
            // 
            // frmQuanTri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 397);
            this.Controls.Add(this.gpxThongTinCauhoi);
            this.Controls.Add(this.lbxDanhSachCauHoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbChonMucDoChoi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmQuanTri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lí danh sách câu hỏi";
            this.Load += new System.EventHandler(this.frmQuanTri_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmQuanTri_FormClosed);
            this.gpxThongTinCauhoi.ResumeLayout(false);
            this.gpxThongTinCauhoi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox gpxThongTinCauhoi;
        private System.Windows.Forms.TextBox txtNoiDungCauHoi;
        private System.Windows.Forms.TextBox txtDapAnA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbxDanhSachCauHoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbChonMucDoChoi;
        private System.Windows.Forms.TextBox txtDapAnD;
        private System.Windows.Forms.TextBox txtDapAnC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDapAnB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMaCauHoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxDapAnDung;
        private System.Windows.Forms.ComboBox comboBoxMucDoChoi;
        private System.Windows.Forms.Label label10;
    }
}