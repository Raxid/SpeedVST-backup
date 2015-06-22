using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SpeedVST.Mock;
using SpeedVST.App.Models;
using SpeedVST.App;
using SpeedVST.App.Entities;
using System.IO;
using SpeedVST.GUI.Models;
namespace SpeedVST.GUI.Controllers
{
    public class BaseController : Controller
    {
        private PluginService _pluginService;
        private PluginDataBase db;

        public BaseController()
        {
            _pluginService = new PluginService();
        }

        public ActionResult List()
        {
            return View(_pluginService.PluginBaseList);
        }
        [HttpPost]
        public ActionResult AddNewPlugin([Bind(Include = "ID,Title,ReleaseDate,Author,Cat,Price")]PluginBase newPluginBase)
        {
            if (ModelState.IsValid)
            {
                db.PluginData.Add(newPluginBase);
                db.SaveChanges();
                return RedirectToAction("AddNewPlugin");
            }
            else 
            {

            }

            return View();
            //zapisujemy najlepiej za pomocą PluginService.Create(newPluginbase)
            //na razie mozemy zapisać do naszej listy w pamięci
            //+co zwracamy? 
            //1) widok nowo stworzonego plugina
            //2) liste wszystkich pluginow
        }
        [HttpGet]
        public ActionResult AddNewPlugin()
        {
            return View();
        }

    }
}