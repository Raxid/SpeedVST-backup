using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SpeedVST.GUI.Controllers.Base
{
    public class ListController : Controller
    {
       [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
       public ActionResult Index()
       {
           return View();
       }
    }
}