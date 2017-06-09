using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fyzika.Models
{
    public class Pyramidka
    {
        public int Id { get; set; }
        public string Nadpis { get; set; }
        public string Podnadpis { get; set; }
        public string Poznamka { get; set; }

        public string V1 { get; set; }
        public string V2 { get; set; }
        public string V3 { get; set; }

        public string J1 { get; set; }
        public string J2 { get; set; }
        public string J3 { get; set; }

        public Pyramidka(int id, string nadpis, string podnadpis, string poznamka, string v1, string v2, string v3, string j1, string j2, string j3)
        {
            Id = id;
            Nadpis = nadpis;
            Podnadpis = podnadpis;
            Poznamka = poznamka;

            V1 = v1;
            V2 = v2;
            V3 = v3;

            J1 = j1;
            J2 = j2;
            J3 = j3;
        }

        public override string ToString()
        {
            return Nadpis;
        }
    }
}