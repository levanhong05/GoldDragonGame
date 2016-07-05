namespace TroChoiRongVang
{
    partial class frmKetThuc
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
            this.lblDiem = new System.Windows.Forms.Label();
            this.lblThongBao = new System.Windows.Forms.Label();
            this.tmrWait = new System.Windows.Forms.Timer(this.components);
            this.lblWait = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDiem
            // 
            this.lblDiem.BackColor = System.Drawing.Color.Transparent;
            this.lblDiem.Font = new System.Drawing.Font("Arial Black", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiem.ForeColor = System.Drawing.Color.Red;
            this.lblDiem.Location = new System.Drawing.Point(12, 37);
            this.lblDiem.Name = "lblDiem";
            this.lblDiem.Size = new System.Drawing.Size(417, 57);
            this.lblDiem.TabIndex = 0;
            this.lblDiem.Text = "0";
            this.lblDiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblThongBao
            // 
            this.lblThongBao.BackColor = System.Drawing.Color.Transparent;
            this.lblThongBao.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongBao.ForeColor = System.Drawing.Color.Cyan;
            this.lblThongBao.Location = new System.Drawing.Point(12, 9);
            this.lblThongBao.Name = "lblThongBao";
            this.lblThongBao.Size = new System.Drawing.Size(417, 34);
            this.lblThongBao.TabIndex = 0;
            this.lblThongBao.Text = "Bạn đã kết thúc trò chơi với số điểm:";
            this.lblThongBao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrWait
            // 
            this.tmrWait.Interval = 1;
            this.tmrWait.Tick += new System.EventHandler(this.tmrWait_Tick);
            // 
            // lblWait
            // 
            this.lblWait.BackColor = System.Drawing.Color.Transparent;
            this.lblWait.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWait.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWait.Location = new System.Drawing.Point(16, 94);
            this.lblWait.Name = "lblWait";
            this.lblWait.Size = new System.Drawing.Size(413, 20);
            this.lblWait.TabIndex = 1;
            this.lblWait.Text = "Bạn sẽ quan về giao diện chức năng trong: 3s";
            this.lblWait.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmKetThuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TroChoiRongVang.Properties.Resources.ConfirmBG;
            this.ClientSize = new System.Drawing.Size(441, 123);
            this.Controls.Add(this.lblWait);
            this.Controls.Add(this.lblThongBao);
            this.Controls.Add(this.lblDiem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmKetThuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKetThuc";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmKetThuc_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblDiem;
        public System.Windows.Forms.Label lblThongBao;
        private System.Windows.Forms.Timer tmrWait;
        private System.Windows.Forms.Label lblWait;

    }
}