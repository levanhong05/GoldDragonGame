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
using System.Xml;
using System.IO;

namespace TroChoiRongVang
{
    public partial class frmMainForm : Form
    {
        public SoundPlayer BackgroundMusic;
        TruyXuatDulieu txdl;
        ArrayList DSCH;
        ArrayList CauHoiCanTraLoi;
        Random rnd;
        public int iTongSoCau;
        int iSoCauMoiMucDo;
        int iCauHoi;
        int iSoCauKho;
        int iSoCauTB;
        int iSoCauDe;
        string strDapAnDung;
        public int iCauTiepTheo = 0;
        string strDapAnDuocChon;
        public int iSoLanChop;
        public bool bHienDanhSachCauHoi = false;
        bool bTrue = false;
        Color c;
        frmComfirm confirm;
        string strSoundPath;
        string strUserName = "";
        int iThoiGianSuyNghi;
        int iThoiGian;

        public frmMainForm(string uname)
        {
            InitializeComponent();
            strUserName = uname;
            confirm = new frmComfirm(strUserName);

            string strChuoiKetNoi = "provider = microsoft.jet.oledb.4.0;data source = TroChoiRongVang.mdb;";
            txdl = new TruyXuatDulieu(strChuoiKetNoi);
            txdl.MoKetNoi();

            rnd = new Random();
            CauHoiCanTraLoi = new ArrayList();
            DSCH = CauHoi.DanhSachCauHoi(txdl);

            ReadSetting();

            iSoCauKho = iSoCauMoiMucDo;
            iSoCauTB = iSoCauMoiMucDo;
            iSoCauDe = iTongSoCau - iSoCauKho * 2;
            MenuDiem();
        }

        public void ReadSetting()
        {
            string fileName = "Setting.xml";
            FileStream fs = new FileStream(fileName, FileMode.Open);
            XmlTextReader xtr = new XmlTextReader(fs);

            while (!xtr.EOF)
            {
                if (xtr.MoveToContent() == XmlNodeType.Element && xtr.Name == "SoCauHoiToiDa")
                {
                    iTongSoCau = int.Parse(xtr.ReadElementString()) + 1;
                }
                else if(xtr.MoveToContent() == XmlNodeType.Element && xtr.Name == "ThoiGianSuyNghi")
                {
                    iThoiGianSuyNghi = int.Parse(xtr.ReadElementString());
                }
                else
                {
                    xtr.Read();
                }
            }
            iSoCauMoiMucDo = (iTongSoCau - 1) / 3;
            fs.Close();
        }

        //Menu diem
        public void MenuDiem()
        {
            int iDonViChieuCao = pnlDanhSachDiem.Height / (iTongSoCau - 1);
            int iLeft = 0;
            int iTop = pnlDanhSachDiem.Height;

            for (int i = 0; i < iTongSoCau - 1; i++)
            {
                Label lblDiem = new Label();
                iTop = iTop - iDonViChieuCao;
                lblDiem.Top = iTop;
                lblDiem.Left = iLeft;
                lblDiem.Height = iDonViChieuCao;
                lblDiem.Width = pnlDanhSachDiem.Width;
                int iDiem = (i + 1) * 100;
                lblDiem.Text = iDiem.ToString();
                lblDiem.TextAlign = ContentAlignment.MiddleCenter;
                lblDiem.BorderStyle = BorderStyle.FixedSingle;
                lblDiem.BackColor = Color.Orange;
                lblDiem.ForeColor = Color.Blue;
                lblDiem.Font = new Font("Arial", 9, FontStyle.Bold);
                pnlDanhSachDiem.Controls.Add(lblDiem);
            }
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

            strSoundPath = Application.StartupPath + "\\" + "Start.mp3";
            wmpPlayer.URL = strSoundPath;
            wmpPlayer.Ctlcontrols.play();

            int iSoCauMoiMucDo =iTongSoCau / 3;

            LoadDanhSachCauHoi("De", iSoCauDe);
            LoadDanhSachCauHoi("TrungBinh", iSoCauTB);
            LoadDanhSachCauHoi("Kho", iSoCauKho);

            
            //strDapAnDung = "A";
            //iSoLanChop = 0;
            //tmrDapAnDung.Enabled = true;
            //bHienDanhSachCauHoi =false;
            //tmrDanhSachCauHoi.Enabled = true;
            LoadCauHoiTiepTheo();
            iThoiGian = iThoiGianSuyNghi;
            tmrSuyNghi.Enabled = true;
        }

