using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Collections;
using System.Media;

namespace TroChoiRongVang
{
    public partial class frmMainForm : Form
    {
        public SoundPlayer BackgroundMusic;
        TruyXuatDulieu txdl;
        ArrayList DSCH;
        ArrayList CauHoiCanTraLoi;
        Random rnd;
        int iTongSoCau = 20;
        int iCauHoi;
        int iSoCauMoiMucDo = 20 / 3;
        int iSoCauKho;
        int iSoCauTB;
        int iSoCauDe;
        int iDem = 0;
        public frmMainForm()
        {
            InitializeComponent();
            string strChuoiKetNoi = "provider = microsoft.jet.oledb.4.0;data source = TroChoiRongVang.mdb;";
            txdl = new TruyXuatDulieu(strChuoiKetNoi);
            txdl.MoKetNoi();
            panelNumMark.Visible = false;

            rnd = new Random();
            CauHoiCanTraLoi = new ArrayList();
            DSCH = CauHoi.DanhSachCauHoi(txdl);
          

            iSoCauKho = iSoCauMoiMucDo;
            iSoCauTB = iSoCauMoiMucDo;
            iSoCauDe = iTongSoCau - iSoCauKho * 2;
            //ch = (CauHoi)DSCH[iCauHoi];
        }
        
