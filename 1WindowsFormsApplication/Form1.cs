using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1WindowsFormsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           // int a = textBox1.Text;
            //int b = Convert.ToInt32(textBox2.Text);

            //label1.Text = textBox1.Text + textBox2.Text;

            double x = 0, x1, x2;
            double.TryParse(textBox1.Text, out x1);
            double.TryParse(textBox2.Text, out x2);
            x = x1 + x2;
            textBox3.Text = "" + x;

            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double x = 0, x1, x2;
            double.TryParse(textBox1.Text, out x1);
            double.TryParse(textBox2.Text, out x2);
            x = x1 / x2;
            textBox3.Text = "" + x;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double x = 0, x1, x2;
            double.TryParse(textBox1.Text, out x1);
            double.TryParse(textBox2.Text, out x2);
            x = x1 - x2;
            textBox3.Text = "" + x;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            double x = 0, x1, x2;
            double.TryParse(textBox1.Text, out x1);
            double.TryParse(textBox2.Text, out x2);
            x = x1 * x2;
            textBox3.Text = "" + x;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            double x = 0, x1, x2;
            double.TryParse(textBox1.Text, out x1);
            //double.TryParse(textBox2.Text, out x2);
            //x = x1 * x2;
            textBox3.Text = "" + Math.Sqrt(x1);
         }

        private void button6_Click(object sender, EventArgs e)
        {
            double x = 0, x1, x2;
            double.TryParse(textBox1.Text, out x1);
            double.TryParse(textBox2.Text, out x2);
            x = Math.Pow(x1, x2);
            textBox3.Text = "" + x;
            
        }
        
        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "" + 0;
            this.ActiveControl = textBox1;


        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var about = new AboutBox1();
            about.Show();
        }

        
    }
}
