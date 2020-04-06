using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tmp = int.Parse(textBox1.Text);
            if (rbtn1.Checked == true)
            {
                 tmp=(tmp* 9 / 5) + 32;
                textBox2.Text = tmp.ToString();
            }
            else if (rbtn2.Checked == true)
            {
                tmp = (tmp-32)*5/9;
                textBox2.Text = tmp.ToString();

            }

            else
            {
                MessageBox.Show("plz select temp type");
            }
        }
    }
}
