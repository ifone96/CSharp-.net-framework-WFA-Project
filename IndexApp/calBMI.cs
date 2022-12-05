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
    public partial class calBMI : Form
    {
        public calBMI()
        {
            InitializeComponent();
        }

        private void ButtonCal_Click(object sender, EventArgs e)
        {
            double h = 0, w =0, r;
            h = double.Parse(textBoxH.Text);
            w = double.Parse(textBoxW.Text);
            r = w/((h/100)*2);
            textBoxR.Text = r.ToString();
            //BMI SECTION
            if (r < 18.5)
            {
                textBoxResult.Text = "ดัชนีมวลกายน้อยกว่า 18.5\r\n" +
                    "คุณมีน้ำหนักน้อยเกินไป ซึ่งอาจจะเกิดจากนักกีฬาที่ออกกำลังกายมาก และได้รับสารอาหารไม่เพียงพอ\r\n" +
                    "วิธีแก้ไข ต้องรับประทารอาหารที่มีคุณภาพ และมีปริมาณพลังงานเพียงพอ และออกกำลังกายอย่างเหมาะสม";
            }
            else if (r >= 18.5 && r <= 22.9)
            {
                textBoxResult.Text = "ดัชนีมวลกายอยู่ระหว่าง 18.5-22.9\r\n" +
                    "คุณมีน้ำหนักปกติและมีปริมาณไขมันอยู่ในเกณฑ์ปกติ มักจะไม่ค่อยมีโรคร้าย อุบัติการณ์ของโรคเบาหวาน\r\n" +
                    "ความดันโลหิตสูง ต่ำกว่าผู้ที่อ้วนกว่านี้";
            }
            else if (r >= 23 && r <= 24.9)
            {
                textBoxResult.Text = "ดัชนีมวลกายอยู่ระหว่าง 23-24.9\r\n" +
                    "คุณเริ่มจะมีน้ำหนักเกิน หากคุณมีกรรมพันธ์เป็นโรคเบาหวานหรือไขมันในเลือดสูง ต้องพยายามลดน้ำหนัก\r\n" +
                    "ให้ดัชนีมวลกายต่ำกว่า 23";
            }
            else if (r >= 25 && r <= 29.9)
            {
                textBoxResult.Text = "ดัชนีมวลกายอยู่ระหว่าง 25-29.9\r\n" +
                    "คุณจัดว่าอ้วนระดับกับ 1 และหากคุณมีเส้นรอบเอวมากกว่า 90ซม. (ชาย) 80ซม. (หญิง) คุณจะมีโอกาศ\r\n" +
                    "เกิดโรค ความดัน เบาหวานสูง จำเป็นต้องควบคุมอาหาร และออกกำลังกาย";
            }
            else
            {
                textBoxResult.Text = "ดัชนีมวลกายมากกว่า 30\r\n" +
                    "คุณจัดว่าอ้วนระดับกับ 2 คุณเสี่ยงต่อการเกิดโรคที่มากับความอ้วน หากตุณมีเส้นรอบเอวมากกว่าเกณฑ์ปกติ\r\n" +
                    "คุณจะเสี่ยงต่อการเกิดโรคสูง คุณต้องควบคุมอาหาร และออกกำลังกายอย่างจริงจัง";
            }
        }

        private void CalBMI_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("คุณต้องการจะออกจากโปรแกรมใช่ไหมนี้?", "Exit!", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
