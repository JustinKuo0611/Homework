using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
        public string money;
        public string year;
        public string rate;
        public string downpay;
        private void button1_Click(object sender, EventArgs e)
        {
            money = money_txt.Text;
            year = year_txt.Text;
            rate = rate_txt.Text;
            downpay = downpay_txt.Text;
            double a1 = double.Parse(money);//貸款金額
            double a2 = double.Parse(year)*12;//年限換成月
            double a3 = double.Parse(downpay);//利率
            double a4 = double.Parse(rate) /100;//頭期款
            double a5 = a4 / 12;
            double a6 = (Math.Pow((1 + a5), a2) *a5) / (Math.Pow((1+ a5), a2) - 1);
            double a7 = a1 - a3;
            double a8 = Math.Floor(a7 * a6);
           
            MessageBox.Show("月付" + a8 + "元");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            money = money_txt.Text;
            year = year_txt.Text;
            rate = rate_txt.Text;
            downpay = downpay_txt.Text;
            double a1 = double.Parse(money);
            double a2 = double.Parse(year) * 12;
            double a3 = double.Parse(downpay);
            double a4 = double.Parse(rate) / 100;
            double a5 = a4 / 12;
            double a6 = (Math.Pow((1 + a5), a2) * a5) / (Math.Pow((1 + a5), a2) - 1);
            double a7 = a1 - a3;
            double a8 = Math.Floor(a7 * a6);
            double a9 = a8 * a2;
            MessageBox.Show(a9.ToString());
        }
    }
}