        public void LoadCauHoiTiepTheo()
        {
            if (iCauTiepTheo < CauHoiCanTraLoi.Count)
            {
                CauHoi ch = (CauHoi)CauHoiCanTraLoi[iCauTiepTheo];
                lblCauHoi.Text = ch.CAUHOI;
                lblDapAnA.Text = ch.DAPANA;
                lblDapAnB.Text = ch.DAPANB;
                lblDapAnC.Text = ch.DAPANC;
                lblDapAnD.Text = ch.DAPAND;
                strDapAnDung = ch.DAPANDUNG;
                iCauTiepTheo++;

                tmrSuyNghi.Enabled = false;
                iThoiGian = iThoiGianSuyNghi + 1;
                tmrSuyNghi.Enabled = true;
            }
            else
            {
                return;
            }
        }

        public bool TraLoiDung()
        {
            bool bKQ = false;
            CauHoi ch = (CauHoi)CauHoiCanTraLoi[iCauTiepTheo - 1];
            if (ch.DAPANDUNG == strDapAnDuocChon)
            {
                bKQ = true;
                //Cong diem
                int iDiem = int.Parse(lblDiem.Text) + (iCauTiepTheo) * 100;
                lblDiem.Text = iDiem.ToString();
            }

            return bKQ;
        }

        private void btnNhoNguoiThan_Click(object sender, EventArgs e)
        {
            frmTroGiup trogiup = new frmTroGiup();
            trogiup.Show();
            btnNhoNguoiThan.Enabled = false;
        }

        private void tmrDanhSachCauHoi_Tick(object sender, EventArgs e)
        {
            if (bHienDanhSachCauHoi == true)
            {
                if (pnlDanhSachDiem.Left > this.Width - pnlDanhSachDiem.Width)
                {
                    pnlDanhSachDiem.Left = pnlDanhSachDiem.Left - 10;
                }
                else
                {
                    tmrWait.Enabled = true;
                    tmrWait2.Enabled = true;
                }
            }
            else
            {
                tmrWait2.Enabled = false;
                ResetColorDanhSachDiem();
                if (pnlDanhSachDiem.Left < this.Width)
                {
                    pnlDanhSachDiem.Left = pnlDanhSachDiem.Left + 10;
                }
            }
        }
        private void picExit_Click(object sender, EventArgs e)
        {
            frmChucNang cn = new frmChucNang(strUserName);
            cn.Show();
            this.Close();
        }

        private void tmrDapAnDung_Tick(object sender, EventArgs e)
        {
            if (strDapAnDung == "A")
            {
                if (bTrue == false)
                {
                    c = Color.FromArgb(85, 186, 97);
                    picDapAnA.Image = Properties.Resources.DapAn_AC_Dung;
                    lblDapAnA.BackColor = c;
                    lblLuaChonA.BackColor = c;
                    bTrue = true;
                }
                else
                {
                    c = Color.FromArgb(249, 155, 28);
                    lblDapAnA.BackColor = c;
                    lblLuaChonA.BackColor = c;
                    picDapAnA.Image = Properties.Resources.DapAn_AC_DuocChon;
                    bTrue = false;
                }
            }

            if (strDapAnDung == "B")
            {
                if (bTrue == false)
                {
                    c = Color.FromArgb(85, 186, 97);
                    picDapAnB.Image = Properties.Resources.DapAn_BD_Dung;
                    lblDapAnB.BackColor = c;
                    lblLuaChonB.BackColor = c;
                    bTrue = true;
                }
                else
                {
                    c = Color.FromArgb(249, 155, 28);
                    lblDapAnB.BackColor = c;
                    lblLuaChonB.BackColor = c;
                    picDapAnB.Image = Properties.Resources.DapAn_BD_DuocChon;
                    bTrue = false;
                }
            }

            if (strDapAnDung == "C")
            {
                if (bTrue == false)
                {
                    c = Color.FromArgb(85, 186, 97);
                    picDapAnC.Image = Properties.Resources.DapAn_AC_Dung;
                    lblDapAnC.BackColor = c;
                    lblLuaChonC.BackColor = c;
                    bTrue = true;
                }
                else
                {
                    c = Color.FromArgb(249, 155, 28);
                    lblDapAnC.BackColor = c;
                    lblLuaChonC.BackColor = c;
                    picDapAnC.Image = Properties.Resources.DapAn_AC_DuocChon;
                    bTrue = false;
                }
            }

            if (strDapAnDung == "D")
            {
                if (bTrue == false)
                {
                    c = Color.FromArgb(85, 186, 97);
                    picDapAnD.Image = Properties.Resources.DapAn_BD_Dung;
                    lblDapAnD.BackColor = c;
                    lblLuaChonD.BackColor = c;
                    bTrue = true;
                }
                else
                {
                    c = Color.FromArgb(249, 155, 28);
                    lblDapAnD.BackColor = c;
                    lblLuaChonD.BackColor = c;
                    picDapAnD.Image = Properties.Resources.DapAn_BD_DuocChon;
                    bTrue = false;
                }
            }
        }

