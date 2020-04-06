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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Bitmap bit = new Bitmap(ofd.FileName);
                pictureBox1.Image = bit;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                // pictureBox1.Size = new System.Drawing.Size(360, 360);
                //Show message in PopUp
                MessageBox.Show(ofd.FileName.ToString());
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)

        {
            ColorDialog clr = new ColorDialog();
            DialogResult re = clr.ShowDialog();
            if (re == DialogResult.OK) {

                this.button1.BackColor = clr.Color;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tableRecord.Rows.Add("fsc", 68.ToString());
            tableRecord.Rows.Add("Bsc", 78.ToString());
            tableRecord.Rows.Add("Msc", 76.ToString());
            tableRecord.Rows.Add("Mphill", 74.ToString());
        }
    }
}
