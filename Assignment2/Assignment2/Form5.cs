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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Gender = "";

            if (radioButton1.Checked == true)
            {
                Gender = "male";
            }
            else if (radioButton2.Checked == true)
            {
                Gender = "female";
            }
            if ((Name.Text != string.Empty) && (Percentage.Text != string.Empty) && (Contact.Text != string.Empty) &&
                (Gender != string.Empty))
            {
                Record.Rows.Add(base.Name.Text, Percentage.Text, Contact.Text, Gender);
            }
            else
            {
                MessageBox.Show("Plz fill the form");
            }

        }
    }
}
