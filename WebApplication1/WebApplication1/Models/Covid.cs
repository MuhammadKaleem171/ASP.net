using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Covid
    {
        public Global Global { get; set; }
        public List< Countries> Countries{ get; set; }
    }

    //public class Global
    //{
    //    public string NewConfrimed { get; set; }
    //    public string TotalConfrimed { get; set; }
    //    public string NewDeaths { get; set; }
    //    public string TotalDeths { get; set; }
    //    public string NewRecovered{ get; set; }
    //    public string TotalRecovered { get; set; }

    //}
    //public class Countries
    //{
    //    public string Country { get; set; }
    //    public string CountryCode { get; set; }
    //    public string NewDeaths { get; set; }
    //    public string TotalDeths { get; set; }
    //    public string NewRecovered { get; set; }
    //    public string TotalRecovered { get; set; }
    //}
}