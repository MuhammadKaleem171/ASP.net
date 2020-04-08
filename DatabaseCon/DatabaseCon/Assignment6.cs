using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseCon
{
    public partial class Assignment6 : Form
    {
        public Assignment6()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string item = textBox1.Text;
            listBox1.Items.Add(item);
        }

        private void btnRemovr_Click(object sender, EventArgs e)
        {
            string item = textBox1.Text;

            int c = check(item);
            if(c != -1)
            {
                listBox1.Items.RemoveAt(c);
            }
            else
            {
                MessageBox.Show("not found");
            }
           }
        int check(string item)
        {
            int c = 0; bool f = false;
            foreach (string items in listBox1.Items)
            {
                if (item == items)
                {
                    f = true;
                    break;
                }
                c++;
            }
            if (f == true)
                return c;
            else return -1;
        }

        private void btnSelected_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(index);
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
