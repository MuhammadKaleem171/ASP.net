using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
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
    }
}
