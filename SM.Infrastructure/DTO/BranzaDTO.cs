using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SM.Infrastructure.DTO
{
    public class BranzaDTO
    {
        //Identifier
         public int BranzaId { get; set; }
        //Title
        public string nazwa_bran { get; set; }
        public string nr_branzy { get; set; }
    }
}