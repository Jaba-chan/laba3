using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba3
{
    public partial class Form1 : Form
    {
        double f(double x)
        {
            return Math.Pow(Math.E, x);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            double y = double.Parse(textBox2.Text);
            double z = double.Parse(textBox3.Text);
            textBox4.Text += Environment.NewLine + "X = " + x.ToString();
            textBox4.Text += Environment.NewLine + "Y = " + y.ToString();
            textBox4.Text += Environment.NewLine + "Z = " + z.ToString();
            double a;
            if (x * y > 0)
            {
                a = Math.Pow(f(x) + y, 2) - Math.Pow(f(x) * y, 1 / 2);
            }
            else if (x * y < 0)
            {
                a = Math.Pow(f(x) + y, 2) + Math.Pow(Math.Abs(f(x) * y), 1 / 2);
            }
            else
            {
                a = Math.Pow(f(x) + y, 2) + 1;
            }
            textBox4.Text += Environment.NewLine + "Значение а = " + a.ToString();
        }
    }
}
