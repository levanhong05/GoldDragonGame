using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace TroChoiRongVang
{
    class clsNguoiChoi
    {
        private string m_strMaNguoiDung;
        private string m_TenDangNhap;
        private string m_strMatKhau;

        public string MANGUOIDUNG
        {
            get { return m_strMaNguoiDung; }
            set { m_strMaNguoiDung = value; }
        }
        public string TENDANGNHAP
        {
            get { return m_TenDangNhap; }
            set { m_TenDangNhap = value; }
        }
        public string MATKHAU
        {
            get { return m_strMatKhau; }
            set { m_strMatKhau = value; }
        }
        public clsNguoiChoi()
        {
            m_strMaNguoiDung = "";
            m_TenDangNhap = "";
            m_strMatKhau = "";
        }
        public clsNguoiChoi(string strTenDangNhap, string strMatKhau)
        {
            m_TenDangNhap = strTenDangNhap;
            m_strMatKhau = strMatKhau;
        }

        public bool KiemTraNguoiDung(TruyXuatDulieu txdl)
        {
            bool bKQ = false;
            //true kiem tra thanh cong
            //false kiem tra that bai
            string strSQL = "SELECT * FROM NguoiDung WHERE TenDangNhap = '" + m_TenDangNhap + "' AND MatKhau = '" + m_strMatKhau + "'";
            DataSet dtSet = txdl.TruyVanDuLieu(strSQL, "NguoiDung");
            if (dtSet.Tables["NguoiDung"].Rows.Count > 0)
            {
                bKQ = true;
            }
            return bKQ;
        }
    }
}
