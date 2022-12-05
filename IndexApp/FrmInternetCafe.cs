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
    public partial class FrmInternetCafe : Form
    {
        System.Timers.Timer t1, t2, t3, t4, t5;
        int h1, m1, s1, h2, m2, s2, h3, m3, s3, h4, m4, s4, h5, m5, s5;
        string b = " BATH";

        public FrmInternetCafe()
        {
            InitializeComponent();
        }
        private void FrmInternetCafe_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("คุณต้องการจะออกจากโปรแกรมใช่ไหมนี้?", "Exit!", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void FrmInternetCafe_Load(object sender, EventArgs e)
        {
            //t1
            t1 = new System.Timers.Timer();
            t1.Interval = 1000;//1s
            t1.Elapsed += OnTimeEvent1;
            //t2
            t2 = new System.Timers.Timer();
            t2.Interval = 1000;//1s
            t2.Elapsed += OnTimeEvent2;
            //t3
            t3 = new System.Timers.Timer();
            t3.Interval = 1000;//1s
            t3.Elapsed += OnTimeEvent3;
            //t4
            t4 = new System.Timers.Timer();
            t4.Interval = 1000;//1s
            t4.Elapsed += OnTimeEvent4;
            //t5
            t5 = new System.Timers.Timer();
            t5.Interval = 1000;//1s
            t5.Elapsed += OnTimeEvent5;

        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            Invoke(new Action(() =>
            {
                t1.Stop();
                t2.Stop();
                t3.Stop();
                t4.Stop();
                t5.Stop();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                s1 = 0;
                s2 = 0;
                s3 = 0;
                s4 = 0;
                s5 = 0;
                m1 = 0;
                m2 = 0;
                m3 = 0;
                m4 = 0;
                m5 = 0;
                h1 = 0;
                h2 = 0;
                h3 = 0;
                h4 = 0;
                h5 = 0;
                labelTimeC1.Text = string.Format("{0}:{1}:{2}", h1.ToString().PadLeft(2, '0'), m1.ToString().PadLeft(2, '0'), s1.ToString().PadLeft(2, '0'));
                labelTimeC2.Text = string.Format("{0}:{1}:{2}", h2.ToString().PadLeft(2, '0'), m2.ToString().PadLeft(2, '0'), s2.ToString().PadLeft(2, '0'));
                labelTimeC3.Text = string.Format("{0}:{1}:{2}", h3.ToString().PadLeft(2, '0'), m3.ToString().PadLeft(2, '0'), s3.ToString().PadLeft(2, '0'));
                labelTimeC4.Text = string.Format("{0}:{1}:{2}", h4.ToString().PadLeft(2, '0'), m4.ToString().PadLeft(2, '0'), s4.ToString().PadLeft(2, '0'));
                labelTimeC5.Text = string.Format("{0}:{1}:{2}", h5.ToString().PadLeft(2, '0'), m5.ToString().PadLeft(2, '0'), s5.ToString().PadLeft(2, '0'));
                labelTimeCount1.Text = string.Format("{0}:{1}:{2}", h1.ToString().PadLeft(2, '0'), m1.ToString().PadLeft(2, '0'), s1.ToString().PadLeft(2, '0'));
                labelTimeCount2.Text = string.Format("{0}:{1}:{2}", h2.ToString().PadLeft(2, '0'), m2.ToString().PadLeft(2, '0'), s2.ToString().PadLeft(2, '0'));
                labelTimeCount3.Text = string.Format("{0}:{1}:{2}", h3.ToString().PadLeft(2, '0'), m3.ToString().PadLeft(2, '0'), s3.ToString().PadLeft(2, '0'));
                labelTimeCount4.Text = string.Format("{0}:{1}:{2}", h4.ToString().PadLeft(2, '0'), m4.ToString().PadLeft(2, '0'), s4.ToString().PadLeft(2, '0'));
                labelTimeCount5.Text = string.Format("{0}:{1}:{2}", h5.ToString().PadLeft(2, '0'), m5.ToString().PadLeft(2, '0'), s5.ToString().PadLeft(2, '0'));
            }));
        }

            private void OnTimeEvent1(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s1 += 1;
                if (s1 == 60)
                {
                    s1 = 0;
                    m1 += 1;
                }
                if (m1 == 60)
                {
                    m1 = 0;
                    h1 += 1;
                }   
                labelTimeCount1.Text = string.Format("{0}:{1}:{2}", h1.ToString().PadLeft(2, '0'), m1.ToString().PadLeft(2, '0'), s1.ToString().PadLeft(2, '0'));//ShowTimes
                //price
                if (m1 >= 1 && m1 <= 5 && h1 == 0)
                {
                    textBox1.Clear();
                    textBox1.Text = "5" + b;
                }
                else if (m1 >= 6 && m1 <= 15 && h1 == 0)
                {
                    textBox1.Clear();
                    textBox1.Text = "10"+b;
                }
                else if (m1 >= 16 && m1 <= 30 && h1 == 0)
                {
                    textBox1.Clear();
                    textBox1.Text = "15" + b;
                }
                else if (m1 >= 31 && m1 <= 45 && h1 == 0)
                {
                    textBox1.Clear();
                    textBox1.Text = "20" + b;
                }
                else if (m1 >= 45 && m1 <= 60 && h1 == 0)
                {
                    textBox1.Clear();
                    textBox1.Text = "25" + b;
                }
                else if (h1 >= 1)
                {
                    t1.Stop();
                    MessageBox.Show("หมดเวลาแล้ว", "เครื่องที่ 1", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }));
        }

        private void OnTimeEvent2(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s2 += 1;
                if (s2 == 60)
                {
                    s2 = 0;
                    m2 += 1;
                }
                if (m2 == 60)
                {
                    m2 = 0;
                    h2 += 1;
                }
                labelTimeCount2.Text = string.Format("{0}:{1}:{2}", h2.ToString().PadLeft(2, '0'), m2.ToString().PadLeft(2, '0'), s2.ToString().PadLeft(2, '0'));//ShowTimes
                //price
                if (m2 >= 1 && m2 <= 5 && h2 == 0)
                {
                    textBox2.Clear();
                    textBox2.Text = "5" + b;
                }
                else if (m2 >= 6 && m2 <= 15 && h2 == 0)
                {
                    textBox2.Clear();
                    textBox2.Text = "10" + b;
                }
                else if (m2 >= 16 && m2 <= 30 && h2 == 0)
                {
                    textBox2.Clear();
                    textBox2.Text = "15" + b;
                }
                else if (m2 >= 31 && m2 <= 45 && h2 == 0)
                {
                    textBox2.Clear();
                    textBox2.Text = "20" + b;
                }
                else if (m2 >= 45 && m2 <= 60 && h2 == 0)
                {
                    textBox2.Clear();
                    textBox2.Text = "25" + b;
                }
                else if (h2 >= 1)
                {
                    t2.Stop();
                    MessageBox.Show("หมดเวลาแล้ว", "เครื่องที่ 2", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }));
        }

        private void OnTimeEvent3(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s3 += 1;
                if (s3 == 60)
                {
                    s3 = 0;
                    m3 += 1;
                }
                if (m3 == 60)
                {
                    m3 = 0;
                    h3 += 1;
                }
                labelTimeCount3.Text = string.Format("{0}:{1}:{2}", h3.ToString().PadLeft(2, '0'), m3.ToString().PadLeft(2, '0'), s3.ToString().PadLeft(2, '0'));//ShowTimes
                //price
                if (m3 >= 1 && m3 <= 5 && h3 == 0)
                {
                    textBox3.Clear();
                    textBox3.Text = "5" + b;
                }
                else if (m3 >= 6 && m3 <= 15 && h3 == 0)
                {
                    textBox3.Clear();
                    textBox3.Text = "10" + b;
                }
                else if (m3 >= 16 && m3 <= 30 && h3 == 0)
                {
                    textBox3.Clear();
                    textBox3.Text = "15" + b;
                }
                else if (m3 >= 31 && m3 <= 45 && h3 == 0)
                {
                    textBox3.Clear();
                    textBox3.Text = "20" + b;
                }
                else if (m3 >= 45 && m3 <= 60 && h3 == 0)
                {
                    textBox3.Clear();
                    textBox3.Text = "25" + b;
                }
                else if (h3 >= 1)
                {
                    t3.Stop();
                    MessageBox.Show("หมดเวลาแล้ว", "เครื่องที่ 3", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }));
        }

        private void OnTimeEvent4(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s4 += 1;
                if (s4 == 60)
                {
                    s4 = 0;
                    m4 += 1;
                }
                if (m4 == 60)
                {
                    m4 = 0;
                    h4 += 1;
                }
                labelTimeCount4.Text = string.Format("{0}:{1}:{2}", h4.ToString().PadLeft(2, '0'), m4.ToString().PadLeft(2, '0'), s4.ToString().PadLeft(2, '0'));//ShowTimes
                //price
                if (m4 >= 1 && m4 <= 5 && h4 == 0)
                {
                    textBox4.Clear();
                    textBox4.Text = "5" + b;
                }
                else if (m4 >= 6 && m4 <= 15 && h4 == 0)
                {
                    textBox4.Clear();
                    textBox4.Text = "10" + b;
                }
                else if (m4 >= 16 && m4 <= 30 && h4 == 0)
                {
                    textBox4.Clear();
                    textBox4.Text = "15" + b;
                }
                else if (m4 >= 31 && m4 <= 45 && h4 == 0)
                {
                    textBox4.Clear();
                    textBox4.Text = "20" + b;
                }
                else if (m4 >= 45 && m4 <= 60 && h4 == 0)
                {
                    textBox4.Clear();
                    textBox4.Text = "25" + b;
                }
                else if (h4 >= 1)
                {
                    t4.Stop();
                    MessageBox.Show("หมดเวลาแล้ว", "เครื่องที่ 4", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }));
        }

        private void OnTimeEvent5(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s5 += 1;
                if (s5 == 60)
                {
                    s5 = 0;
                    m5 += 1;
                }
                if (m5 == 60)
                {
                    m5 = 0;
                    h5 += 1;
                }
                labelTimeCount5.Text = string.Format("{0}:{1}:{2}", h5.ToString().PadLeft(2, '0'), m5.ToString().PadLeft(2, '0'), s5.ToString().PadLeft(2, '0'));//ShowTimes
                //price
                if (m5 >= 1 && m5 <= 5 && h5 == 0)
                {
                    textBox5.Clear();
                    textBox5.Text = "5" + b;
                }
                else if (m5 >= 6 && m5 <= 15 && h5 == 0)
                {
                    textBox5.Clear();
                    textBox5.Text = "10" + b;
                }
                else if (m5 >= 16 && m5 <= 30 && h5 == 0)
                {
                    textBox5.Clear();
                    textBox5.Text = "15" + b;
                }
                else if (m5 >= 31 && m5 <= 45 && h5 == 0)
                {
                    textBox5.Clear();
                    textBox5.Text = "20" + b;
                }
                else if (m5 >= 45 && m5 <= 60 && h5 == 0)
                {
                    textBox5.Clear();
                    textBox5.Text = "25" + b;
                }
                else if (h5 >= 1)
                {
                    t5.Stop();
                    MessageBox.Show("หมดเวลาแล้ว", "เครื่องที่ 5", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }));
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            labelTimeCrT.Text = DateTime.Now.ToLongTimeString();
        }

        private void ButtonCheck5_Click(object sender, EventArgs e)
        {
            //Bill
            if (m5 >= 1 && m5 <= 5 && h5 == 0)
            {
                t5.Stop();
                MessageBox.Show("5 บาท", "เครื่องที่ 5", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (m5 >= 6 && m5 <= 15 && h5 == 0)
            {
                t5.Stop();
                MessageBox.Show("10 บาท", "เครื่องที่ 5", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (m5 >= 16 && m5 <= 30 && h5 == 0)
            {
                t5.Stop();
                MessageBox.Show("15 บาท", "เครื่องที่ 5", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (m5 >= 31 && m5 <= 45 && h5 == 0)
            {
                t5.Stop();
                MessageBox.Show("20 บาท", "เครื่องที่ 5", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (m5 >= 45 && m5 <= 60 && h5 == 0)
            {
                t5.Stop();
                MessageBox.Show("25 บาท", "เครื่องที่ 5", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (h5 >= 1)
            {
                t5.Stop();
                MessageBox.Show("25 บาท", "เครื่องที่ 5", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonCheck4_Click(object sender, EventArgs e)
        {
            //Bill
            if (m4 >= 1 && m4 <= 5 && h4 == 0)
            {
                t4.Stop();
                MessageBox.Show("5 บาท", "เครื่องที่ 4", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (m4 >= 6 && m4 <= 15 && h4 == 0)
            {
                t4.Stop();
                MessageBox.Show("10 บาท", "เครื่องที่ 4", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (m4 >= 16 && m4 <= 30 && h4 == 0)
            {
                t4.Stop();
                MessageBox.Show("15 บาท", "เครื่องที่ 4", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (m4 >= 31 && m4 <= 45 && h4 == 0)
            {
                t4.Stop();
                MessageBox.Show("20 บาท", "เครื่องที่ 4", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (m4 >= 45 && m4 <= 60 && h4 == 0)
            {
                t4.Stop();
                MessageBox.Show("25 บาท", "เครื่องที่ 4", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (h4 >= 1)
            {
                t4.Stop();
                MessageBox.Show("25 บาท", "เครื่องที่ 4", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonCheck3_Click(object sender, EventArgs e)
        {
            //Bill
            if (m3 >= 1 && m3 <= 5 && h3 == 0)
            {
                t3.Stop();
                MessageBox.Show("5 บาท", "เครื่องที่ 3", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (m3 >= 6 && m3 <= 15 && h3 == 0)
            {
                t3.Stop();
                MessageBox.Show("10 บาท", "เครื่องที่ 3", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (m3 >= 16 && m3 <= 30 && h3 == 0)
            {
                t3.Stop();
                MessageBox.Show("15 บาท", "เครื่องที่ 3", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (m3 >= 31 && m3 <= 45 && h3 == 0)
            {
                t3.Stop();
                MessageBox.Show("20 บาท", "เครื่องที่ 3", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (m3 >= 45 && m3 <= 60 && h3 == 0)
            {
                t3.Stop();
                MessageBox.Show("25 บาท", "เครื่องที่ 3", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (h3 >= 1)
            {
                t3.Stop();
                MessageBox.Show("25 บาท", "เครื่องที่ 3", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonCheck2_Click(object sender, EventArgs e)
        {
            //Bill
            if (m2 >= 1 && m2 <= 5 && h2 == 0)
            {
                t2.Stop();
                MessageBox.Show("5 บาท", "เครื่องที่ 2", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (m2 >= 6 && m2 <= 15 && h2 == 0)
            {
                t2.Stop();
                MessageBox.Show("10 บาท", "เครื่องที่ 2", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (m2 >= 16 && m2 <= 30 && h2 == 0)
            {
                t2.Stop();
                MessageBox.Show("15 บาท", "เครื่องที่ 2", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (m2 >= 31 && m2 <= 45 && h2 == 0)
            {
                t2.Stop();
                MessageBox.Show("20 บาท", "เครื่องที่ 2", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (m2 >= 45 && m2 <= 60 && h2 == 0)
            {
                t2.Stop();
                MessageBox.Show("25 บาท", "เครื่องที่ 2", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (h2 >= 1)
            {
                t2.Stop();
                MessageBox.Show("25 บาท", "เครื่องที่ 2", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonCheck1_Click(object sender, EventArgs e)
        {
            //Bill
            if (m1 >= 1 && m1 <= 5 && h1 == 0)
            {
                t1.Stop();
                MessageBox.Show("5 บาท", "เครื่องที่ 1", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (m1 >= 6 && m1 <= 15 && h1 == 0)
            {
                t1.Stop();
                MessageBox.Show("10 บาท", "เครื่องที่ 1", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (m1 >= 16 && m1 <= 30 && h1 == 0)
            {
                t1.Stop();
                MessageBox.Show("15 บาท", "เครื่องที่ 1", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (m1 >= 31 && m1 <= 45 && h1 == 0)
            {
                t1.Stop();
                MessageBox.Show("20 บาท", "เครื่องที่ 1", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (m1 >= 45 && m1 <= 60 && h1 == 0)
            {
                t1.Stop();
                MessageBox.Show("25 บาท", "เครื่องที่ 1", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (h1 >= 1)
            {
                t1.Stop();
                MessageBox.Show("25 บาท", "เครื่องที่ 1", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ButtonStop5_Click(object sender, EventArgs e)
        {
            t5.Stop();
        }

        private void ButtonStop4_Click(object sender, EventArgs e)
        {
            t4.Stop();
        }

        private void ButtonStop3_Click(object sender, EventArgs e)
        {
            t3.Stop();
        }

        private void ButtonStop2_Click(object sender, EventArgs e)
        {
            t2.Stop();
        }

        private void ButtonStop1_Click(object sender, EventArgs e)
        {
            t1.Stop();
        }

        private void ButtonStart5_Click(object sender, EventArgs e)
        {
            t5.Start();
            if (h5 == 0 && m5 == 0 && s5 == 0)
            {
                labelTimeC5.Text = DateTime.Now.ToString("HH:mm:ss");
            }
        }

        private void ButtonStart4_Click(object sender, EventArgs e)
        {
            t4.Start();
            if (h4 == 0 && m4 == 0 && s4 == 0)
            {
                labelTimeC4.Text = DateTime.Now.ToString("HH:mm:ss");
            }
        }

        private void ButtonStart3_Click(object sender, EventArgs e)
        {
            t3.Start();
            if (h3 == 0 && m3 == 0 && s3 == 0)
            {
                labelTimeC3.Text = DateTime.Now.ToString("HH:mm:ss");
            }
        }

        private void ButtonStart2_Click(object sender, EventArgs e)
        {
            t2.Start();
            if (h2 == 0 && m2 == 0 && s2 == 0)
            {
                labelTimeC2.Text = DateTime.Now.ToString("HH:mm:ss");
            }
        }

        private void ButtonStart1_Click(object sender, EventArgs e)
        {
            t1.Start();
            if (h1 == 0 && m1 == 0 && s1 == 0)
            {
                labelTimeC1.Text = DateTime.Now.ToString("HH:mm:ss");
            }
        }

    }
}
