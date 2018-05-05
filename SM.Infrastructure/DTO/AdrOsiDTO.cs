using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SM.Infrastructure.DTO
{
    public class AdrOsiDTO
    {
        //Identifier
        public int AdrOsiId { get; set; }
        //Pola
        public string id_osie { get; set; }
        public string miasto { get; set; }
        public string nazwa { get; set; }
        public string id_adm { get; set; }
        public string kod_n { get; set; }
        public string nr_dz { get; set; }

    }
}