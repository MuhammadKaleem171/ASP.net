using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Coustomer
    {
      
       static string con = ConfigurationManager.ConnectionStrings["WebApplication1.Properties.Settings.ConnectionString"].ConnectionString;
        SqlConnection conn = new SqlConnection(con);
        public String RoomNO { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Cnic { get; set; }

        public String Phone { get; set; }

        public List<Coustomer> GetRecordss(string option)
        {

            List<Coustomer> stlist = new List<Coustomer>();
  
            conn.Open();
            string q = "select * from[AddCustomer].[dbo].[Customer] ORDER BY FirstName" +" "+ option;
            string p = q;
            SqlCommand cmd = new SqlCommand(q, conn);
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {

                Coustomer cs = new Coustomer();
                cs.RoomNO = sdr["RoomNO"].ToString();
                cs.FirstName = sdr["FirstName"].ToString();
                cs.LastName = sdr["LastName"].ToString();
                cs.Cnic = sdr["Cnic"].ToString();
                cs.Phone = sdr["Phone"].ToString();
                stlist.Add(cs);
            }

            return stlist;
        }
        public List<Coustomer> GetRecord()
        {

            List<Coustomer> stlist = new List<Coustomer>();

            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from[AddCustomer].[dbo].[Customer]", conn);
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {

                Coustomer cs = new Coustomer();
                cs.RoomNO = sdr["RoomNO"].ToString();
                cs.FirstName = sdr["FirstName"].ToString();
                cs.LastName = sdr["LastName"].ToString();
                cs.Cnic = sdr["Cnic"].ToString();
                cs.Phone = sdr["Phone"].ToString();
                stlist.Add(cs);
            }

            return stlist;
        }
        public Coustomer show(int id)
        {
            conn.Open();
            string q = "SELECT * FROM [AddCustomer].[dbo].[Customer] WHERE RoomNo =" + "('" + id + "')";

            SqlCommand cmd = new SqlCommand(q, conn);

            SqlDataReader sdr = cmd.ExecuteReader();
            Coustomer cs = new Coustomer();
            sdr.Read();
            cs.RoomNO = sdr["RoomNO"].ToString();
            cs.FirstName = sdr["FirstName"].ToString();
            cs.LastName = sdr["LastName"].ToString();
            cs.Cnic = sdr["Cnic"].ToString();
            cs.Phone = sdr["Phone"].ToString();

            return cs;
        }
        public void insert(Coustomer obj)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Insert into [AddCustomer].[dbo].[Customer] values('" + obj.RoomNO + "','" + obj.FirstName + "','" + obj.LastName + "','" + obj.Cnic
                + "','" + obj.Phone + "')";
            cmd.Connection = conn;

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public List<Coustomer> Search(String SearchString)
        {

            List<Coustomer> stlist = new List<Coustomer>();

            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from[AddCustomer].[dbo].[Customer] WHERE LastName like \'%" + SearchString + "%\'", conn);
            SqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {

                Coustomer cs = new Coustomer();

                cs.RoomNO = sdr["RoomNO"].ToString();
                cs.FirstName = sdr["FirstName"].ToString();
                cs.LastName = sdr["LastName"].ToString();
                cs.Cnic = sdr["Cnic"].ToString();
                cs.Phone = sdr["Phone"].ToString();
                stlist.Add(cs);
            }

            return stlist;
        }

        public void Del(int id) {


            conn.Open();
            SqlCommand cmd = new SqlCommand("delete  from[AddCustomer].[dbo].[Customer] WHERE RoomNo='" +id+"'", conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            conn.Close();
        }
    }
}
