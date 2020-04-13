using System;
using System.Collections;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            IList<Coustomer> us = null;

            HttpClient bh = new HttpClient();
            bh.BaseAddress = new Uri("http://localhost:63007/api/values/");
            var c = bh.GetAsync("GetCoustomer");
            c.Wait();

            var reader = c.Result;
            if (reader.IsSuccessStatusCode)
            {
                var disdata = reader.Content.ReadAsAsync<IList<Coustomer>>();
                disdata.Wait();
                us = disdata.Result;
            }
            return View(us);
        }
        // GET: Home
        [HttpPost]
        public ActionResult Index(string option)
        {
            IList<Coustomer> us = null;

            HttpClient bh = new HttpClient();
            bh.BaseAddress = new Uri("http://localhost:63007/api/values/GetCoustomer");
            var c = bh.GetAsync("GetCoust?option="+ option);
            c.Wait();
            var reader = c.Result;
            if (reader.IsSuccessStatusCode)
            {
                var disdata = reader.Content.ReadAsAsync<IList<Coustomer>>();
                disdata.Wait();
                us = disdata.Result;
            }
            return View(us);
        }

        public ActionResult Details(int id)
        {
            Coustomer us = null;
            HttpClient bh = new HttpClient();
            bh.BaseAddress = new Uri("http://localhost:63007/api/values/");

            var c = bh.GetAsync("GetCoustomer?id=" + id);
            c.Wait();
            var reader = c.Result;
            if (reader.IsSuccessStatusCode)
            {
                var disdata = reader.Content.ReadAsAsync<Coustomer>();
               disdata.Wait();
                us = disdata.Result;
            }
            return View(us);
        }
        public ActionResult Create() {
            return View();
        }
        [HttpPost]
        public ActionResult Create( Coustomer us)
        {
            HttpClient bh = new HttpClient();
            bh.BaseAddress = new Uri("http://localhost:63007/api/values/");

            var insertdata = bh.PostAsJsonAsync("insert", us);
            var sa = insertdata.Result;
            if (sa.IsSuccessStatusCode)
            {
                return RedirectToAction("index");
            }
            return View("Create");
        }

        [HttpGet]
        public ActionResult Search_BY_name(string name)
        {
            IEnumerable<Coustomer> us = null;
            HttpClient bh = new HttpClient();
            bh.BaseAddress = new Uri("http://localhost:63007/api/values/");
            var c = bh.GetAsync("get?name=" + name);
            c.Wait();
            var reader = c.Result;
            if (reader.IsSuccessStatusCode)
            {
                var disdata = reader.Content.ReadAsAsync<IList<Coustomer>>();
                disdata.Wait();
                us = disdata.Result;
            }
            return View(us);
        }

        //[HttpGet]
        //public ActionResult Delete(int id) {
        //    HttpClient bh = new HttpClient();
        //    bh.BaseAddress = new Uri("http://localhost:63007/api/values/");
        //    var c = bh.DeleteAsync("DeleteById?id=" + id.ToString());
        //    c.Wait();
        //    var reader = c.Result;
        //    if (reader.IsSuccessStatusCode)
        //    {
        //        return RedirectToAction("index");
        //    }

        //    return View();
        //}
        [HttpGet]
        public ActionResult Delete(int id)
        {
            Coustomer us = null;
            HttpClient bh = new HttpClient();
            bh.BaseAddress = new Uri("http://localhost:63007/api/values/");
            var c = bh.GetAsync("GetCoustomer?id=" + id);
            c.Wait();
            var reader = c.Result;
            if (reader.IsSuccessStatusCode)
            {
                var disdata = reader.Content.ReadAsAsync<Coustomer>();
                disdata.Wait();
                us = disdata.Result;
            }
            return View(us);
        }
        [HttpPost]
        public ActionResult Delete(Coustomer U)
        {
            Coustomer us = null;

            int id = Int32.Parse(U.RoomNO);
            HttpClient bh = new HttpClient();
            bh.BaseAddress = new Uri("http://localhost:63007/api/values/");
            var c = bh.DeleteAsync("DeleteById?id=" + id.ToString());
            c.Wait();
            var reader = c.Result;
            if (reader.IsSuccessStatusCode)
            {
                return RedirectToAction("index");
            }

            return View();
        }

        public ActionResult weather()
        {
            List<Countries> countries = null;
         ArrayList m = new ArrayList();
            
            var url = "https://api.covid19api.com/summary";
            var syncClient = new WebClient();
           var data=syncClient.DownloadString(url);
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Covid));
            using (var ms = new MemoryStream(Encoding.Unicode.GetBytes(data)))

                      {

                             var weatherData = (Covid)serializer.ReadObject(ms);
                countries = weatherData.Countries;
                                 
                        }
            //countries.Sort();
            return View(countries);
        }
    }
}