using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fyzika.Models
{
    public class VelicinyManager
    {
        public List<Veliciny> VelicinyList { get; set; }
        public VelicinyManager()
            {
           
            VelicinyList = new List<Veliciny>();         
            }

        public string VratVelicinyList(VelicinyManager velicinyManager)
        {
            Databaze databaze = new Databaze();
            VelicinyList.Add(new Veliciny(1, "nol", "m", "kk"));
            VelicinyList.Add(new Veliciny(2, "nol", "km", "kppp"));
            return databaze.VypisVeliciny(velicinyManager);
        }
    }
}