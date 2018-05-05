using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace SM.Core.Domain
{
    public class B07_zglo
    {
        //Identifier
        public int B07_zgloId { get; set; }
        //Pola
        public string id_admin { get; set; }
        public string numer_zglo { get; set; }
        public string id_branz { get; set; }
        public DateTime? data_zglos { get; set; }
        public DateTime? czas_zglos { get; set; }
        public string lp { get; set; }
        public string nazwisko { get; set; }
        public string id_adres { get; set; }
        public string rodzaj_ust { get; set; }
        public string wykon_zewn { get; set; }
        public string wykonawca { get; set; }
        public string numer_zlec { get; set; }
        public DateTime? data_zlec { get; set; }
        public string nr_prac { get; set; }
        public string nr_zlec { get; set; }
        public string czyj_koszt { get; set; }
        public string uwagi_zlec { get; set; }
        public DateTime? data_wykon { get; set; }
        public DateTime? godz_wykon { get; set; }
        public string naleznosc { get; set; }
        public string uwagi1 { get; set; }
        public string opis_wykon { get; set; }
        public string uwagi_wyko { get; set; }
        public string blok { get; set; }
        public string nr_rw { get; set; }
        public string nr_zw { get; set; }
        public string id_oper { get; set; }
        public DateTime? data_oper { get; set; }
        public string inspektor { get; set; }
        public DateTime? data_insp { get; set; }
        public DateTime? data_tere { get; set; }


    }
}