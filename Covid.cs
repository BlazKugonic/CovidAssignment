using CsvHelper.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CovidAssignment
{
    public class Covid
    {
        [Name("date")]
        public DateTime date { get; set; }
        [Name("regioncecasesactive")]
        public int? regioncecasesactive { get; set; }
        [Name("regioncecasesconfirmedtodate")]
        public int? regioncecasesconfirmedtodate { get; set; }
        [Name("regioncedeceasedtodate")]
        public int? regioncedeceasedtodate { get; set; }
        [Name("regioncevaccinated1sttodate")]
        public int? regioncevaccinated1sttodate { get; set; }
        [Name("regioncevaccinated2ndtodate")]
        public int? regioncevaccinated2ndtodate { get; set; }
        [Name("regionforeigncasesactive")]
        public int? regionforeigncasesactive { get; set; }
        [Name("regionforeigncasesconfirmedtodate")]
        public int? regionforeigncasesconfirmedtodate { get; set; }
        [Name("regionforeigndeceasedtodate")]
        public int? regionforeigndeceasedtodate { get; set; }
        [Name("regionkkcasesactive")]
        public int? regionkkcasesactive { get; set; }
        [Name("regionkkcasesconfirmedtodate")]
        public int? regionkkcasesconfirmedtodate { get; set; }
        [Name("regionkkdeceasedtodate")]
        public int? regionkkdeceasedtodate { get; set; }
        [Name("regionkkvaccinated1sttodate")]
        public int? regionkkvaccinated1sttodate { get; set; }
        [Name("regionkkvaccinated2ndtodate")]
        public int? regionkkvaccinated2ndtodate { get; set; }
        [Name("regionkpcasesactive")]
        public int? regionkpcasesactive { get; set; }
        [Name("regionkpcasesconfirmedtodate")]
        public int? regionkpcasesconfirmedtodate { get; set; }
        [Name("regionkpdeceasedtodate")]
        public int? regionkpdeceasedtodate { get; set; }
        [Name("regionkpvaccinated1sttodate")]
        public int? regionkpvaccinated1sttodate { get; set; }
        [Name("regionkpvaccinated2ndtodate")]
        public int? regionkpvaccinated2ndtodate { get; set; }
        [Name("regionkrcasesactive")]
        public int? regionkrcasesactive { get; set; }
        [Name("regionkrcasesconfirmedtodate")]
        public int? regionkrcasesconfirmedtodate { get; set; }
        [Name("regionkrdeceasedtodate")]
        public int? regionkrdeceasedtodate { get; set; }
        [Name("regionkrvaccinated1sttodate")]
        public int? regionkrvaccinated1sttodate { get; set; }
        [Name("regionkrvaccinated2ndtodate")]
        public int? regionkrvaccinated2ndtodate { get; set; }
        [Name("regionljcasesactive")]
        public int? regionljcasesactive { get; set; }
        [Name("regionljcasesconfirmedtodate")]
        public int? regionljcasesconfirmedtodate { get; set; }
        [Name("regionljdeceasedtodate")]
        public int? regionljdeceasedtodate { get; set; }
        [Name("regionljvaccinated1sttodate")]
        public int? regionljvaccinated1sttodate { get; set; }
        [Name("regionljvaccinated2ndtodate")]
        public int? regionljvaccinated2ndtodate { get; set; }
        [Name("regionmbcasesactive")]
        public int? regionmbcasesactive { get; set; }
        [Name("regionmbcasesconfirmedtodate")]
        public int? regionmbcasesconfirmedtodate { get; set; }
        [Name("regionmbdeceasedtodate")]
        public int? regionmbdeceasedtodate { get; set; }
        [Name("regionmbvaccinated1sttodate")]
        public int? regionmbvaccinated1sttodate { get; set; }
        [Name("regionmbvaccinated2ndtodate")]
        public int? regionmbvaccinated2ndtodate { get; set; }
        [Name("regionmscasesactive")]
        public int? regionmscasesactive { get; set; }
        [Name("regionmscasesconfirmedtodate")]
        public int? regionmscasesconfirmedtodate { get; set; }
        [Name("regionmsdeceasedtodate")]
        public int? regionmsdeceasedtodate { get; set; }
        [Name("regionmsvaccinated1sttodate")]
        public int? regionmsvaccinated1sttodate { get; set; }
        [Name("regionmsvaccinated2ndtodate")]
        public int? regionmsvaccinated2ndtodate { get; set; }
        [Name("regionngcasesactive")]
        public int? regionngcasesactive { get; set; }
        [Name("regionngcasesconfirmedtodate")]
        public int? regionngcasesconfirmedtodate { get; set; }
        [Name("regionngdeceasedtodate")]
        public int? regionngdeceasedtodate { get; set; }
        [Name("regionngvaccinated1sttodate")]
        public int? regionngvaccinated1sttodate { get; set; }
        [Name("regionngvaccinated2ndtodate")]
        public int? regionngvaccinated2ndtodate { get; set; }
        [Name("regionnmcasesactive")]
        public int? regionnmcasesactive { get; set; }
        [Name("regionnmcasesconfirmedtodate")]
        public int? regionnmcasesconfirmedtodate { get; set; }
        [Name("regionnmdeceasedtodate")]
        public int? regionnmdeceasedtodate { get; set; }
        [Name("regionnmvaccinated1sttodate")]
        public int? regionnmvaccinated1sttodate { get; set; }
        [Name("regionnmvaccinated2ndtodate")]
        public int? regionnmvaccinated2ndtodate { get; set; }
        [Name("regionpocasesactive")]
        public int? regionpocasesactive { get; set; }
        [Name("regionpocasesconfirmedtodate")]
        public int? regionpocasesconfirmedtodate { get; set; }
        [Name("regionpodeceasedtodate")]
        public int? regionpodeceasedtodate { get; set; }
        [Name("regionpovaccinated1sttodate")]
        public int? regionpovaccinated1sttodate { get; set; }
        [Name("regionpovaccinated2ndtodate")]
        public int? regionpovaccinated2ndtodate { get; set; }
        [Name("regionsgcasesactive")]
        public int? regionsgcasesactive { get; set; }
        [Name("regionsgcasesconfirmedtodate")]
        public int? regionsgcasesconfirmedtodate { get; set; }
        [Name("regionsgdeceasedtodate")]
        public int? regionsgdeceasedtodate { get; set; }
        [Name("regionsgvaccinated1sttodate")]
        public int? regionsgvaccinated1sttodate { get; set; }
        [Name("regionsgvaccinated2ndtodate")]
        public int? regionsgvaccinated2ndtodate { get; set; }
        [Name("regionunknowncasesactive")]
        public int? regionunknowncasesactive { get; set; }
        [Name("regionunknowncasesconfirmedtodate")]
        public int? regionunknowncasesconfirmedtodate { get; set; }
        [Name("regionunknowndeceasedtodate")]
        public int? regionunknowndeceasedtodate { get; set; }
        [Name("regionzacasesactive")]
        public int? regionzacasesactive { get; set; }
        [Name("regionzacasesconfirmedtodate")]
        public int? regionzacasesconfirmedtodate { get; set; }
        [Name("regionzadeceasedtodate")]
        public int? regionzadeceasedtodate { get; set; }
        [Name("regionzavaccinated1sttodate")]
        public int? regionzavaccinated1sttodate { get; set; }
        [Name("regionzavaccinated2ndtodate")]
        public int? regionzavaccinated2ndtodate { get; set; }

    }
    
}

