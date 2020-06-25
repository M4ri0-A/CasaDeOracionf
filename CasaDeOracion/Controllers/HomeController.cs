using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CasaDeOracion.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult index()
        {
            return View();
        }

        public ActionResult About()
        {


            return View();
        }



        public ActionResult events()
        {
            return View();
        }
        public ActionResult sermon()
        {
            return View();
        }
        public ActionResult blog()
        {
            return View();
        }
    }
}