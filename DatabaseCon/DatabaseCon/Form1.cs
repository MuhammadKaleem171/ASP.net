using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseCon
{
    public partial class Form1 : Form
    {
        public static  string  [] dateofbirth;
         public  static string firstname, lastname, email;
        public Form1()
        {
            InitializeComponent();
        }
        string constring = @"Data Source=MALIKKALEEM\SQLEXPRESS;Initial Catalog=E-Game;Integrated Security=True";
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //string constring =@"Data Source=MALIKKALEEM\SQLEXPRESS;Initial Catalog=E-Game;Integrated Security=True";
                string q = "Select * from [E-Game].[dbo].[SignUP]";
                SqlConnection con = new SqlConnection(constring);
                SqlCommand cmd = new SqlCommand(q, con);
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        dataGridView1.Rows.Add(sdr[0].ToString(), sdr[1].ToString(), sdr[2].ToString(), sdr[3].ToString(), sdr[4].ToString(),
                            sdr[5].ToString(), sdr[6].ToString(), sdr[7].ToString(), sdr[8].ToString(), sdr[9].ToString());
                    }
                }

                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] li = { "pakistan", "india", "USA", "uk" };
            for (int i=0;i<li.Length;i++)
            CountryList.Items.Add(li[i]);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string DOB = ""; string country = ""; string gender = "";
            if (textBox1.Text == string.Empty)
            {
                textBox1.Focus();
                MessageBox.Show("kindly fill the all field");
            }
            else if (textBox2.Text == string.Empty)
            {
                textBox2.Focus();
                MessageBox.Show("kindly fill the all field");
            }
            else if (textBox2.Text == string.Empty)
            {
                textBox2.Focus();
                MessageBox.Show("kindly fill the all field");
            }
            else if (textBox3.Text == string.Empty)
            {
                textBox3.Focus();
                MessageBox.Show("kindly fill the all field");
            }
            else
            {
                if (male.Checked)
                {
                    gender = "male";
                }
                else if (female.Checked)
                {
                    gender = "female";
                }
                 DOB = dateTimePicker1.Value.ToShortDateString();
                 country = CountryList.SelectedItem.ToString();
                
                
                    try
                    {
                       
                      

                        SqlConnection con = new SqlConnection(constring);
                       
                        string q = "Insert into [E-Game].[dbo].[SignUP](FirstName,LastName,Email,Password,DateOfBirth,Gender,Country,ZipCode) " +
                            "values('"+textBox1.Text+"','"+ textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + DOB+ "','"+gender + "','"  + country + "','" +textBox5.Text+"')";
                        con.Open();
                    SqlCommand cmd = new SqlCommand(q,con);
                    cmd.ExecuteNonQuery();
                        con.Close();
                    }catch(Exception ex)
                    {
                    MessageBox.Show(ex.ToString());
                    }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            firstname = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
             lastname= dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
             email= dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            string d = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            dateofbirth= d.Split('/');
            MessageBox.Show(firstname + lastname + email +" ",dateofbirth[0]+'-'+dateofbirth[1]+'-'+dateofbirth[2]);
                Form2 g = new Form2();
            g.Show();
        }
    }
}
