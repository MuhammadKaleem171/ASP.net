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
        public Login()
        {

            InitializeComponent();
            Password.PasswordChar = '*';
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
            bool checkEmail = REmail.IsMatch(email.Text);
            Regex Rpassword = new Regex("^[A-Z]{1,10}[a-z]{1,10}[0-9]{1,10}$");
            bool checkPassword= Rpassword.IsMatch(Password.Text);
            if (Password.Text.Length < 8)
            {
                MessageBox.Show("minimum 8 character required");
            }
            else if (checkPassword == false)
            {
                MessageBox.Show("1st word Capital, 1 small and numerical value required" );
             }
            else
            {
                checkPassword = true;
                label2.Text = checkPassword.ToString();
            }
            
            
        }
    }
}
