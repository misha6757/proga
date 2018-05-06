using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           

        }

        private void button1_Click(object sender, EventArgs e)
         {
            int a, b, c, d, f, g, k, sum;
            string t = textBox1.Text, y = textBox2.Text, u = textBox3.Text, i = textBox4.Text, o = textBox5.Text, m = textBox6.Text, p = textBox7.Text;
            int.TryParse(t, out a);
            int.TryParse(y, out b);
            int.TryParse(u, out c);
            int.TryParse(i, out d);
            int.TryParse(o, out f);
            int.TryParse(p, out g);
            int.TryParse(m, out k);
            sum = a + b + c + d + f + g + k;
            label1.Text = sum.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double k, faz;
            string sum;
            sum = label1.Text;
            double.TryParse(sum, out k);
            faz = k / 3;
            label2.Text = faz.ToString();



        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a, b, c, d, f, g, k, sum;
            string t = textBox8.Text, y = textBox9.Text, u = textBox10.Text, i = textBox11.Text, o = textBox12.Text, m = textBox13.Text, p = textBox14.Text;
            int.TryParse(t, out a);
            int.TryParse(y, out b);
            int.TryParse(u, out c);
            int.TryParse(i, out d);
            int.TryParse(o, out f);
            int.TryParse(p, out g);
            int.TryParse(m, out k);
            sum = a + b + c + d + f + g + k;
            label3.Text = sum.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a, b, c, d, f, g, k, sum;
            string t = textBox15.Text, y = textBox16.Text, u = textBox17.Text, i = textBox18.Text, o = textBox19.Text, m = textBox20.Text, p = textBox21.Text;
            int.TryParse(t, out a);
            int.TryParse(y, out b);
            int.TryParse(u, out c);
            int.TryParse(i, out d);
            int.TryParse(o, out f);
            int.TryParse(p, out g);
            int.TryParse(m, out k);
            sum = a + b + c + d + f + g + k;
            label4.Text = sum.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a, b, c, d, f, g, k, sum;
            string t = textBox22.Text, y = textBox23.Text, u = textBox24.Text, i = textBox25.Text, o = textBox26.Text, m = textBox27.Text, p = textBox28.Text;
            int.TryParse(t, out a);
            int.TryParse(y, out b);
            int.TryParse(u, out c);
            int.TryParse(i, out d);
            int.TryParse(o, out f);
            int.TryParse(p, out g);
            int.TryParse(m, out k);
            sum = a + b + c + d + f + g + k;
            label5.Text = sum.ToString();
        }
    }
}
