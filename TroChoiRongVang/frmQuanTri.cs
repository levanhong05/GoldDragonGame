using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace TroChoiRongVang
{
    public partial class frmQuanTri : Form
    {
        ArrayList arrDSCH;
        string strUserName;

        TruyXuatDulieu txdl;
        public frmQuanTri(string uname)
        {
            InitializeComponent();
            string strChuoiKetNoi = "provider=microsoft.jet.oledb.4.0;data source=TroChoiRongVang.mdb";
            txdl = new TruyXuatDulieu(strChuoiKetNoi);
            txdl.MoKetNoi();
            strUserName = uname;
        }

        private void cmbChonMucDoChoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            //xoa danh sach trong lbxDanhSachCauhoi
            lbxDanhSachCauHoi.Items.Clear();
            //hien thi dsch trong lbxDanhSachcauhoi
            if (cmbChonMucDoChoi.SelectedItem.ToString() != "")
            {
                arrDSCH = CauHoi.LayDanhSachCauHoiTheoMucDo(txdl, cmbChonMucDoChoi.SelectedItem.ToString());
            }
            foreach (CauHoi ch in arrDSCH)
            {
                lbxDanhSachCauHoi.Items.Add(ch.CAUHOI);
            }
        }

        private void lbxDanhSachCauHoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            txtNoiDungCauHoi.Enabled = false;
            txtDapAnA.Enabled = false;
            txtDapAnB.Enabled = false;
            txtDapAnC.Enabled = false;
            txtDapAnD.Enabled = false;
            //hien thi thong tin cau hoi trong listbox cau hoi ra control tuong ung
            string strCauHoiDuocChon = lbxDanhSachCauHoi.SelectedItem.ToString();
            foreach (CauHoi ch in arrDSCH)
            {
                if (ch.CAUHOI == strCauHoiDuocChon)
                {
                    txtMaCauHoi.Text = ch.MACAUHOI.ToString();
                    txtNoiDungCauHoi.Text = ch.CAUHOI;
                    txtDapAnA.Text = ch.DAPANA;
                    txtDapAnB.Text = ch.DAPANB;
                    txtDapAnC.Text = ch.DAPANC;
                    txtDapAnD.Text = ch.DAPAND;
                    comboBoxDapAnDung.Text = ch.DAPANDUNG;
                    comboBoxMucDoChoi.Text = ch.MUCDO;
                    comboBoxDapAnDung.Enabled = false;
                    comboBoxMucDoChoi.Enabled = false;
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (this.btnSua.Text == "Sửa")
            {
                btnXoa.Enabled = false;
                btnThem.Enabled = false;
                comboBoxDapAnDung.Enabled = true;
                txtNoiDungCauHoi.Enabled = true;
                txtDapAnA.Enabled = true;
                txtDapAnB.Enabled = true;
                txtDapAnC.Enabled = true;
                txtDapAnD.Enabled = true;
                btnSua.Text = "Lưu";
            }
            else
            {
                btnXoa.Enabled = true;
                btnThem.Enabled = true;
                lbxDanhSachCauHoi.Enabled = true;
                foreach (CauHoi ch in arrDSCH)
                {
                    if (ch.MACAUHOI.ToString() == txtMaCauHoi.Text)
                    {
                        ch.CAUHOI = txtNoiDungCauHoi.Text;
                        ch.DAPANA = txtDapAnA.Text;
                        ch.DAPANB = txtDapAnB.Text;
                        ch.DAPANC = txtDapAnC.Text;
                        ch.DAPAND = txtDapAnD.Text;
                        ch.DAPANDUNG = comboBoxDapAnDung.Text;
                        btnSua.Text = "Sửa";
                        bool bKQ = ch.CapNhatCauHoi(txdl);
                        if (bKQ == true)
                        {
                            MessageBox.Show("Cập nhật thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thất bại!");
                        }
                    }
                }
                cmbChonMucDoChoi_SelectedIndexChanged(sender, e);
            }
        }

        private void frmQuanTri_Load(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (CauHoi ch in arrDSCH)
                {
                    if (ch.MACAUHOI.ToString() == txtMaCauHoi.Text)
                    {
                        bool bKQ = ch.XoaCauHoi(txdl);
                        if (bKQ == true)
                        {
                            MessageBox.Show("Xóa thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Xóa thất bại!");
                        }
                    }
                }
                cmbChonMucDoChoi_SelectedIndexChanged(sender, e);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                lbxDanhSachCauHoi.Enabled = false;
                CauHoi ch = new CauHoi();
                if (btnThem.Text == "Thêm")
                {
                    comboBoxDapAnDung.Enabled = true;
                    comboBoxMucDoChoi.Enabled = true;
                    txtNoiDungCauHoi.Enabled = true;
                    txtDapAnA.Enabled = true;
                    txtDapAnB.Enabled = true;
                    txtDapAnC.Enabled = true;
                    txtDapAnD.Enabled = true;
                    btnThem.Text = "Lưu";
                    btnSua.Enabled = false;
                    btnXoa.Enabled = false;
                    txtMaCauHoi.Text = ch.LayMaCauHoiLonNhat(txdl).ToString();
                    txtNoiDungCauHoi.Text = "";
                    txtDapAnA.Text = "";
                    txtDapAnB.Text = "";
                    txtDapAnC.Text = "";
                    txtDapAnD.Text = "";
                    comboBoxDapAnDung.Text = "Chọn...";
                    comboBoxMucDoChoi.Text = "Chọn...";
                }
                else
                {
                    btnThem.Text = "Thêm";
                    if (txtNoiDungCauHoi.Text != "" && txtDapAnA.Text != "" && txtDapAnB.Text != "" && txtDapAnC.Text != "" && txtDapAnD.Text != "" && comboBoxDapAnDung.Text != "Chon..." && comboBoxMucDoChoi.Text != "Chon...")
                    {
                        ch.MACAUHOI = int.Parse(txtMaCauHoi.Text);
                        ch.CAUHOI = txtNoiDungCauHoi.Text;
                        ch.DAPANA = txtDapAnA.Text;
                        ch.DAPANB = txtDapAnB.Text;
                        ch.DAPANC = txtDapAnC.Text;
                        ch.DAPAND = txtDapAnD.Text;
                        ch.DAPANDUNG = comboBoxDapAnDung.Text;
                        ch.MUCDO = comboBoxMucDoChoi.Text;
                        btnSua.Enabled = true;
                        btnXoa.Enabled = true;
                        lbxDanhSachCauHoi.Enabled = true;
                        lbxDanhSachCauHoi.Enabled = true;
                        bool bKQ = ch.ThemCauhoi(txdl);
                        if (bKQ == true)
                        {
                            MessageBox.Show("Thêm thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Thêm thất bại!");
                        }
                        arrDSCH.Add(ch);
                        //Load lai cau hoi vua them vao
                        lbxDanhSachCauHoi.Items.Clear();
                        foreach (CauHoi cauhoi in arrDSCH)
                        {
                            lbxDanhSachCauHoi.Items.Add(cauhoi.CAUHOI);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ các trường");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void frmQuanTri_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmChucNang cn = new frmChucNang(strUserName);
            cn.Show();
        }
    }
}