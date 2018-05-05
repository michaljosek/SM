using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SM.Infrastructure.DTO
{
    public class AdrUliDTO
    {
        //Identifier
        public int AdrUliId { get; set; }
        //Pola
        public string id_ulic { get; set; }
        public string miasto { get; set; }
        public string nazwa { get; set; }
        public string id_adm { get; set; }
        public string id_osie { get; set; }
    }
}