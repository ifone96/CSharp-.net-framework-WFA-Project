using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace IndexApp
{
    public partial class CalTriangle : Form
    {
        double A, B, C, R, Sin, Area, Result;

        private void CalTriangle_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("คุณต้องการจะออกจากโปรแกรมใช่ไหมนี้?", "Exit!", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        public CalTriangle()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            A = Convert.ToDouble(textBox1.Text);
            B = Convert.ToDouble(textBox2.Text);
            C = Convert.ToDouble(textBox3.Text);

            Area = ((A * B) / 2);
            R = (C * (Math.PI)) / 180;
            Sin = Math.Sin(R);
            Result = Area * Sin;

            textBox4.Text = Result.ToString();
            MessageBox.Show(Result.ToString(), "ผลลัพธ์");
        }
    }
}