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
    public partial class Grade : Form
    {
        string Name;
        int ChineseScore;
        int EnglishScore;
        int mathScore;
       
        public Grade()
        {
            InitializeComponent();
        }
        public class MyClass
        {
        
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Name = txt1.Text;
            ChineseScore = int.Parse(CH1.Text);
            EnglishScore = int.Parse(EN1.Text);
            mathScore = int.Parse(MT1.Text);
            result="姓名"+Name+"國文"+ChineseScore+"英文"+EnglishScore+"數學"+mathScore;
        }

        string result;
        private void button2_Click(object sender, EventArgs e)
        {

            label6.Text = result;
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
