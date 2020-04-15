using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacbookProject
{
    class UserProfie
    {
        public  string AccountID { get; set; }
        public  string U_FirstName { get; set; }
        public  string U_LastName { get; set; }
        public string emailAddress { get; set; }
        public  string UserPassword { get; set; }
        public  string DOB { get; set; }
        public string Gender { get; set; }
       public  bool Chk_email, chk_remail, chk_password;
       public UserProfie()
        {
            Chk_email = false;
            chk_remail = false;
            chk_password = false;
        }
    }
}
