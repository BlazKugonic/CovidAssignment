using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestSharp;
using System.Text.Json;
using System.Net.Http;
using Newtonsoft.Json;
using System.IO;
using CsvHelper;
using Microsoft.VisualBasic.FileIO;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using System.Globalization;
using System.Collections;
using System.Net;

namespace CovidAssignment.Controllers
{


    [ApiController]
    [Route("api")]
    public class CovidController : ControllerBase
    {
        //some simple authentication
        public string user = "covid";
        public string pass = "2021";
        public List<Covid> Getdata()
        {
            //read csv with streamreader, with header
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true,
            };
            using (var reader = new StreamReader(@".\file.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))

            {
                var records = csv.GetRecords<Covid>().ToList();
                return records;
            }


        }
        //better way, get data online, save to csv
        private static void GetDataOnline(string url)
        {
            //Save to file.csv
            System.Net.WebClient client = new WebClient();
            client.DownloadFile(url,"file.csv");

            String path = @".\file.csv";
            List<String> lines = new List<String>();
            //ker so imena v obliki cases.lj.1st ---> spremenimo brez pik
            if (path != "") ; 
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    String line;

                    while ((line = reader.ReadLine()) != null)
                    {
                        if (line.Contains(","))
                        {
                            String[] split = line.Split(',');
                            //odstranitev pik
                            line = line.Replace(".", String.Empty);
                        }
                        lines.Add(line);
                    }
                }
                using (StreamWriter writer = new StreamWriter(path, false))
                {
                    foreach (String line in lines)
                        writer.WriteLine(line);
                }
            }
           
        }
        private readonly ILogger<CovidController> _logger;

