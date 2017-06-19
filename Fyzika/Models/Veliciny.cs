using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.ComponentModel.DataAnnotations;

namespace Fyzika.Models
{
    public class Veliciny
    {
       
        public int Id { get; set; }
        [Required(ErrorMessage = "Vyplňte pole!")]
        public string Nazev {get; set;}
        [Required(ErrorMessage = "Vyplňte pole!")]
        public string Jednotky { get; set;}
        [Required(ErrorMessage = "Vyplňte pole!")]
        public string Znacka { get; set; }

        public string Stav { get; set; }

        public Veliciny (int id, string nazev, string jednotky, string znacka)
        {
            Id = id;
            Nazev = nazev;
            Jednotky = jednotky;
            Znacka = znacka;
        }
        public Veliciny()
        {
           
        }

        public void PridatDoDatabaze()
        {
            Databaze databaze = new Databaze();
            Stav = databaze.AddVelicina(Nazev, Jednotky, Znacka);
        }




    }
}

