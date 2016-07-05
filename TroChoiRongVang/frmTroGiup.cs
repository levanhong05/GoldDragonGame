using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TroChoiRongVang
{
    public partial class frmTroGiup : Form
    {
        public frmTroGiup()
        {
            InitializeComponent();
        }

        private void frmTroGiup_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int a = rnd.Next(0, 100);
            int b = rnd.Next(0, 100 - a);
            int c = rnd.Next(0, 100 - (a + b));
            int d = rnd.Next(0, 100 - (a + b + c));

            progressBarA.Value = a;
            progressBarB.Value = b;
            progressBarC.Value = c;
            progressBarD.Value = d;
        }

        private void Dong_Over(object sender, MouseEventArgs e)
        {
            ResetMau();
            picCo.Image = Properties.Resources.Confirm_Over;
            lblCo.BackColor = Color.FromArgb(249, 155, 28);
            lblCo.ForeColor = Color.White;
        }

        private void ResetMau()
        {
            picCo.Image = Properties.Resources.ConfirmButton;
            lblCo.BackColor = Color.Black;
            lblCo.ForeColor = Color.FromArgb(255, 128, 255);
        }

        private void frmTroGiup_MouseMove(object sender, MouseEventArgs e)
        {
            ResetMau();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            ResetMau();
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            ResetMau();
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            ResetMau();
        }

        private void label4_MouseMove(object sender, MouseEventArgs e)
        {
            ResetMau();
        }

        private void lblCo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picCo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}