        public CovidController(ILogger<CovidController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult MyAction()
        {
            GetDataOnline("https://raw.githubusercontent.com/sledilnik/data/master/csv/region-cases.csv");
            //Getdata();
            return Ok("Welcome to Covid API\n"+
                "available apis:\n" +
                "1. /region/cases (Region, From(01/01/2021), To(02/02/2021, username, password))\n" +
                "2./region/lastweek (username, password)");
        }
        //pridobivanje datuma (yyyy/MM/DD) in regije 
        [HttpGet("region/cases")]
        public IEnumerable Cases(string Region, DateTime From, DateTime To,  string username,string password)
        {
            if (username == user && password == pass)
            {
                List<Covid> covid = Getdata();
                IList<string> Izpis = new List<string>();
                foreach (var x in covid)
                {
                    if (x.date >= From && x.date <= To)
                    {
                        //Region, possible values (LJ, CE, KR, NM, KK, KP, MB, MS, NG, PO, SG, ZA)
                        if (Region == "LJ")
                        {
                            System.Diagnostics.Debug.WriteLine("Date:", x.date);
                            Izpis.Add("Date:" + x.date);
                            System.Diagnostics.Debug.WriteLine("Number of active cases per day: " + x.regionljcasesactive);
                            Izpis.Add("Number of active cases per day: " + x.regionljcasesactive);
                            System.Diagnostics.Debug.WriteLine("Number of vaccinated 1st: " + x.regionljvaccinated1sttodate);
                            Izpis.Add("Number of vaccinated 1st:  " + x.regionljvaccinated1sttodate);
                            System.Diagnostics.Debug.WriteLine("Number of vaccinated 2nd: " + x.regionljvaccinated2ndtodate);
                            Izpis.Add("Number of vaccinated 2nd:  " + x.regionljvaccinated2ndtodate);
                            System.Diagnostics.Debug.WriteLine("Deceased to date: " + x.regionljdeceasedtodate);
                            Izpis.Add("Deceased to date:  " + x.regionljdeceasedtodate);
                        }
                        else if (Region == "CE")
                        {
                            Izpis.Add("Date:" + x.date);
                            Izpis.Add("Number of active cases per day: " + x.regioncecasesactive);
                            Izpis.Add("Number of vaccinated 1st:  " + x.regioncevaccinated1sttodate);
                            Izpis.Add("Number of vaccinated 2nd:  " + x.regioncevaccinated2ndtodate);
                            Izpis.Add("Deceased to date:  " + x.regioncedeceasedtodate);
                        }
                        else if (Region == "KR")
                        {
                            Izpis.Add("Date:" + x.date);
                            Izpis.Add("Number of active cases per day: " + x.regionkrcasesactive);
                            Izpis.Add("Number of vaccinated 1st:  " + x.regionkrvaccinated1sttodate);
                            Izpis.Add("Number of vaccinated 2nd:  " + x.regionkrvaccinated2ndtodate);
                            Izpis.Add("Deceased to date:  " + x.regionkrdeceasedtodate);
                        }
                        else if (Region == "NM")
                        {
                            Izpis.Add("Date:" + x.date);
                            Izpis.Add("Number of active cases per day: " + x.regionnmcasesactive);
                            Izpis.Add("Number of vaccinated 1st:  " + x.regionnmvaccinated1sttodate);
                            Izpis.Add("Number of vaccinated 2nd:  " + x.regionnmvaccinated2ndtodate);
                            Izpis.Add("Deceased to date:  " + x.regionnmdeceasedtodate);
                        }
                        else if (Region == "KK")
                        {
                            Izpis.Add("Date:" + x.date);
                            Izpis.Add("Number of active cases per day: " + x.regionkkcasesactive);
                            Izpis.Add("Number of vaccinated 1st:  " + x.regionkkvaccinated1sttodate);
                            Izpis.Add("Number of vaccinated 2nd:  " + x.regionkkvaccinated2ndtodate);
                            Izpis.Add("Deceased to date:  " + x.regionkkdeceasedtodate);
                        }
                        else if (Region == "KP")
                        {
                            Izpis.Add("Date:" + x.date);
                            Izpis.Add("Number of active cases per day: " + x.regionkpcasesactive);
                            Izpis.Add("Number of vaccinated 1st:  " + x.regionkpvaccinated1sttodate);
                            Izpis.Add("Number of vaccinated 2nd:  " + x.regionkpvaccinated2ndtodate);
                            Izpis.Add("Deceased to date:  " + x.regionkpdeceasedtodate);
                        }
                        else if (Region == "MB")
                        {
                            Izpis.Add("Date:" + x.date);
                            Izpis.Add("Number of active cases per day: " + x.regionmbcasesactive);
                            Izpis.Add("Number of vaccinated 1st:  " + x.regionmbvaccinated1sttodate);
                            Izpis.Add("Number of vaccinated 2nd:  " + x.regionmbvaccinated2ndtodate);
                            Izpis.Add("Deceased to date:  " + x.regionmbdeceasedtodate);
                        }
                        else if (Region == "MS")
                        {
                            Izpis.Add("Date:" + x.date);
                            Izpis.Add("Number of active cases per day: " + x.regionmscasesactive);
                            Izpis.Add("Number of vaccinated 1st:  " + x.regionmsvaccinated1sttodate);
                            Izpis.Add("Number of vaccinated 2nd:  " + x.regionmsvaccinated2ndtodate);
                            Izpis.Add("Deceased to date:  " + x.regionmsdeceasedtodate);
                        }
                        else if (Region == "NG")
                        {
                            Izpis.Add("Date:" + x.date);
                            Izpis.Add("Number of active cases per day: " + x.regionngcasesactive);
                            Izpis.Add("Number of vaccinated 1st:  " + x.regionngvaccinated1sttodate);
                            Izpis.Add("Number of vaccinated 2nd:  " + x.regionngvaccinated2ndtodate);
                            Izpis.Add("Deceased to date:  " + x.regionngdeceasedtodate);
                        }
                        else if (Region == "PO")
                        {
                            Izpis.Add("Date:" + x.date);
                            Izpis.Add("Number of active cases per day: " + x.regionpocasesactive);
                            Izpis.Add("Number of vaccinated 1st:  " + x.regionpovaccinated1sttodate);
                            Izpis.Add("Number of vaccinated 2nd:  " + x.regionpovaccinated2ndtodate);
                            Izpis.Add("Deceased to date:  " + x.regionpodeceasedtodate);
                        }
                        else if (Region == "SG")
                        {
                            Izpis.Add("Date:" + x.date);
                            Izpis.Add("Number of active cases per day: " + x.regionsgcasesactive);
                            Izpis.Add("Number of vaccinated 1st:  " + x.regionsgvaccinated1sttodate);
                            Izpis.Add("Number of vaccinated 2nd:  " + x.regionsgvaccinated2ndtodate);
                            Izpis.Add("Deceased to date:  " + x.regionsgdeceasedtodate);
                        }
                        else if (Region == "ZA")
                        {
                            Izpis.Add("Date:" + x.date);
                            Izpis.Add("Number of active cases per day: " + x.regionzacasesactive);
                            Izpis.Add("Number of vaccinated 1st:  " + x.regionzavaccinated1sttodate);
                            Izpis.Add("Number of vaccinated 2nd:  " + x.regionzavaccinated2ndtodate);
                            Izpis.Add("Deceased to date:  " + x.regionzadeceasedtodate);
                        }
                        else
                        {
                            // Izpis.Add("Ta regija ne obstaja!\n" + "Možne regije LJ, CE, KR, NM, KK, KP, MB, MS, NG, PO, SG, ZA");
                            yield return StatusCode(500, "Ta regija ne obstaja!\n" + "Možne regije LJ, CE, KR, NM, KK, KP, MB, MS, NG, PO, SG, ZA");
                            break;
                        }
                    }
                    else if (From > To)
                    {

                        yield return StatusCode(500, "Datum ni pravilen. Zamenjajte vrsti red");
                        break;
                    }

                }
                yield return Izpis;
            }
            else
            {
                yield return StatusCode(200, "Wrong password or username!");
            }
            
        }
        [HttpGet("region/lastweek")]
        public IEnumerable lastweekcases(string username, string password)
        {
            if (username == user && password == pass)
            {
                List<Covid> covid = Getdata();
                // LJ, CE, KR, NM, KK, KP, MB, MS, NG, PO, SG, ZA"
                int? LJ = 0, CE = 0, KR = 0, NM = 0, KK = 0, KP = 0, MB = 0, MS = 0, NG = 0, PO = 0, SG = 0, ZA = 0;
                List<(string, int?)> Izpis = new List<(string, int?)>();
                List<string> izpis2 = new List<string>();
                //7dnevni seštevek v vsaki regiji
                var LastsevenDays = covid.Skip(Math.Max(0, covid.Count() - 7)).Take(7);
                foreach (var item in LastsevenDays)
                {
                    LJ += item.regionljcasesactive;
                    CE += item.regioncecasesactive;
                    KR += item.regionkrcasesactive;
                    NM += item.regionnmcasesactive;
                    KK += item.regionkkcasesactive;
                    KP += item.regionkpcasesactive;
                    MB += item.regionmbcasesactive;
                    MS += item.regionngcasesactive;
                    PO += item.regionpocasesactive;
                    SG += item.regionsgcasesactive;
                    ZA += item.regionzacasesactive;
                    NG += item.regionngcasesactive;
                   // System.Diagnostics.Debug.WriteLine("LJ število aktivnih ", item.regionljcasesactive);
                }
                //System.Diagnostics.Debug.WriteLine("LJ število aktivnih ", LJ);
                Izpis.Add((" sum of number of active cases LJ:", LJ));
                Izpis.Add(("sum of number of active cases CE:", CE));
                Izpis.Add(("sum of number of active cases KR:", KR));
                Izpis.Add(("sum of number of active cases NM:", NM));
                Izpis.Add(("sum of number of active cases KK:", KK));
                Izpis.Add(("sum of number of active cases KP:", KP));
                Izpis.Add(("sum of number of active cases MB:", MB));
                Izpis.Add(("sum of number of active cases MS:", MS));
                Izpis.Add(("sum of number of active cases PO:", PO));
                Izpis.Add(("sum of number of active cases SG:", SG));
                Izpis.Add(("sum of number of active cases ZA:", ZA));
                Izpis.Add(("sum of number of active cases NG:", NG));
                //padajoče
                var newList = Izpis.OrderByDescending(x => x.Item2).ToList();
                string temp;
                foreach (var i in newList)
                {
                    temp = i.ToString();
                    Console.WriteLine(temp);
                    izpis2.Add(temp);
                }
               yield return izpis2;
            }
            else
            {
               yield return StatusCode(200, "Wrong password or username!");
            }
            
        }
    }
}
