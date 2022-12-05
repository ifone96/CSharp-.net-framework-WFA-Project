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
    public partial class FrmStudentBMI : Form
    {
        Student[] st = new Student[10];
        int count = 0;
        Student[] stc = new Student[10];
        bool sortStatus = false;
        private int j;

        public FrmStudentBMI()
        {
            InitializeComponent();
        }

        private void ButSave_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            double h = Convert.ToDouble(txtHeight.Text);
            double w = Convert.ToDouble(txtWeight.Text);
            s.setData(txtName.Text, (float)h, (float)w);
            st[count++] = s;
            lbCount.Text = "จำนวนนักเรียน " + count + " คน";
        }

        private void ButShow_Click(object sender, EventArgs e)
        {
            string msg = "";
            int i = 0;
                while (i < count)
                {
                    msg += (i + 1) + "\tชื่อ " + st[i].getName() + "\tสูง " +
                    st[i].getHeigh() + "\tน้ำหนัก " + st[i].getWeight() + "\tBMI " + st[i].getBMI() + "\r\n";
                    i++;
                    txtShow.Text = msg;
                }
            }

        private void ButtonShow_Click(object sender, EventArgs e)
        {
            double h = Convert.ToDouble(txtHeight.Text);
            double w = Convert.ToDouble(txtWeight.Text);
            double weight = w;
            double height = h;
            double BMI = weight / ((height / 100) * 2);

            if (BMI < 18.5)
            {
                txtShow.Text = "ดัชนีมวลกายนอยกว่า 18.5";
            }
            else if (BMI > 18.5 & BMI <= 22.9)
            {
                txtShow.Text = "ดัชนีมวลกายอยู่ระหว่าง 18.5-22.9";
            }
            else if (BMI >= 23 & BMI <= 24.9)
            {
                txtShow.Text = "ดัชนีมวลกายอยู่ระหว่าง 23-24.9 ";
            }
            else if (BMI >= 25 & BMI <= 29.9)
            {
                txtShow.Text = "ดัชนีมวลกายอยู่ระหว่าง 25-29.9";
            }
            else if (BMI >= 30)
            {
                txtShow.Text = "ดัชนีมวลกายมากกว่า 30";
            }

        }

        private void ButtonSort_Click(object sender, EventArgs e)
        {
            string msg = "";
            int i = 0;
            while (i < count)
            {
                msg += (i + 1) + "\tชื่อ " + st[i].getName() + "\tสูง " +
                st[i].getHeigh() + "\tน้ำหนัก " + st[i].getWeight() + "\tBMI " + st[i].getBMI() + "\r\n";
                i++;
                txtShow.Text = msg;
            }
            Array.Copy(st, stc, 10);
            if (sortStatus == false)
            {
                for (int a = 0; a < count; a++)
                {
                    for (int j = a + 1; j < count; j++)
                    {
                        double dataSet = Convert.ToDouble(st[a].getBMI());
                        double dataPas = Convert.ToDouble(st[j].getBMI());

                        if (dataSet < dataPas)
                        {
                            Student temp = st[a];
                            st[a] = st[j];
                            st[j] = temp;
                        }
                        sortStatus = true;
                    }

                }

            }
            else
            {
                for (int a = 0; a < count; a++)
                {
                    for (int j = a + 1; j < count; j++)
                    {
                    }
                    if (a > j)
                    {
                        Student temp = st[a];
                        st[a] = st[j];
                        st[j] = temp;
                    }
                    sortStatus = false;
                }
            }
        }

        private void FrmStudentBMI_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("คุณต้องการจะออกจากโปรแกรมใช่ไหมนี้?", "Exit!", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
