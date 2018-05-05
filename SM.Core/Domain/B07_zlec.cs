using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace SM.Core.Domain
{
    public class B07_zlec
    {
        //Identifier
        public int B07_zlecId { get; set; }
        //Pola
        public string id_admin { get; set; }
        public string numer_zlec { get; set; }
        public string nr_zlec { get; set; }
        public DateTime? data_zlec { get; set; }
        public string nr_prac { get; set; }
        public string nr_rw { get; set; }
        public string nr_zw { get; set; }
        public string wykonawcy { get; set; }
        public string uwagi { get; set; }
        public string uwagi1 { get; set; }
        public string id_oper { get; set; }
        public DateTime? data_oper { get; set; }
        public string blok { get; set; }
        public string nr_magaz { get; set; }
        public string nr_zglo1 { get; set; }
        public string nr_zglo2 { get; set; }
        public string nr_zglo3 { get; set; }
        public string nr_zglo4 { get; set; }
        public string nr_zglo5 { get; set; }
        public string il_godz1 { get; set; }
        public string il_godz2 { get; set; }
        public string il_godz3 { get; set; }
        public string il_godz4 { get; set; }
        public string il_godz5 { get; set; }
        public string nr_prac1 { get; set; }
        public string nr_prac2 { get; set; }
        public string nr_prac3 { get; set; }
        public string nr_prac4 { get; set; }
        public string nr_prac5 { get; set; }
    }
}