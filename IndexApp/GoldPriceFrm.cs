using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;


namespace IndexApp
{
    public partial class GoldPriceFrm : Form
    {
        public GoldPriceFrm()
        {
            InitializeComponent();
        }

        private void GoldPriceFrm_Load(object sender, EventArgs e)
        {           
            var web = new WebClient();
            
            //ทองคำแท่ง//ราคารับซื้อ
            string txt = web.DownloadString("https://www.goldtraders.or.th/");
            txt = txt.Substring(txt.IndexOf("DetailPlace_uc_goldprices1_lblBLBuy"),76);
            txt = txt.Remove(0,67);

            //ทองคำแท่ง//ราคาขายอก
            string txt2 = web.DownloadString("https://www.goldtraders.or.th/");
            txt2 = txt2.Substring(txt2.IndexOf("DetailPlace_uc_goldprices1_lblBLSell"),77);
            txt2 = txt2.Remove(0,68);
            
            //ทองรูปพรรณ//ราคารับซื้อ
            string txt3 = web.DownloadString("https://www.goldtraders.or.th/");
            txt3 = txt3.Substring(txt3.IndexOf("DetailPlace_uc_goldprices1_lblOMBuy"),76);
            txt3 = txt3.Remove(0,67);
            
            //ทองรูปพรรณ//ราคาขายอก
            string txt4 = web.DownloadString("https://www.goldtraders.or.th/");
            txt4 = txt4.Substring(txt4.IndexOf("DetailPlace_uc_goldprices1_lblOMSell"),77);
            txt4 = txt4.Remove(0,68);

            textBoxGoldPriceToday.Text =    "ทองคำแท่ง\r" + 
                                            "\nทองราคารับซื้อ : " + txt + " บาท\r" + 
                                            "\nทองราคาขายออก : " + txt2 + " บาท\r" +
                                            "\n\r" +
                                            "\nทองรูปพรรณ\r" +
                                            "\nทองราคารับซื้อ : " + txt3 + " บาท\r" +
                                            "\nทองราคาขายออก : " + txt4 + " บาท";

        }

        private void ButtonCalGold_Click(object sender, EventArgs e)
        {
            var web = new WebClient();
            //ทองคำแท่ง//ราคารับซื้อ
            string txt = web.DownloadString("https://www.goldtraders.or.th/");
            txt = txt.Substring(txt.IndexOf("DetailPlace_uc_goldprices1_lblBLBuy"), 76);
            txt = txt.Remove(0, 67);

            //ทองคำแท่ง//ราคาขายอก
            string txt2 = web.DownloadString("https://www.goldtraders.or.th/");
            txt2 = txt2.Substring(txt2.IndexOf("DetailPlace_uc_goldprices1_lblBLSell"), 77);
            txt2 = txt2.Remove(0, 68);
            
            //ทองรูปพรรณ//ราคารับซื้อ
            string txt3 = web.DownloadString("https://www.goldtraders.or.th/");
            txt3 = txt3.Substring(txt3.IndexOf("DetailPlace_uc_goldprices1_lblOMBuy"), 76);
            txt3 = txt3.Remove(0, 67);

            //ทองรูปพรรณ//ราคาขายอก
            string txt4 = web.DownloadString("https://www.goldtraders.or.th/");
            txt4 = txt4.Substring(txt4.IndexOf("DetailPlace_uc_goldprices1_lblOMSell"), 77);
            txt4 = txt4.Remove(0, 68);

            //คำณวณ
            double w, r, g, r2, g2, r3, g3, r4, g4;
            w = double.Parse(textBoxWeight.Text);
            if (w == 0)
            {
                MessageBox.Show("กรุณากรอกน้ำหนักทอง");
            }
            //
            g = Convert.ToDouble(txt);
            r = w * g;
            //
            g2 = Convert.ToDouble(txt2);
            r2 = w * g2;
            //            
            g3 = Convert.ToDouble(txt3);
            r3 = w * g3;
            //            
            g4 = Convert.ToDouble(txt4);
            r4 = w * g4;

            textBoxResult.Text = "ทองคำแท่ง\r" +
                                 "\nทองราคารับซื้อ : " + r.ToString("##,###.00") + " บาท\r" +
                                 "\nทองราคาขายออก : " + r2.ToString("##,###.00") + " บาท\r" +
                                 "\n\r" +
                                 "\nทองรูปพรรณ\r" +
                                 "\nทองราคารับซื้อ : " + r3.ToString("##,###.00") + " บาท\r" +
                                 "\nทองราคาขายออก : " + r4.ToString("##,###.00") + " บาท";

        }

        private void Label7_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.goldtraders.or.th");
        }

        private void GoldPriceFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("คุณต้องการจะออกจากโปรแกรมใช่ไหมนี้?", "Exit!", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
