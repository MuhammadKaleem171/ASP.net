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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Mattan karahi half 900");
            comboBox1.Items.Add("Mattan karahi full 1800");
            comboBox1.Items.Add("chicken karahi 500");
            comboBox1.Items.Add("chicken karahi full  1000");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bill = 0;
            
            if (comboBox1.SelectedIndex == 0)
            {
                bill += 900;
                if (checkBox1.Checked == true) {
                    bill += 70;
                    
                }
                if (checkBox2.Checked == true)
                {
                    bill += 70;
                }
                else if(checkBox1.Checked ==true && checkBox2.Checked == true)
                {
                    bill += 140;
                }

                MessageBox.Show(bill.ToString());
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                bill += 1800;
                if (checkBox1.Checked == true)
                {
                    bill += 70;

                }
                if (checkBox2.Checked == true)
                {
                    bill += 70;
                }
                else if (checkBox1.Checked == true && checkBox2.Checked == true)
                {
                    bill += 140;
                }

                MessageBox.Show(bill.ToString());
            }
           else if (comboBox1.SelectedIndex == 2)
            {
                bill += 500;
                if (checkBox1.Checked == true)
                {
                    bill += 70;

                }
                if (checkBox2.Checked == true)
                {
                    bill += 70;
                }
                else if (checkBox1.Checked == true && checkBox2.Checked == true)
                {
                    bill += 140;
                }

                MessageBox.Show(bill.ToString());
            }
        }
    }
}
