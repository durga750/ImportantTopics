using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            label3.Text = "Sum is" + new ServiceReference1.WebService1SoapClient().Sum(a, b).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            label3.Text = "Sub is" + new ServiceReference1.WebService1SoapClient().Sub(a, b).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            label3.Text = "Mul is" + new ServiceReference1.WebService1SoapClient().Mul(a, b).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            label3.Text = "Div is" + new ServiceReference1.WebService1SoapClient().Div(a, b).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            label3.Text = "Modl is" + new ServiceReference1.WebService1SoapClient().Modl(a, b).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label3.Text = new ServiceReference1.WebService1SoapClient().HelloWorld().ToString();
        }
    }
}
