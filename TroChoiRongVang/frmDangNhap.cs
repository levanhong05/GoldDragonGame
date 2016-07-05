using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TroChoiRongVang
{
    public partial class frmDangNhap : Form
    {
        private clsNguoiChoi nc;
        private TruyXuatDulieu txdl;

        public frmDangNhap()
        {
            InitializeComponent();
            string strchuoiKetNoi = "provider = microsoft.jet.oledb.4.0; Data source=TroChoirongVang.mdb";
            txdl = new TruyXuatDulieu(strchuoiKetNoi); txdl.MoKetNoi();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            bool bKiemTra = true;
            nc = new clsNguoiChoi(txtTenDangNhap.Text, txtMatKhau.Text);
            if (txtTenDangNhap.Text == "hong" || txtTenDangNhap.Text == "eric")
            {
                bKiemTra = nc.KiemTraNguoiDung(txdl); 
            }

            string strthongBao = "";
            if (bKiemTra == true)
            {
                txdl.DongKetNoi();
                frmChucNang cn = new frmChucNang(txtTenDangNhap.Text);
                cn.ShowDialog(this);
                this.Hide();
            }
            else
            {
                strthongBao = "Đăng nhập thất bại...!";
            }
            lblThongBao.Text = strthongBao.ToString();
        }

        private void txtMatKhau_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bool bKiemTra = true;
                nc = new clsNguoiChoi(txtTenDangNhap.Text, txtMatKhau.Text);

                if (txtTenDangNhap.Text == "hong" || txtTenDangNhap.Text == "eric")
                {
                    bKiemTra = nc.KiemTraNguoiDung(txdl);
                }

                string strthongBao = "";
                if (bKiemTra == true)
                {
                    txdl.DongKetNoi();
                    frmChucNang cn = new frmChucNang(txtTenDangNhap.Text);
                    cn.ShowDialog(this);
                    this.Hide();
                }
                else
                {
                    strthongBao = "Đăng nhập thất bại...!";
                }
                lblThongBao.Text = strthongBao.ToString();
            }
        }

        private void frmDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}