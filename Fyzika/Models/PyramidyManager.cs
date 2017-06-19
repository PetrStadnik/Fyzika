using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fyzika.Models
{
    public class PyramidyManager
    {
        public List<Pyramidka> pyramidyList = new List<Pyramidka>();

        public PyramidyManager()
        {
            pyramidyList.Add(new Pyramidka(1, "prvni", "totot je pyramida", "sfsdf", "sf", "sfgfg", "ewrw", "tzztt", "QWWQW", "tzztt"));
            pyramidyList.Add(new Pyramidka(2, "druha", "totot je pyramida", "sfsdf", "sf", "sfgfg", "ewrw", "tzztt", "QWWQW", "tzztt"));
            pyramidyList.Add(new Pyramidka(3, "třetí", "totot je pyrjhghjamida", "sfsdf", "sf", "sfgfg", "ewrw", "tzztt", "QWWQW", "tzztt"));
            pyramidyList.Add(new Pyramidka(4, "čtvrtá", "totot je pyjjjjjjjramida", "sfsdf", "sf", "sfgfg", "ewrw", "tzztt", "QWWQW", "tzztt"));
            pyramidyList.Add(new Pyramidka(5, "pátá", "totot je pyramida", "sfsdf", "sf", "sfgfg", "ewrw", "tzztt", "QWWQW", "tzztt"));
        }

        public List<Pyramidka> VratList()
        {
          // pyramidyList = new List<Pyramidka>(pyramidyList.OrderBy(Pyramidka => Pyramidka.Nadpis));
            return pyramidyList;
        }

        public List<Pyramidka> Hledat()
        {
            return pyramidyList;
        }

    }
}