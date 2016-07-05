using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TroChoiRongVang
{
    public partial class frmKetThuc : Form
    {
        int i = 4;
        string strUserName = "";

        public frmKetThuc(string uname)
        {
            InitializeComponent();
            strUserName = uname;
        }

        private void tmrWait_Tick(object sender, EventArgs e)
        {
            if (tmrWait.Interval == 1)
            {
                tmrWait.Interval = 1000;
            }

            i--;

            lblWait.Text = "Bạn sẽ quan về giao diện chức năng trong: " + i + "s";

            if (i == 0)
            {
                frmChucNang cn = new frmChucNang(strUserName);
                cn.Show();
                this.Close();
            }
        }

        private void frmKetThuc_Load(object sender, EventArgs e)
        {
            tmrWait.Enabled = true;
        }
    }
}