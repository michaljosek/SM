using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace SM.Infrastructure.DTO
{
    public class AdrAdmDTO
    {
        //Identifier
        public int AdrAdmId { get; set; }
        //Pola
        public string id_admi { get; set; }
        public string nazwa { get; set; }
        public string ulica { get; set; }
        public string pna { get; set; }
        public string miasto { get; set; }
        public string kontakt { get; set; }
        public string kierownik { get; set; }
        public string email { get; set; }
        public string inne { get; set; }
        public string uwagi { get; set; }
    }
}