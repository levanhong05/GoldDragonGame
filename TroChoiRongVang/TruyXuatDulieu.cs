using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;

namespace TroChoiRongVang
{
    class TruyXuatDulieu
    {
        private string m_strConnectionString;

        public string CONNECTIONSTRING
        {
            get { return m_strConnectionString; }
            set { m_strConnectionString = value; }
        }
        private OleDbConnection m_ODBConnection;

        public OleDbConnection ODBCONNECTION
        {
            get { return m_ODBConnection; }
            set { m_ODBConnection = value; }
        }
        private OleDbDataAdapter m_ODBDataAdapter;

        public OleDbDataAdapter ODBDATAADAPTER
        {
            get { return m_ODBDataAdapter; }
            set { m_ODBDataAdapter = value; }
        }
        private DataSet m_Dataset;

        public DataSet DATASET
        {
            get { return m_Dataset; }
            set { m_Dataset = value; }
        }

        // Truy xuat du lieu
        public TruyXuatDulieu(string strChuoiKetNoi)
        {
            m_strConnectionString = strChuoiKetNoi;
            m_ODBConnection = new OleDbConnection(strChuoiKetNoi);
            m_ODBDataAdapter = new OleDbDataAdapter();
            m_Dataset = new DataSet();
        }

        // Mo ket noi
        public void MoKetNoi()
        {
            if (this.m_ODBConnection.State != ConnectionState.Open)
            {
                try
                {
                    this.m_ODBConnection.Open();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        // Dong ket noi
        public void DongKetNoi()
        {
            if (this.m_ODBConnection.State != ConnectionState.Closed)
            {
                try
                {
                    this.m_ODBConnection.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        // Truy van du lieu
        public DataSet TruyVanDuLieu(string strCauTruyVan, string strBangDuLieu)
        {
            this.m_Dataset = new DataSet();
            this.m_ODBDataAdapter = new OleDbDataAdapter(strCauTruyVan, m_ODBConnection);
            try
            {
                m_ODBDataAdapter.Fill(m_Dataset, strBangDuLieu);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return m_Dataset;
        }
	
        //Ham thao tac co so du lie: them xoa , sua
        //phuong thuc cap nhat du lieu bang cau lenh update, delete, insert
        public bool CapNhatDuLieu(string strUpdateCommand)
        {
            bool bKQ = false;
            //true thanh cong
            //false that bai
            //oledbTransaction mo mot phien giao ta'c moi voi doi tuong m_oledbConnection
            using (OleDbTransaction trans = m_ODBConnection.BeginTransaction())
            {
                OleDbCommand cmPN = new OleDbCommand(strUpdateCommand, m_ODBConnection);
                cmPN.Transaction = trans;
                try
                {
                    int iKQ = cmPN.ExecuteNonQuery();
                    if (iKQ > 0)
                    {
                        bKQ = true;
                    }
                    trans.Commit();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    throw ex;
                }
            }
            return bKQ;
        }
    }
}
