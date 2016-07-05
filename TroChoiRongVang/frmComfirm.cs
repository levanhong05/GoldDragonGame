using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TroChoiRongVang
{
    public partial class frmComfirm : Form
    {
        string strUserName = "";

        public frmComfirm(string uname)
        {
            InitializeComponent();
            strUserName = uname;
        }

        private void Co_Click(object sender, EventArgs e)
        {
            frmMainForm f = (frmMainForm)this.Owner;
            frmKetThuc kt = new frmKetThuc(strUserName);

            if (f.TraLoiDung())
            {
                f.ResetMau();
                f.iSoLanChop = 0;
                f.tmrDapAnDung.Enabled = true;
                f.bHienDanhSachCauHoi = true;
                f.tmrDanhSachCauHoi.Enabled = true;
            }
            else
            {
                int iDiem = int.Parse(f.lblDiem.Text) / 2;
                kt.lblDiem.Text = iDiem.ToString();
                kt.lblThongBao.Text = "Bạn đã kết thúc trò chơi với số điểm:";
                kt.ShowDialog(this);
                string strSoundPath = Application.StartupPath + "\\" + "Select.mp3";
                f.PlayASound(strSoundPath);
                f.Close();
            }

            this.Close();
        }

        private void Khong_Click(object sender, EventArgs e)
        {
            frmMainForm f = (frmMainForm)this.Owner;
            f.DisableAll(false);
            f.tmrSuyNghi.Enabled = true;
            this.Close();
        }

        private void Co_Over(object sender, MouseEventArgs e)
        {
            ResetMau();
            picCo.Image = Properties.Resources.Confirm_Over;
            lblCo.BackColor = Color.FromArgb(249, 155, 28);
            lblCo.ForeColor = Color.White;
        }

        private void Khong_Over(object sender, MouseEventArgs e)
        {
            ResetMau();
            picKhong.Image = Properties.Resources.Confirm_Over;
            lblKhong.BackColor = Color.FromArgb(249, 155, 28);
            lblKhong.ForeColor = Color.White;
        }

        private void ResetMau()
        {
            picKhong.Image = Properties.Resources.ConfirmButton;
            lblKhong.BackColor = Color.Black;
            lblKhong.ForeColor = Color.FromArgb(255, 128, 255);
            picCo.Image = Properties.Resources.ConfirmButton;
            lblCo.BackColor = Color.Black;
            lblCo.ForeColor = Color.FromArgb(255, 128, 255);
        }

        private void frmComfirm_MouseMove(object sender, MouseEventArgs e)
        {
            ResetMau();
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            ResetMau();
        }

        private void pictureBox3_MouseMove(object sender, MouseEventArgs e)
        {
            ResetMau();
        }

    }
}