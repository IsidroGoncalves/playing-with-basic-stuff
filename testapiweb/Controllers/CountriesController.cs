using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using testapiweb.Models;

namespace testapiweb.Controllers
{
    public class CountriesController : Controller
    {
        // GET: Countries
        public ActionResult Index()
        {
            return View("GetCountry");
        }

        [HttpPost]
        public ActionResult Getinfo(string countryname)
        {
            var x = new country();
            x = Getinformation(countryname);
            return View("InfoCountry", x);
        }



        public country Getinformation(string countryname)
        {
            var tmp = new country();
            string url = "https://restcountries.eu/rest/v1/name/" + countryname;

            WebClient client = new WebClient();
            dynamic result = JsonConvert.DeserializeObject(client.DownloadString(url));
            dynamic temp = result[0];

            tmp.name = temp.name;
            tmp.capital = temp.capital;
            tmp.population = temp.population;
            tmp.phoneprefix = temp.callingCodes[0];
            tmp.code = temp.alpha3Code;

            return tmp;
        }

      
    }
}