        public void PlayASound(string strSoundPath)
        {
            wmpSound.URL = strSoundPath;
            wmpSound.Ctlcontrols.play();
        }

        //Ham reset mau
        public void ResetMau()
        {
            c = Color.Black;
            lblDapAnA.BackColor = c;
            lblDapAnB.BackColor = c;
            lblDapAnC.BackColor = c;
            lblDapAnD.BackColor = c;

            lblLuaChonA.BackColor = c;
            lblLuaChonB.BackColor = c;
            lblLuaChonC.BackColor = c;
            lblLuaChonD.BackColor = c;

            Bitmap bAC = Properties.Resources.DapAn_AC;
            Bitmap bBD = Properties.Resources.DapAn_BD;
            picDapAnA.Image = bAC;
            picDapAnB.Image = bBD;
            picDapAnC.Image = bAC;
            picDapAnD.Image = bBD;
        }

        #region Hieu ung MENU

        public void DisableAll(bool Dis)
        {
            if (Dis == true)
            {
                lblDapAnA.Enabled = false;
                lblDapAnB.Enabled = false;
                lblDapAnC.Enabled = false;
                lblDapAnD.Enabled = false;
                lblLuaChonA.Enabled = false;
                lblLuaChonB.Enabled = false;
                lblLuaChonC.Enabled = false;
                lblLuaChonD.Enabled = false;
                picDapAnA.Enabled = false;
                picDapAnB.Enabled = false;
                picDapAnC.Enabled = false;
                picDapAnD.Enabled = false;
            }
            else
            {
                lblDapAnA.Enabled = true;
                lblDapAnB.Enabled = true;
                lblDapAnC.Enabled = true;
                lblDapAnD.Enabled = true;
                lblLuaChonA.Enabled = true;
                lblLuaChonB.Enabled = true;
                lblLuaChonC.Enabled = true;
                lblLuaChonD.Enabled = true;
                picDapAnA.Enabled = true;
                picDapAnB.Enabled = true;
                picDapAnC.Enabled = true;
                picDapAnD.Enabled = true;
            }
        }

        private void DapAnA(object sender, EventArgs e)
        {
            DisableAll(true);
            tmrSuyNghi.Enabled = false;

            ResetMau();
            c = Color.FromArgb(249, 155, 28);
            lblLuaChonA.BackColor = c;
            lblDapAnA.BackColor = c;
            picDapAnA.Image = Properties.Resources.DapAn_AC_DuocChon;
            strDapAnDuocChon = "A";
            strSoundPath = Application.StartupPath + "\\" + "Select.mp3";
            PlayASound(strSoundPath);
            confirm.ShowDialog(this);
        }

        private void DapAnB(object sender, EventArgs e)
        {
            DisableAll(true);
            tmrSuyNghi.Enabled = false;

            ResetMau();
            c = Color.FromArgb(249, 155, 28);
            lblLuaChonB.BackColor = c;
            lblDapAnB.BackColor = c;
            picDapAnB.Image = Properties.Resources.DapAn_BD_DuocChon;
            strDapAnDuocChon = "B";
            strSoundPath = Application.StartupPath + "\\" + "Select.mp3";
            PlayASound(strSoundPath);
            confirm.ShowDialog(this);
        }

        private void DapAnC(object sender, EventArgs e)
        {
            DisableAll(true);
            tmrSuyNghi.Enabled = false;

            ResetMau();
            c = Color.FromArgb(249, 155, 28);
            lblLuaChonC.BackColor = c;
            lblDapAnC.BackColor = c;
            picDapAnC.Image = Properties.Resources.DapAn_AC_DuocChon;
            strDapAnDuocChon = "C";
            strSoundPath = Application.StartupPath + "\\" + "Select.mp3";
            PlayASound(strSoundPath);
            confirm.ShowDialog(this);
        }

        private void DapAnD(object sender, EventArgs e)
        {
            DisableAll(true);
            tmrSuyNghi.Enabled = false;

            ResetMau();
            c = Color.FromArgb(249, 155, 28);
            lblLuaChonD.BackColor = c;
            lblDapAnD.BackColor = c;
            picDapAnD.Image = Properties.Resources.DapAn_BD_DuocChon;
            strDapAnDuocChon = "D";
            strSoundPath = Application.StartupPath + "\\" + "Select.mp3";
            PlayASound(strSoundPath);
            confirm.ShowDialog(this);
        }
        #endregion

