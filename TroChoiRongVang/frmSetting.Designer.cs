namespace TroChoiRongVang
{
    partial class frmSetting
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
            this.cbxSoCauToiDa = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxThoiGianSuyNghi = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbxSoCauToiDa
            // 
            this.cbxSoCauToiDa.FormattingEnabled = true;
            this.cbxSoCauToiDa.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30"});
            this.cbxSoCauToiDa.Location = new System.Drawing.Point(20, 36);
            this.cbxSoCauToiDa.Name = "cbxSoCauToiDa";
            this.cbxSoCauToiDa.Size = new System.Drawing.Size(222, 21);
            this.cbxSoCauToiDa.TabIndex = 0;
            this.cbxSoCauToiDa.Text = "15";
            this.cbxSoCauToiDa.SelectedIndexChanged += new System.EventHandler(this.cbxSoCauToiDa_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Số câu hỏi tối đa:";
            // 
            // cbxThoiGianSuyNghi
            // 
            this.cbxThoiGianSuyNghi.FormattingEnabled = true;
            this.cbxThoiGianSuyNghi.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60"});
            this.cbxThoiGianSuyNghi.Location = new System.Drawing.Point(18, 79);
            this.cbxThoiGianSuyNghi.Name = "cbxThoiGianSuyNghi";
            this.cbxThoiGianSuyNghi.Size = new System.Drawing.Size(222, 21);
            this.cbxThoiGianSuyNghi.TabIndex = 0;
            this.cbxThoiGianSuyNghi.Text = "20";
            this.cbxThoiGianSuyNghi.SelectedIndexChanged += new System.EventHandler(this.cbxThoiGianSuyNghi_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Thời gian suy nghĩ:";
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.IndianRed;
            this.btnHuy.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.btnHuy.Location = new System.Drawing.Point(135, 106);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(105, 30);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Đóng";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.IndianRed;
            this.btnLuu.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.btnLuu.Location = new System.Drawing.Point(22, 106);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(107, 30);
            this.btnLuu.TabIndex = 3;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 160);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxThoiGianSuyNghi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbxSoCauToiDa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tùy chỉnh trò chơi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxSoCauToiDa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxThoiGianSuyNghi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
    }
}