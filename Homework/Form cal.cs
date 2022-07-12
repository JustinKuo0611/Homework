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
    public partial class Cal : Form
    {
        public Cal()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(tx1.Text);
            double num2 = double.Parse(tx2.Text);
            double ans = num1 + num2;
            tx3.Text = ans.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(tx1.Text);
            double num2 = double.Parse(tx2.Text);
            double ans = num1 - num2;
            tx3.Text = ans.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(tx1.Text);
            double num2 = double.Parse(tx2.Text);
            double ans = num1 * num2;
            tx3.Text = ans.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(tx1.Text);
            double num2 = double.Parse(tx2.Text);
            double ans = num1 / num2;
            tx3.Text = ans.ToString();
        }
    }
}
