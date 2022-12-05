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
    public partial class FormBSB : Form
    {
        System.Timers.Timer t;
        int m = 10, s = 60, a = 0, b = 0, c = 1, fa = 0, fb = 0;
        public FormBSB()
        {
            InitializeComponent();
        }

        private void ButtonScoreA1_Click(object sender, EventArgs e)
        {
            a++;
            if (a >= 999)
            {
                a = 999;
                MessageBox.Show("เกินกำหนด");
            }
            Score1.Text = a.ToString();
        }

        private void ButtonScoreA2_Click(object sender, EventArgs e)
        {
            a--;
            if (a <= 0)
            {
                a = 0;
            }
            Score1.Text = a.ToString();
        }

        private void ButtonScoreA3_Click(object sender, EventArgs e)
        {
            a+=2;
            if (a >= 999)
            {
                a = 999;
                MessageBox.Show("เกินกำหนด");
            }
            Score1.Text = a.ToString();
        }

        private void ButtonScoreA4_Click(object sender, EventArgs e)
        {
            a+=3;
            if (a >= 999)
            {
                a = 999;
                MessageBox.Show("เกินกำหนด");
            }
            Score1.Text = a.ToString();
        }

        private void ButtonScoreB1_Click(object sender, EventArgs e)
        {
            b++;
            if (b >= 999)
            {
                b = 999;
                MessageBox.Show("เกินกำหนด");
            }
            Score2.Text = b.ToString();
        }

        private void ButtonScoreB2_Click(object sender, EventArgs e)
        {
            b--;
            if (b <= 0)
            {
                b = 0;
            }
            Score2.Text = b.ToString();
        }

        private void ButtonScoreB3_Click(object sender, EventArgs e)
        {
            b += 2;
            if (b >= 999)
            {
                b = 999;
                MessageBox.Show("เกินกำหนด");
            }
            Score2.Text = b.ToString();
        }

        private void ButtonScoreB4_Click(object sender, EventArgs e)
        {
            b += 3;
            if (b >= 999)
            {
                b = 999;
                MessageBox.Show("เกินกำหนด");
            }
            Score2.Text = b.ToString();
        }

        private void ButtonQup_Click(object sender, EventArgs e)
        {
            t.Stop();
            c++;//AddQuarter
            if (c > 4)
            {
                c--;
                MessageBox.Show("เกินกำหนด");
            }
            Quarter1234.Text = c.ToString();
            m = 0;
            s = 0;
            if (m == 0)
            {
                m = 10;
            }
            if (s == -1) //WhenTime 00.-1
            {
                s = 0;//SetTime = 00.-1 to 00.00
            }
            TimeALL.Text = string.Format("{0}:{1}", m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
            fa = 0;
            fb = 0;
            labelFoulA.Text = "0";
            labelFoulB.Text = "0";

        }

        private void ButtonQdown_Click(object sender, EventArgs e)
        {
            t.Stop();
            c--;//DownQuarter
            if (c <= 0)
            {
                c++;
                MessageBox.Show("เกินกำหนด");
            }
            Quarter1234.Text = c.ToString();
            m = 0;
            s = 0;
            if (m == 0)
            {
                m = 10;
            }
            if (s == -1)
            {
                s = 0;
            }
            TimeALL.Text = string.Format("{0}:{1}", m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
            fa = 0;
            fb = 0;
            labelFoulA.Text = "0";
            labelFoulB.Text = "0";
        }

        private void FormBSB_Load(object sender, EventArgs e)
        {
            t = new System.Timers.Timer();
            t.Interval = 1000;//1s
            t.Elapsed += OnTimeEvent;
        }

        private void OnTimeEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s -= 1;
                if (s == 0)
                {
                    s = 59;
                    m -= 1;
                }
                else if (m == 10)
                {
                    m -= 1;
                }
                if (m == 0 && s == 1)//Time = 00.01
                {
                    s = 0;//Set Time = 00.01 to 00.00
                    c++;
                    if (c > 4)
                    {
                        c--;
                    }
                    Quarter1234.Text = c.ToString();
                    t.Stop();
                }
                if (s == -1)
                {
                    s = 0;
                }
                TimeALL.Text = string.Format("{0}:{1}", m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));//ShowTimes
            }));
        }

        private void LabelL_Click(object sender, EventArgs e)
        {
            labelL.Text = "<<<";
            labelR.Text = "<<<";
        }

        private void LabelR_Click(object sender, EventArgs e)
        {
            labelL.Text = ">>>";
            labelR.Text = ">>>";
        }

        private void Arrow_Click(object sender, EventArgs e)
        {
            labelL.Text = "<";
            labelR.Text = ">";
        }

        private void ButtonTeamFoulAUp_Click(object sender, EventArgs e)
        {
            t.Stop();
            fa++;//AddTeamFoul
            if (fa > 5)
            {
                fa--;
                MessageBox.Show("เกินกำหนด");
            }
            labelFoulA.Text = fa.ToString();

        }

        private void ButtonTeamFoulADown_Click(object sender, EventArgs e)
        {
            t.Stop();
            fa--;//RemoveTeamFoul
            if (fa < 0)
            {
                fa++;
                MessageBox.Show("เกินกำหนด");
            }
            labelFoulA.Text = fa.ToString();
        }

        private void IamgeB_Click(object sender, EventArgs e)
        {
            String imageLocationB = "";
            try
            {
                // code 
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = " JPG files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocationB = dialog.FileName;
                    iamgeB.ImageLocation = imageLocationB;

                }
            }

            catch (Exception)
            {
                MessageBox.Show("An error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void IamgeA_Click(object sender, EventArgs e)
        {
            String imageLocationA = "";
            try
            {
                // code 
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = " JPG files(.*jpg)|*.jpg| PNG files(.*png)|*.png| All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocationA = dialog.FileName;
                    iamgeA.ImageLocation = imageLocationA;

                }
            }

            catch (Exception)
            {
                MessageBox.Show("An error occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void TimeALL_TextChanged(object sender, EventArgs e)
        {
            m.ToString(TimeALL.Text);
            s.ToString(TimeALL.Text);
            //Form SetTimes = new Form();
            //SetTimes.ShowDialog();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

        }

        private void FormBSB_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("คุณต้องการจะออกจากโปรแกรมใช่ไหมนี้?", "Exit!", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void ButtonTeamFoulBUp_Click(object sender, EventArgs e)
        {
            t.Stop();
            fb++;//AddTeamFoul
            if (fb > 5)
            {
                fb--;
            }
            labelFoulB.Text = fb.ToString();
        }

        private void ButtonTeamFoulBDown_Click(object sender, EventArgs e)
        {
            t.Stop();
            fb--;//RemoveTeamFoul
            if (fb < 0)
            {
                fb++;
            }
            labelFoulB.Text = fb.ToString();
        }

        private void FormBSB_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Stop();
            Application.DoEvents();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            t.Start();
            if (s <= -1 && m <= -1)
            {
                s = 0;
                m = 0;
            }
            
        }

        private void ButtonStop_Click(object sender, EventArgs e)
        {
            t.Stop();
        }

        private void ButtonRestart_Click(object sender, EventArgs e)
        {
            t.Stop();
            m = 0; 
            if (m == 0)
            {
                m = 10;
            }
            s = 0;
            a = 0;
            b = 0;
            c = 1;
            fa = 0;
            fb = 0;
            if (s == -1)
            {
                s = 0;
            }
            TimeALL.Text = string.Format("{0}:{1}", m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
            Quarter1234.Text = c.ToString();
            Score1.Text = a.ToString("000");
            Score2.Text = b.ToString("000");
            labelL.Text = "<";
            labelR.Text = ">";
            labelFoulA.Text = "0";
            labelFoulB.Text = "0";
        }

    }
}
