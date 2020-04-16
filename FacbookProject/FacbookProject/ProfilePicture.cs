using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacbookProject
{
    public partial class ProfilePicture : Form
    {
        public string fileName { get; set; }

        public ProfilePicture()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            circularProgressBar1.Show();
            for (int i = 0; i <=100; i++)
            {

                Thread.Sleep(40);
                circularProgressBar1.Value = i;
                circularProgressBar1.Text = i.ToString()+"%";
                circularProgressBar1.Update();
            }
            Random r = new Random();

            int random = r.Next();
            string saveDirectory = @"D:\SavedImages\";
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            try

            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if (!Directory.Exists(saveDirectory))
                    {
                        Directory.CreateDirectory(saveDirectory);
                    }
                    float date = DateTime.Today.ToFileTime();

                    string FileName = Path.GetFileName(openFileDialog1.FileName);
                    fileName = Path.Combine(saveDirectory,  + random + FileName);
                    File.Copy(openFileDialog1.FileName, fileName, true);

                    ProfilePictureBox.Image = Image.FromFile(fileName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ProfilePicture_Load(object sender, EventArgs e)
        {
            circularProgressBar1.Maximum = 0;
            circularProgressBar1.Value = 0;
            circularProgressBar1.Maximum = 100;
            circularProgressBar1.Hide();
            
        }
    }
}
