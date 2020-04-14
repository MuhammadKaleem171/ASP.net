using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;

namespace FacbookProject
{
    public partial class Verification : Form
    {
        public string verificationCode;

        public Verification()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        void SendEmail()
        {

            verificationCode = RandomPassword();
               
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient client = new SmtpClient("smtp.gmail.com");
                client.Port = 587;
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = true;
                client.Credentials = new NetworkCredential("facebookproject66@gmail.com", "kFPqtT9qBD9uZzF");
                MailMessage msg = new MailMessage();
                mail.To.Add(Login.emailAddress);
                mail.From = new MailAddress("malikkaleem171@gmail.com");
                mail.Subject = "Verification code";
                mail.Body = "your verification code is: "+verificationCode;
                client.Send(mail);
                MessageBox.Show(" Email sucessfully send");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public string RandomPassword()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4, true));
            builder.Append(RandomNumber());
            return builder.ToString();
        }
        public string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }
        public int RandomNumber()
        {
            Random random = new Random();
            return random.Next(100,9999);
        }

        private void Verification_Load(object sender, EventArgs e)
        {
            SendEmail();
        }
    }
}
