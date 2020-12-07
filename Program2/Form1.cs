using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //Rectangle area
        {
            var height = decimal.Parse(this.textBox1.Text);
            var width = decimal.Parse(this.textBox2.Text);
            var sum = height * width;
            textBoxSum.Text = sum.ToString();

        }

        private void button2_Click(object sender, EventArgs e) //Rectangle perimeter
        {
            var height = decimal.Parse(this.textBox4.Text);
            var width = decimal.Parse(this.textBox5.Text);
            var sum = 2*(height * width);
            textBoxSum2.Text = sum.ToString();

        }

        private void button3_Click(object sender, EventArgs e) //Triangle area
        {
            var height = decimal.Parse(this.textBox9.Text);
            var side = decimal.Parse(this.textBox7.Text);
            var sum = (((height * side)*5)/10);//I cant use double here so I used another way instead 1/2
            textBoxSum3.Text = sum.ToString();
        }

        private void button4_Click(object sender, EventArgs e) //Triangle perimeter
        {
            var side_A = decimal.Parse(this.textBox11.Text);
            var side_B = decimal.Parse(this.textBox10.Text);
            var side_C = decimal.Parse(this.textBox12.Text);
            var sum = side_A + side_B + side_C;
            textBoxSum4.Text = sum.ToString();
        }

        private void button5_Click(object sender, EventArgs e) //Circle area
        {
            var radius = decimal.Parse(this.textBox14.Text);
            var sum = (314*(radius*radius))/100;//The same way instead using double
            textBoxSum5.Text = sum.ToString();
        }

        private void button6_Click(object sender, EventArgs e) //Circle perimeter
        {
            var radius = decimal.Parse(this.textBox16.Text);
            var sum = 2*((314 * radius) / 100);
            textBoxSum6.Text = sum.ToString();
        }
    }
}