        // Danh sach cau hoi theo muc do
        public void LoadDanhSachCauHoi(string strMucDo, int iSoCau)
        {
            try
            {
                int iTam = 0;
                do
                {
                    iCauHoi = rnd.Next(0, DSCH.Count - 1);
                    CauHoi ch = (CauHoi)DSCH[iCauHoi];
                    if (ch.MUCDO == strMucDo && ch.ISLOADED == false)
                    {
                        ch.ISLOADED = true;
                        CauHoiCanTraLoi.Add(ch);
                        iTam++;
                    }
                } while (iTam < iSoCau);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Form load
        private void Form1_Load(object sender, EventArgs e)
        {
            //BackgroundMusic.Stream = TroChoiRongVang.Properties.Resources.
            panelHelp.Visible = false;

            LoadDanhSachCauHoi("De", iSoCauDe);
            LoadDanhSachCauHoi("TrungBinh", iSoCauTB);
            LoadDanhSachCauHoi("Kho", iSoCauKho);
        }
        #region Menu bonus
        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            panelHelp.Visible = false;
            timer2.Interval = 60;
        }

        private void picHelp_Click(object sender, EventArgs e)
        {
            panelHelp.Visible = true;
            labelHelp.Text.Clone();

            string strHelp = "";
            strHelp="Đây là phần hướng dẫn cách chơi trò chơi"+Environment.NewLine+
            "Khi nào xong thì viết tutorial nha"+Environment.NewLine+
            "Còn bây giờ thi chơi chay đi nha!";

            labelHelp.Text = strHelp;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panelHelp.Visible = true;
            labelHelp.Text.Clone();
            string strChuoi = @"Chương trình mô phỏng trò chơi rồng vàng!"+Environment.NewLine+
            "Nhóm tác giả chúc các bạn gặp nhiều niềm vui với trò chơi này"+Environment.NewLine+
            "Tác giả mong các bạn góp ý để phát triển ứng dụng thêm hoàn thiện..." + 
            "Nhóm tác giả trò chơi:"+Environment.NewLine+ 
            "Đặng Minh Dự-Email:cp.dev.minhdu@gmail.com"+Environment.NewLine+
            "Từ Xuân Chiến-Email:xuanchien247@gmail.com";

            labelHelp.Text = strChuoi;
            labelHelp.Location = new Point(labelHelp.Location.X, 250);
        }

        int i = 100;
        private void timer2_Tick(object sender, EventArgs e)
        {
            i -= 1;
            labelHelp.Location = new Point(labelHelp.Location.X, i);
            if (i == -50)
                i = 100;
        }
        private void picNumMark_Click(object sender, EventArgs e)
        {
            panelNumMark.Visible = true;
            panelNumMark.Location = new Point(700,243);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panelNumMark.Visible = false;
        }
        #endregion
        #region mouse event
        private void lblDapAnA_MouseMove(object sender, MouseEventArgs e)
        {
            lblDapAnA.BackColor = Color.Turquoise;
        }  
 
        private void lblDapAnA_MouseLeave(object sender, EventArgs e)
        {
            lblDapAnA.BackColor=Color.Transparent;
        }

        private void lblDapAnB_MouseMove(object sender, MouseEventArgs e)
        {
            lblDapAnB.BackColor = Color.Turquoise;
        }

        private void lblDapAnB_MouseLeave(object sender, EventArgs e)
        {
            lblDapAnB.BackColor = Color.Transparent;
        }

        private void lblDapAnC_MouseMove(object sender, MouseEventArgs e)
        {
            lblDapAnC.BackColor = Color.Turquoise;
        }

        private void lblDapAnC_MouseLeave(object sender, EventArgs e)
        {
            lblDapAnC.BackColor = Color.Transparent;
        }

        private void lblDapAnD_MouseMove(object sender, MouseEventArgs e)
        {
            lblDapAnD.BackColor = Color.Turquoise;
        }

        private void lblDapAnD_MouseLeave(object sender, EventArgs e)
        {
            lblDapAnD.BackColor = Color.Transparent;
        }

        private void btnXacNhan_MouseMove(object sender, MouseEventArgs e)
        {
            btnXacNhan.Width = 151;
            btnXacNhan.Height = 41;
        }

        private void btnXacNhan_MouseLeave(object sender, EventArgs e)
        {
            btnXacNhan.Width = 147;
            btnXacNhan.Height = 36;
        }

        private void picHelp_MouseLeave(object sender, EventArgs e)
        {
            picHelp.Width = 79;
            picHelp.Height = 45;
        }
        private void picHelp_MouseMove(object sender, MouseEventArgs e)
        {
            picHelp.Width = 83;
            picHelp.Height = 49;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Width = 87;
            pictureBox1.Height = 37;
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Width = 92;
            pictureBox1.Height = 42;
        }
        private void picExit_MouseMove(object sender, MouseEventArgs e)
        {
            picExit.Width=86;
            picExit.Height=60;
        }
        private void picExit_MouseLeave(object sender, EventArgs e)
        {
            picExit.Width = 82;
            picExit.Height=56;
        }

        private void picNumMark_MouseMove(object sender, MouseEventArgs e)
        {
            picNumMark.Width = 39;
            picNumMark.Height = 32;
        }

        private void picNumMark_MouseLeave(object sender, EventArgs e)
        {
            picNumMark.Width = 35;
            picNumMark.Height = 28;
        }
#endregion
        private void btnXacNhan_Click(object sender, EventArgs e)
        {           
            try
            {
                iDem++;
                for (int i = 0; i <= iTongSoCau - 1; i++)
                {
                    CauHoi ch = (CauHoi)CauHoiCanTraLoi[iDem];
                    lblCauHoi.Text = ch.CAUHOI;
                    lblDapAnA.Text = ch.DAPANA;
                    lblDapAnB.Text = ch.DAPANB;
                    lblDapAnC.Text = ch.DAPANC;
                    lblDapAnD.Text = ch.DAPAND;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true)
            {
                lblDapAnA.BackColor = Color.HotPink;
            }
            else
                lblDapAnA.BackColor = Color.Transparent;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton2.Checked == true)
            {
                lblDapAnB.BackColor = Color.HotPink;
            }
            else
                lblDapAnB.BackColor = Color.Transparent;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton3.Checked == true)
            {
                lblDapAnC.BackColor = Color.HotPink;
            }
            else
                lblDapAnC.BackColor = Color.Transparent;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                lblDapAnD.BackColor = Color.HotPink;
            }
            else
                lblDapAnD.BackColor = Color.Transparent;
            
        }

       

    }
}