        private void tmrWait_Tick(object sender, EventArgs e)
        {
            if (iCauTiepTheo == iTongSoCau - 1)
            {
                frmKetThuc kt = new frmKetThuc(strUserName);
                kt.lblDiem.Text = lblDiem.Text;
                kt.lblThongBao.Text = "CHÚC MỪNG BẠN ĐÃ CHIẾN THẮNG";
                kt.Show();
                this.Close();
                return;
            }

            bHienDanhSachCauHoi = false;
            tmrWait.Enabled = false;
            tmrDapAnDung.Enabled = false;
            LoadCauHoiTiepTheo();

            string strSound = Application.StartupPath + "\\" + "Next.mp3";
            PlayASound(strSound);
            ResetMau();
            DisableAll(false);
        }

        private void tmrWait2_Tick(object sender, EventArgs e)
        {
            string strSound = Application.StartupPath + "\\" + "True.mp3";
            PlayASound(strSound);

            Label lbl = (Label)pnlDanhSachDiem.Controls[iCauTiepTheo - 1];

            if (lbl.BackColor == Color.Orange)
            {
                lbl.BackColor = Color.Green;
            }
            else
            {
                lbl.BackColor = Color.Orange;
            }
        }

        private void ResetColorDanhSachDiem()
        {
            foreach (Label lbl in pnlDanhSachDiem.Controls)
            {
                lbl.BackColor = Color.Orange;
            }
        }

        private void tmrMusic_Tick(object sender, EventArgs e)
        {
            if (wmpPlayer.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                wmpPlayer.URL = Application.StartupPath +"\\" + "BGMusic.mp3";
                wmpPlayer.Ctlcontrols.play();
            }
        }

        private void btnDoiCauHoi_Click(object sender, EventArgs e)
        {
            CauHoiCanTraLoi.RemoveAt(iCauTiepTheo - 1);
            iCauTiepTheo--;
            LoadCauHoiTiepTheo();
            DisableAll(false);
            btnDoiCauHoi.Enabled = false;
        }

        private void btnTraLoi2Lan_Click(object sender, EventArgs e)
        {
            CauHoi ch = (CauHoi)CauHoiCanTraLoi[iCauTiepTheo - 1];
            Random rnd = new Random();
            string strCauNgauNhien = "";
            int iSoCauDaHuy = 0;
            string strCauDaHuy = "";

            while (iSoCauDaHuy != 2)
            {
                int i = rnd.Next(1, 4);

                if (i == 1)
                {
                    strCauNgauNhien = "A";
                }
                else if (i == 2)
                {
                    strCauNgauNhien = "B";
                }
                else if (i == 3)
                {
                    strCauNgauNhien = "C";
                }
                else if (i == 4)
                {
                    strCauNgauNhien = "D";
                }

                if (strCauNgauNhien != ch.DAPANDUNG && strCauDaHuy.IndexOf(strCauNgauNhien) == -1)
                {
                    HuyDapAnX(strCauNgauNhien);
                    iSoCauDaHuy++;
                    strCauDaHuy += strCauNgauNhien;
                }
            }
            btnTraLoi2Lan.Enabled = false;
        }

        private void HuyDapAnX(string strDapAnHuy)
        {
            if (strDapAnHuy == "A")
            {
                lblDapAnA.Enabled = false;
                lblLuaChonA.Enabled = false;
                picDapAnA.Enabled = false;
            }
            else if (strDapAnHuy == "B")
            {
                lblDapAnB.Enabled = false;
                lblLuaChonB.Enabled = false;
                picDapAnB.Enabled = false;
            }
            else if (strDapAnHuy == "C")
            {
                lblDapAnC.Enabled = false;
                lblLuaChonC.Enabled = false;
                picDapAnC.Enabled = false;
            }
            else if (strDapAnHuy == "D")
            {
                lblDapAnD.Enabled = false;
                lblLuaChonD.Enabled = false;
                picDapAnD.Enabled = false;
            }
        }

        private void tmrSuyNghi_Tick(object sender, EventArgs e)
        {
            if (iThoiGian == 0)
            {
                frmKetThuc kt = new frmKetThuc(strUserName);
                int iDiem = int.Parse(lblDiem.Text) / 2;
                kt.lblDiem.Text = iDiem.ToString();
                kt.Show();
                this.Close();
            }
            else
            {
                iThoiGian--;
                lblThoiGian.Text = iThoiGian.ToString();
            }
        }

        private void btnDungChoi_Click(object sender, EventArgs e)
        {
            frmKetThuc kt = new frmKetThuc(strUserName);
            kt.lblDiem.Text = lblDiem.Text;
            kt.Show();
            this.Close();
        }
    }
}