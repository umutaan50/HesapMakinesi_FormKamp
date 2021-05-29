using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi_FormKamp
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;


            textBox1.Text = "0";
            textBox2.Text = "0";

            label1.Visible = true;
            label1.Text = "Kenar 1:";
            label2.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            button5.Visible = true;
            button4.Visible = false; button6.Visible = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;

            textBox1.Text = "0";
            textBox2.Text = "0";

            textBox1.Visible = true;
            label1.Visible = true;
            label1.Text = "Kenar:";
            button4.Visible = true;
            button5.Visible = false; button5.Visible = false;
            label2.Visible = false;
            textBox2.Visible = false;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {

            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;

            textBox1.Text = "0";
            textBox2.Text = "0";

            label1.Text = "Yarıçap:";
            textBox1.Visible = true;
            label1.Visible = true;
            button6.Visible = true;
            button4.Visible = false; button5.Visible = false;
            label2.Visible = false;
            textBox2.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;



            double kenar, alan, cevre;
            kenar = Convert.ToInt32(textBox1.Text);
            cevre = 4 * kenar; alan = kenar * kenar;
            label5.Text = alan.ToString();
            label6.Text = cevre.ToString();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;

            double kenar1, kenar2, alan, cevre;
            kenar1 = Convert.ToInt32(textBox1.Text);
            kenar2 = Convert.ToInt32(textBox2.Text);
            cevre = 2 * (kenar1 + kenar2); alan = kenar1 * kenar2;

            label6.Text = cevre.ToString();
            label5.Text = alan.ToString();
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            double yaricap, alan, cevre;
            yaricap = Convert.ToInt32(textBox1.Text);
            cevre = 2 * 3.14 * yaricap; alan = 3.14 * yaricap * yaricap;
            label5.Text = alan.ToString();
            label6.Text = cevre.ToString();
            

        }
    }
}
