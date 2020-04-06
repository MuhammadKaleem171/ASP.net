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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (red.Checked == true) {
                this.BackColor = Color.Red;
            }
            else if (blue.Checked == true)
            {
                this.BackColor = Color.Blue;
            }
            else if (green.Checked == true)
            {
                this.BackColor = Color.Green;
            }
            else if (gray.Checked == true)
            {
                this.BackColor = Color.Gray;
            }
          if (black.Checked == true)
            {
                this.ForeColor = Color.Black;
            }
            else if(whiite.Checked == true)
            {
                this.ForeColor = Color.White;
            }
        }
    }
}
