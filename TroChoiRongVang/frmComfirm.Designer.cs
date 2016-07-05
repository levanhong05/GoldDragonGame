namespace TroChoiRongVang
{
    partial class frmComfirm
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
            this.label1 = new System.Windows.Forms.Label();
            this.picCo = new System.Windows.Forms.PictureBox();
            this.picKhong = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblCo = new System.Windows.Forms.Label();
            this.lblKhong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKhong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Arial", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(44, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đây có phải là lựa chọn cuối cùng của bạn?";
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // picCo
            // 
            this.picCo.BackColor = System.Drawing.Color.Transparent;
            this.picCo.Image = global::TroChoiRongVang.Properties.Resources.ConfirmButton;
            this.picCo.Location = new System.Drawing.Point(50, 72);
            this.picCo.Name = "picCo";
            this.picCo.Size = new System.Drawing.Size(167, 32);
            this.picCo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCo.TabIndex = 2;
            this.picCo.TabStop = false;
            this.picCo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Co_Over);
            this.picCo.Click += new System.EventHandler(this.Co_Click);
            // 
            // picKhong
            // 
            this.picKhong.BackColor = System.Drawing.Color.Transparent;
            this.picKhong.Image = global::TroChoiRongVang.Properties.Resources.ConfirmButton;
            this.picKhong.Location = new System.Drawing.Point(223, 72);
            this.picKhong.Name = "picKhong";
            this.picKhong.Size = new System.Drawing.Size(167, 32);
            this.picKhong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picKhong.TabIndex = 2;
            this.picKhong.TabStop = false;
            this.picKhong.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Khong_Over);
            this.picKhong.Click += new System.EventHandler(this.Khong_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::TroChoiRongVang.Properties.Resources.ConfirmButton;
            this.pictureBox3.Location = new System.Drawing.Point(29, 20);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(385, 46);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseMove);
            // 
            // lblCo
            // 
            this.lblCo.BackColor = System.Drawing.Color.Black;
            this.lblCo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblCo.Location = new System.Drawing.Point(117, 78);
            this.lblCo.Name = "lblCo";
            this.lblCo.Size = new System.Drawing.Size(46, 20);
            this.lblCo.TabIndex = 0;
            this.lblCo.Text = "Có";
            this.lblCo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Co_Over);
            this.lblCo.Click += new System.EventHandler(this.Co_Click);
            // 
            // lblKhong
            // 
            this.lblKhong.BackColor = System.Drawing.Color.Black;
            this.lblKhong.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblKhong.Location = new System.Drawing.Point(280, 77);
            this.lblKhong.Name = "lblKhong";
            this.lblKhong.Size = new System.Drawing.Size(66, 20);
            this.lblKhong.TabIndex = 0;
            this.lblKhong.Text = "Không";
            this.lblKhong.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Khong_Over);
            this.lblKhong.Click += new System.EventHandler(this.Khong_Click);
            // 
            // frmComfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TroChoiRongVang.Properties.Resources.ConfirmBG;
            this.ClientSize = new System.Drawing.Size(441, 123);
            this.Controls.Add(this.lblKhong);
            this.Controls.Add(this.lblCo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picKhong);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.picCo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmComfirm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xác nhận câu trả lời";
            this.TopMost = true;
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmComfirm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picCo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picKhong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picCo;
        private System.Windows.Forms.PictureBox picKhong;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblCo;
        private System.Windows.Forms.Label lblKhong;
    }
}