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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hi! 我是" + textBox1.Text + ",\n 英文名字是"
             + textBox2.Text + ", \n性別為" + comboBox1.Text + ",\n星座是" + comboBox2.Text
             + ",\n很高興認識你 !");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello! 我是" + textBox1.Text + ",\n 英文名字是"
                 + textBox2.Text + ", \n性別為" + comboBox1.Text + ",\n星座是" + comboBox2.Text
                 + ",\n很高興認識你 !");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
