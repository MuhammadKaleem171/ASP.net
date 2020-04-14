using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacbookProject
{
   
    public partial class Login : Form
    {
        public static string AccountID { get; set; }
        public  static string U_FirstName { get; set; } 
        public static string U_LastName { get; set; }
        public static string emailAddress { get; set; }
        public static string UserPassword { get; set; }
        public static string DOB { get; set; }
        public string Gender { get; set; }
        bool Chk_email, chk_remail, chk_password;
        public Login()
        {

            InitializeComponent();
            Password.PasswordChar = '*';
            Chk_email = false;
            chk_remail = false;
            chk_password = false;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCrtAcc_Click(object sender, EventArgs e)
        {
            Regex REmail = new Regex(@"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                RegexOptions.IgnoreCase);
             Chk_email = REmail.IsMatch(email.Text);
            if (Chk_email == false)
            {
                MessageBox.Show("incorrect email ");
            }
            else if (email.Text.Equals(rEmail.Text))
            {
                chk_remail = true;
            }
            
            

            Regex Rpassword = new Regex("^[A-Z]{1,10}[a-z]{1,10}[0-9]{1,10}$");
            bool checkPassword= Rpassword.IsMatch(Password.Text);
            else if (Password.Text.Length < 8)
            {
                MessageBox.Show("minimum 8 character required");
            }
            else if (checkPassword == false)
            {
                MessageBox.Show("1st word Capital, 1 small and numerical value required" );
             }
            else
            {
                chk_password = true;
                if (Male.Checked)
                {
                    Gender = "male";
                }
                else if (Female.Checked)
                {
                    Gender = "female";
                }

                emailAddress = email.Text;
                UserPassword = email.Text;
                string[] acId = emailAddress.Split('@');
                AccountID = acId[0];
                U_FirstName = FirstName.Text;
                U_LastName = lastName.Text;
                DOB = dateTimePicker1.Value.ToShortDateString();


                //Verification  v= new Verification();
                //v.Show();
                //this.Hide();
            }
            
            
        }
    }
}
