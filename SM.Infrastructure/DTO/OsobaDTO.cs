﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SM.Infrastructure.DTO
{
    public class OsobaDTO
    {
        //Identifier
        public int OsobaId { get; set; }
        //Title
        public string nr_admin { get; set; }
        public string nr_osoby { get; set; }
        public string imie { get; set; }
        public string nazwisko { get; set; }
        public string typ { get; set; }

    }
}