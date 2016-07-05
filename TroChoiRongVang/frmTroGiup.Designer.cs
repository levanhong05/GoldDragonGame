namespace TroChoiRongVang
{
    partial class frmTroGiup
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBarA = new System.Windows.Forms.ProgressBar();
            this.progressBarB = new System.Windows.Forms.ProgressBar();
            this.progressBarC = new System.Windows.Forms.ProgressBar();
            this.progressBarD = new System.Windows.Forms.ProgressBar();
            this.lblCo = new System.Windows.Forms.Label();
            this.picCo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(48, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "A:";
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(48, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "B:";
            this.label2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label2_MouseMove);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(48, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "C:";
            this.label3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label3_MouseMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(48, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "D:";
            this.label4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label4_MouseMove);
            // 
            // progressBarA
            // 
            this.progressBarA.Location = new System.Drawing.Point(82, 41);
            this.progressBarA.Name = "progressBarA";
            this.progressBarA.Size = new System.Drawing.Size(263, 23);
            this.progressBarA.TabIndex = 1;
            // 
            // progressBarB
            // 
            this.progressBarB.Location = new System.Drawing.Point(82, 77);
            this.progressBarB.Name = "progressBarB";
            this.progressBarB.Size = new System.Drawing.Size(263, 23);
            this.progressBarB.TabIndex = 1;
            // 
            // progressBarC
            // 
            this.progressBarC.Location = new System.Drawing.Point(82, 112);
            this.progressBarC.Name = "progressBarC";
            this.progressBarC.Size = new System.Drawing.Size(263, 23);
            this.progressBarC.TabIndex = 1;
            // 
            // progressBarD
            // 
            this.progressBarD.Location = new System.Drawing.Point(82, 151);
            this.progressBarD.Name = "progressBarD";
            this.progressBarD.Size = new System.Drawing.Size(263, 23);
            this.progressBarD.TabIndex = 1;
            // 
            // lblCo
            // 
            this.lblCo.BackColor = System.Drawing.Color.Black;
            this.lblCo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblCo.Location = new System.Drawing.Point(129, 198);
            this.lblCo.Name = "lblCo";
            this.lblCo.Size = new System.Drawing.Size(150, 20);
            this.lblCo.TabIndex = 3;
            this.lblCo.Text = "Đóng";
            this.lblCo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Dong_Over);
            this.lblCo.Click += new System.EventHandler(this.lblCo_Click);
            // 
            // picCo
            // 
            this.picCo.BackColor = System.Drawing.Color.Transparent;
            this.picCo.Image = global::TroChoiRongVang.Properties.Resources.ConfirmButton;
            this.picCo.Location = new System.Drawing.Point(120, 192);
            this.picCo.Name = "picCo";
            this.picCo.Size = new System.Drawing.Size(167, 32);
            this.picCo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCo.TabIndex = 4;
            this.picCo.TabStop = false;
            this.picCo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Dong_Over);
            this.picCo.Click += new System.EventHandler(this.picCo_Click);
            // 
            // frmTroGiup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TroChoiRongVang.Properties.Resources.ConfirmBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(397, 255);
            this.Controls.Add(this.lblCo);
            this.Controls.Add(this.picCo);
            this.Controls.Add(this.progressBarD);
            this.Controls.Add(this.progressBarC);
            this.Controls.Add(this.progressBarB);
            this.Controls.Add(this.progressBarA);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTroGiup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tỉ lệ ý kiến khá giả";
            this.Load += new System.EventHandler(this.frmTroGiup_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmTroGiup_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.picCo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBarA;
        private System.Windows.Forms.ProgressBar progressBarB;
        private System.Windows.Forms.ProgressBar progressBarC;
        private System.Windows.Forms.ProgressBar progressBarD;
        private System.Windows.Forms.Label lblCo;
        private System.Windows.Forms.PictureBox picCo;
    }
}