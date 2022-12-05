using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndexApp
{
    public partial class IndexApp : Form
    {
        public IndexApp()
        {
            InitializeComponent();
        }
        private void IndexApp_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("คุณต้องการจะออกจากโปรแกรมใช่ไหมนี้?", "Exit!", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void ExitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CalAreaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalTriangle ca = new CalTriangle();
            ca.Show();
        }

        private void CalBMIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calBMI cBMI = new calBMI();
            cBMI.Show();
        }

        private void StudentBMIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStudentBMI sBMI = new FrmStudentBMI();
            sBMI.Show();
        }

        private void TicketMoviesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTheater theater = new FrmTheater();
            theater.Show();
        }

        private void InternetCafeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInternetCafe IC = new FrmInternetCafe();
            IC.Show();
        }

        private void ScoreBordBasketballToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBSB bsb = new FormBSB();
            bsb.Show();
        }

        private void GoldPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GoldPriceFrm gold = new GoldPriceFrm();
            gold.Show();
        }

    }
}
