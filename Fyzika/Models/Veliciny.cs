using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace Fyzika.Models
{
    public class Veliciny
    {
        public string Nazev {get; set;}
        public string Jednotky { get; set;}
        public string Znacka { get; set; }
        
        public Veliciny (string nazev, string jednotky, string znacka)
        {
            Nazev = nazev;
            Jednotky = jednotky;
            Znacka = znacka;
        }

    }
}