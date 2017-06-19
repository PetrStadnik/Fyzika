using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fyzika.Models
{
    public class Pyramidka
    {
        
        [Required(ErrorMessage = "Vyplňte pole!")]
        public string V1 { get; set; }
        [Required(ErrorMessage = "Vyplňte pole!")]
        public string V2 { get; set; }
        [Required(ErrorMessage = "Vyplňte pole!")]
        public string V3 { get; set; }

        public int Id { get; set; }
      
        public string Poznamka { get; set; }

        public string Stav { get; set; }
        public List<string> MozneOperace { get; set; }



        public Pyramidka(int id, string nadpis, string podnadpis, string poznamka, string v1, string v2, string v3, string j1, string j2, string j3)
        {
            Id = id;
            //Nadpis = nadpis;
            //Podnadpis = podnadpis;
            Poznamka = poznamka;

            V1 = v1;
            V2 = v2;
            V3 = v3;

            //J1 = j1;
            //J2 = j2;
            //J3 = j3;
        }

        public Pyramidka()
        {
            MozneOperace = new List<string>();
            MozneOperace.Add("Plocha");
            MozneOperace.Add("Povrch");
            MozneOperace.Add("Objem");
        }

        public void PridatDoDatabaze()
        {
            Databaze databaze = new Databaze();
            Stav = databaze.AddPyramidka(V1,V2,V3, Poznamka);
        }
        //public override string ToString()
        //{
        //    return Nadpis;
        //}
    }
}