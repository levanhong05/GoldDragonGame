using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TroChoiRongVang
{
    public partial class frmChucNang : Form
    {
        string strUserName = "";

        public frmChucNang(string uname)
        {
            InitializeComponent();
            strUserName = uname;
        }

        private void frmChucNang_Load(object sender, EventArgs e)
        {
            if (strUserName.ToLower() != "hong" && strUserName.ToLower() != "eric")
            {
                muQTV.Visible = false;
            }
            else
            {
                muQTV.Visible = true;
            }
        }

        private void miDangXuat_Click(object sender, EventArgs e)
        {
            frmDangNhap dn = new frmDangNhap();
            dn.Show();
            this.Close();
        }

        private void miBatDau_Click(object sender, EventArgs e)
        {
            frmMainForm main = new frmMainForm(strUserName);
            main.Show();
            this.Hide();
        }

        private void miDSCH_Click(object sender, EventArgs e)
        {
            frmQuanTri qt = new frmQuanTri(strUserName);
            qt.Show();
            this.Close();
        }

        private void miHuongDan_Click(object sender, EventArgs e)
        {
            frmHuongDan hd = new frmHuongDan();
            hd.ShowDialog(this);
        }

        private void miAbout_Click(object sender, EventArgs e)
        {
            frmAboutUs abu = new frmAboutUs();
            abu.ShowDialog(this);
        }

        private void miTuyChinh_Click(object sender, EventArgs e)
        {
            frmSetting st = new frmSetting();
            st.Show();
        }
    }
}