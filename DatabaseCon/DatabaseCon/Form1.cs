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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string constring =@"Data Source=MALIKKALEEM\SQLEXPRESS;Initial Catalog=E-Game;Integrated Security=True";
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
    }
}
