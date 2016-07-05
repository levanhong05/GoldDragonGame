using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TroChoiRongVang
{
    public partial class HightScore : Form
    {
        public HightScore()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
    }
}