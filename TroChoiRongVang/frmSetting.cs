using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml;

namespace TroChoiRongVang
{
    public partial class frmSetting : Form
    {
        public frmSetting()
        {
            InitializeComponent();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            int iSoCauToiDa = int.Parse(cbxSoCauToiDa.Text);
            int iThoiGianSuyNghi = int.Parse(cbxThoiGianSuyNghi.Text);
            SaveSetting(iSoCauToiDa, iThoiGianSuyNghi);
            btnLuu.Enabled = false;
        }

        public void SaveSetting(int iSoCauToiDa, int iThoiGianSuyNghi)
        {
            string fileName = "Setting.xml";
            //XmlTextWriter xtr = new XmlTextWriter(fileName, Encoding.UTF8);
            //xtr.WriteElementString("SoCauHoiToiDa", iSoCauToiDa.ToString());
            //xtr.WriteElementString("ThoiGianSuyNghi", iThoiGianSuyNghi.ToString());



            XmlWriter writer = null;

            try
            {

                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;
                writer = XmlWriter.Create(fileName, settings);

                writer.WriteComment("//Du lieu tuy chinh tro rong vang");

                writer.WriteStartElement("Data");
                writer.WriteElementString("SoCauHoiToiDa", iSoCauToiDa.ToString());
                writer.WriteElementString("ThoiGianSuyNghi", iThoiGianSuyNghi.ToString());

                writer.Flush();
                writer.Close();
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }

        private void cbxSoCauToiDa_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
        }

        private void cbxThoiGianSuyNghi_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
        }
    }
}