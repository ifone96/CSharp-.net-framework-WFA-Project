using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndexApp
{
    public partial class FrmTheater : Form
    {
        int[] seats = new int[8];
        double a;
        private string filename;

        public FrmTheater()
        {
            InitializeComponent();
        }

        private void But0_Click(object sender, EventArgs e)
        {
     
            but0.BackColor = Color.Cyan;
            but0.ForeColor = Color.Black;
            seats[0] = 1;
            if (seats[0] == 1) {
                a = 200;
          
            }
            else
            {
                a = 0;
            }
        }

        private void But1_Click(object sender, EventArgs e)
        {
            but1.BackColor = Color.Cyan;
            but1.ForeColor = Color.Black;
            seats[1] = 1;
            if (seats[1] == 1)
            {
                a = a + 200;

            }
            else { a = a - 200; }

        }

        private void But2_Click(object sender, EventArgs e)
        {
            but2.BackColor = Color.Cyan;
            but2.ForeColor = Color.Black;
            seats[2] = 1;
            if (seats[2] ==1)
            {
                a = a + 200;
            }
        }

        private void But3_Click(object sender, EventArgs e)
        {
            but3.BackColor = Color.Cyan;
            but3.ForeColor = Color.Black;
            seats[3] = 1;
            if (seats[3] == 1)
            {
                a = a + 200;
            }
        }

        private void But4_Click(object sender, EventArgs e)
        {
            but4.BackColor = Color.Cyan;
            but4.ForeColor = Color.Black;
            seats[4] = 1;
            if (seats[4] == 1)
            {
                a = a + 100;
            }
        }

        private void But5_Click(object sender, EventArgs e)
        {
            but5.BackColor = Color.Cyan;
            but5.ForeColor = Color.Black;
            seats[5] = 1;
            if (seats[5] == 1)
            {
                a = a + 100;
            }
        }

        private void But6_Click(object sender, EventArgs e)
        {
            but6.BackColor = Color.Cyan;
            but6.ForeColor = Color.Black;
            seats[6] = 1;
            if (seats[6] == 1)
            {
                a = a + 100;
            }
        }

        private void But7_Click(object sender, EventArgs e)
        {
            but7.BackColor = Color.Cyan;
            but7.ForeColor = Color.Black;
            seats[7] = 1;
            if (seats[7] == 1)
            {
                a = a + 100;
            }
        }

        private void ButSave_Click(object sender, EventArgs e)
        {
            if (txtPrice.Text == "")
            {
                MessageBox.Show("คิดราคาแปป");
                txtPrice.Text = "" + a + "  บาท";
                return;
            }
            if (txtNameMovie.Text == "")
            {
                MessageBox.Show("ระบุชื่อหนังก่อน");
                return;
            }
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.ShowDialog();
            string filename = saveDialog.FileName;
            String data = "";
            String dataa = "";
            for (int i = 0; i < seats.Length; i++)
            {
                data += seats[i].ToString() + ";";
                dataa += seats[i].ToString() + ";";
            }
            data += txtNameMovie.Text;
            dataa += txtPrice.Text;
            FileStream fs = new FileStream(filename, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(data);
            sw.WriteLine(dataa);
            sw.Close();
            txtPrice.Text = "" + a + "  บาท";
            MessageBox.Show("Save Done!");
        }

        private void ButOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.ShowDialog();
            string filename = openDialog.FileName;
            if (filename == "")
                return;
            FileStream fs = new FileStream(filename, FileMode.Open,

            FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string data = sr.ReadLine();
            string dataa = sr.ReadLine();
            sr.Close();
            string[] but = dataa.Split(';');
            string[] buf = data.Split(';');
            txtNameMovie.Text = buf[buf.Length - 1];
            txtPrice.Text = but[but.Length - 1];
            if (buf[0] == "1")
                but0.BackColor = Color.Cyan;
                but0.ForeColor = Color.Black;
            if (buf[1] == "1")
                but1.BackColor = Color.Cyan;
                but1.ForeColor = Color.Black;
            if (buf[2] == "1")
                but2.BackColor = Color.Cyan;
                but2.ForeColor = Color.Black;
            if (buf[3] == "1")
                but3.BackColor = Color.Cyan;
                but3.ForeColor = Color.Black;
            if (buf[4] == "1")
                but4.BackColor = Color.Cyan;
                but4.ForeColor = Color.Black;
            if (buf[5] == "1")
                but5.BackColor = Color.Cyan;
                but5.ForeColor = Color.Black;
            if (buf[6] == "1")
                but6.BackColor = Color.Cyan;
                but6.ForeColor = Color.Black;
            if (buf[7] == "1")
                but7.BackColor = Color.Cyan;
                but7.ForeColor = Color.Black;
        }

        private void ButPrice_Click(object sender, EventArgs e)
        {
            txtPrice.Text = "" + a+"  บาท";
        }

        private void ButClear_Click(object sender, EventArgs e)
        {
            txtNameMovie.Clear();
            txtPrice.Clear();
            a = 0;
            seats[0] = 0;
            if (seats[0] == 0)
            {
                but0.BackColor = Color.Red;
                but0.ForeColor = Color.White;

            }
            seats[1] = 0;
            if (seats[0] == 0)
            {
                but1.BackColor = Color.Red;
                but1.ForeColor = Color.White;

            }
            seats[2] = 0;
            if (seats[2] == 0)
            {
                but2.BackColor = Color.Red;
                but2.ForeColor = Color.White;

            }
            seats[3] = 0;
            if (seats[3] == 0)
            {
                but3.BackColor = Color.Red;
                but3.ForeColor = Color.White;

            }
            seats[4] = 0;
            if (seats[4] == 0)
            {
                but4.BackColor = Color.Blue;
                but4.ForeColor = Color.White;

            }
            seats[5] = 0;
            if (seats[5] == 0)
            {
                but5.BackColor = Color.Blue;
                but5.ForeColor = Color.White;

            }
            seats[6] = 0;
            if (seats[6] == 0)
            {
                but6.BackColor = Color.Blue;
                but6.ForeColor = Color.White;

            }
            seats[7] = 0;
            if (seats[7] == 0)
            {
                but7.BackColor = Color.Blue;
                but7.ForeColor = Color.White;

            }

        }

        private void FrmTheater_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("คุณต้องการจะออกจากโปรแกรมใช่ไหมนี้?", "Exit!", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
