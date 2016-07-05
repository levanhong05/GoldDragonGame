using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Collections;

namespace TroChoiRongVang
{
    class CauHoi
    {
        private int m_iMaCauHoi;

        public int MACAUHOI
        {
            get { return m_iMaCauHoi; }
            set { m_iMaCauHoi = value; }
        }

        private string m_strCauHoi;

        private bool bIsLoaded;

        public bool ISLOADED
        {
            get { return bIsLoaded;}
            set { bIsLoaded = value; }
        }

        public string CAUHOI
        {
            get { return m_strCauHoi; }
            set { m_strCauHoi = value; }
        }
        private string m_strDapAnA;

        public string DAPANA
        {
            get { return m_strDapAnA; }
            set { m_strDapAnA = value; }
        }
        private string m_strDapAnB;

        public string DAPANB
        {
            get { return m_strDapAnB; }
            set { m_strDapAnB = value; }
        }
        private string m_strDapAnC;

        public string DAPANC
        {
            get { return m_strDapAnC; }
            set { m_strDapAnC = value; }
        }
        private string m_strDapAnD;

        public string DAPAND
        {
            get { return m_strDapAnD; }
            set { m_strDapAnD = value; }
        }
        private string m_strDapAnDung;

        public string DAPANDUNG
        {
            get { return m_strDapAnDung; }
            set { m_strDapAnDung = value; }
        }
        private string m_strMucDo;

        public string MUCDO
        {
            get { return m_strMucDo; }
            set { m_strMucDo = value; }
        }

        // Phuong thuc khoi tao khong co doi so
        public CauHoi()
        {
            m_iMaCauHoi = -1;
            m_strCauHoi = "";
            m_strDapAnA = "";
            m_strDapAnB = "";
            m_strDapAnC = "";
            m_strDapAnD = "";
            m_strDapAnDung = "";
            m_strMucDo = "";
        }

        //Phuong thuc khoi tao co doi so
        public CauHoi(int macauhoi, string cauhoi, string dapana, string dapanb, string dapanc, string dapand, string dapandung, string mucdo)
        {
            m_iMaCauHoi = macauhoi;
            m_strCauHoi = cauhoi;
            m_strDapAnA = dapana;
            m_strDapAnB = dapanb;
            m_strDapAnC = dapanc;
            m_strDapAnD = dapand;
            m_strDapAnDung = dapandung;
            m_strMucDo = mucdo;
            bIsLoaded = false;
        }
        
        // Lay danh sach cau hoi
        static public ArrayList DanhSachCauHoi(TruyXuatDulieu txdl)
        {
            ArrayList arrKQ = new ArrayList();
            string strSQL = "select * from CauHoi";
            DataSet dtSet = txdl.TruyVanDuLieu(strSQL, "CauHoi");
            DataTable dtTable = dtSet.Tables["CauHoi"];
            try
            {
                foreach (DataRow dtRow in dtTable.Rows)
                {
                    CauHoi ch = new CauHoi();

                    ch.MACAUHOI = int.Parse(dtRow["STT"].ToString());
                    ch.CAUHOI = dtRow["CauHoi"].ToString();
                    ch.DAPANA = dtRow["DapAnA"].ToString();
                    ch.DAPANB = dtRow["DapAnB"].ToString();
                    ch.DAPANC = dtRow["DapAnC"].ToString();
                    ch.DAPAND = dtRow["DapAnD"].ToString();
                    ch.DAPANDUNG = dtRow["DapAnDung"].ToString();
                    ch.MUCDO = dtRow["MucDo"].ToString();
                    arrKQ.Add(ch);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return arrKQ;
        }

        //Load cau hoi theo muc do
        static public ArrayList LayDanhSachCauHoiTheoMucDo(TruyXuatDulieu txdl, string strMucDochoi)
        {
            ArrayList arrKQ = new ArrayList();
            string strSQL = "SELECT * FROM CauHoi WHERE  MucDo = '" + strMucDochoi + "'";
            DataSet dtSet = txdl.TruyVanDuLieu(strSQL,"CauHoi");
            try
            {
                DataTable dtTable = dtSet.Tables["CauHoi"];
                //duyet tung dong du lieu
                foreach (DataRow dtRow in dtTable.Rows)
                {
                    CauHoi ch = new CauHoi();
                    ch.MACAUHOI = int.Parse(dtRow["STT"].ToString());
                    ch.CAUHOI = dtRow["CauHoi"].ToString();
                    ch.DAPANA = dtRow["DapAnA"].ToString();
                    ch.DAPANB = dtRow["DapAnB"].ToString();
                    ch.DAPANC = dtRow["DapAnC"].ToString();
                    ch.DAPAND = dtRow["DapanD"].ToString();
                    ch.DAPANDUNG = dtRow["DapAnDung"].ToString();
                    ch.MUCDO = dtRow["MucDo"].ToString();
                     
                    //them cau hoi vao mang ket qua tra ve
                    arrKQ.Add(ch);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return arrKQ;
        }
        public bool ThemCauhoi(TruyXuatDulieu txdl)
        {
            bool bKQ = false;
            string strSQL = "INSERT INTO CauHoi(STT,CauHoi, DapAnA, DapAnB, DapAnC,DapAnD,DapAnDung,MucDo) VALUES("+this.MACAUHOI + ",'" + this.CAUHOI + "', '" + this.DAPANA + "', '" + this.DAPANB + "', '" + this.DAPANC + "', '" + this.DAPAND + "','" + this.DAPANDUNG + "','"+this.MUCDO+"')";
            bKQ = txdl.CapNhatDuLieu(strSQL);
            return bKQ;
        }
        public bool XoaCauHoi(TruyXuatDulieu txdl)
        {
            bool bKQ = false;
            string strSQL = "DELETE FROM CauHoi WHERE STT = " + this.MACAUHOI;
            bKQ = txdl.CapNhatDuLieu(strSQL);
            return bKQ;
        }
        //Ham cap nhat cau hoi
        public bool CapNhatCauHoi(TruyXuatDulieu txdl)
        {
            bool bKQ = false; //false that bai true thanh cong
            string strSQL = "UPDATE CauHoi SET CauHoi = '" + this.CAUHOI + "', DapAnA = '" + this.DAPANA + "', DapAnB = '" + this.DAPANB + "',DapAnC='"+this.DAPANC+"',DapAnD='"+this.DAPAND+"',DapAnDung='"+this.DAPANDUNG+"' WHERE STT = " + this.MACAUHOI;
            bKQ = txdl.CapNhatDuLieu(strSQL);
            return bKQ;
        }

        //Ham lay ma cau hoi lon nhat
        public int LayMaCauHoiLonNhat(TruyXuatDulieu txdl)
        {
            int iMax = 0;
            string strSQL = "select MAX(STT) as MaSoLonNhat from CauHoi";
            DataSet ds = txdl.TruyVanDuLieu(strSQL, "CauHoi");
            try
            {
                DataTable dtTable = ds.Tables["CauHoi"];
                foreach(DataRow dtRow in dtTable.Rows)
                {
                    iMax = int.Parse(dtRow["MaSoLonNhat"].ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return iMax + 1;
        }
     }
}
