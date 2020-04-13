using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Countries
    {
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public string NewConfirmed { get; set; }
        public string TotalConfirmed { get; set; }

        public string NewDeaths { get; set; }
        public string TotalDeaths { get; set; }
        public string NewRecovered { get; set; }
        public string TotalRecovered { get; set; }
    }
}