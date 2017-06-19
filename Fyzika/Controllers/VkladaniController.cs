using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel;
using Fyzika.Models;

namespace Fyzika.Controllers
{
    public class VkladaniController : Controller
    {
        // GET: Vkladani
        public ActionResult Velicina(Veliciny veliciny)
        {
            ViewBag.stav = veliciny.Stav;

            if (ModelState.IsValid)
            {
                veliciny.PridatDoDatabaze();
            }

            VelicinyManager velicinyManager = new VelicinyManager();
           
       
          
            ViewBag.VelicinyList = velicinyManager.VratVelicinyList(velicinyManager);
            velicinyManager.VelicinyList.Add(new Veliciny(1, "nol", "m", "kk"));
            return View(veliciny);
        }

       


        public ActionResult Pyramida(Pyramidka pyramidka)
        {
            ViewBag.stav = pyramidka.Stav;
            if (ModelState.IsValid)
            {
                pyramidka.PridatDoDatabaze();
            }
            return View(pyramidka);
        }
    }
}