public class Unknown
        {
        }

        public class Sg
        {
            public int? activeCases { get; set; }
            public int? confirmedToDate { get; set; }
            public int? deceasedToDate { get; set; }
        }

        public class Ce
        {
            public int? activeCases { get; set; }
            public int? confirmedToDate { get; set; }
            public int? deceasedToDate { get; set; }
        }

        public class Kk
        {
            public int? activeCases { get; set; }
            public int? confirmedToDate { get; set; }
            public int? deceasedToDate { get; set; }
        }

        public class Lj
        {
            public int? activeCases { get; set; }
            public int? confirmedToDate { get; set; }
            public int? deceasedToDate { get; set; }
        }

        public class Za
        {
            public int? activeCases { get; set; }
            public int? confirmedToDate { get; set; }
            public int? deceasedToDate { get; set; }
        }

        public class Mb
        {
            public int? activeCases { get; set; }
            public int? confirmedToDate { get; set; }
            public int? deceasedToDate { get; set; }
        }

        public class Kr
        {
            public int? activeCases { get; set; }
            public int? confirmedToDate { get; set; }
            public int? deceasedToDate { get; set; }
        }

        public class Foreign
        {
            public int? activeCases { get; set; }
            public int? confirmedToDate { get; set; }
            public int? deceasedToDate { get; set; }
        }

        public class Ms
        {
            public int? activeCases { get; set; }
            public int? confirmedToDate { get; set; }
            public int? deceasedToDate { get; set; }
        }

        public class Po
        {
            public int? activeCases { get; set; }
            public int? confirmedToDate { get; set; }
            public int? deceasedToDate { get; set; }
        }

        public class Ng
        {
            public int? activeCases { get; set; }
            public int? confirmedToDate { get; set; }
            public int? deceasedToDate { get; set; }
        }

        public class Nm
        {
            public int? activeCases { get; set; }
            public int? confirmedToDate { get; set; }
            public int? deceasedToDate { get; set; }
        }

        public class Kp
        {
            public int? activeCases { get; set; }
            public int? confirmedToDate { get; set; }
            public int? deceasedToDate { get; set; }
        }

        public class Regions
        {
            public Unknown Unknown { get; set; }
            public Sg Sg { get; set; }
            public Ce Ce { get; set; }
            public Kk Kk { get; set; }
            public Lj Lj { get; set; }
            public Za Za { get; set; }
            public Mb Mb { get; set; }
            public Kr Kr { get; set; }
            public Foreign Foreign { get; set; }
            public Ms Ms { get; set; }
            public Po Po { get; set; }
            public Ng Ng { get; set; }
            public Nm Nm { get; set; }
            public Kp Kp { get; set; }
        }

        public class Root
        {
            public int? Year { get; set; }
            public int? Month { get; set; }
            public int? Day { get; set; }
            public Regions Regions { get; set; }
        }

 
