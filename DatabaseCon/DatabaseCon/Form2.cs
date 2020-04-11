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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = Form1.firstname;
            textBox2.Text = Form1.lastname;
            textBox3.Text = Form1.email;
            int day = int.Parse(Form1.dateofbirth[0]);
            int month = int.Parse(Form1.dateofbirth[1]);
            int year= int.Parse(Form1.dateofbirth[2]);
            DateTime f = new DateTime(year, month, day);
            dateTimePicker1.Format = DateTimePickerFormat.Long;
            dateTimePicker1.Value = f;


            
            dataGridView1.Rows.Add("ali", "kaleem@gmail.com");
            dataGridView1.Rows.Add("al", "kaleem@gmail.com");
            dataGridView1.Rows.Add("a", "kaleem@gmail.com");
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show((e.RowIndex + 1) + " " + (e.ColumnIndex + 1));
            MessageBox.Show((dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
        }
    }
}
