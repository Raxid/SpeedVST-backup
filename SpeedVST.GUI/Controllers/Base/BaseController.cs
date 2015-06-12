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
namespace SpeedVST.GUI.Controllers
{
    public class BaseController : Controller
    {
        private PluginService _pluginService;

        public BaseController()
        {
            _pluginService = new PluginService();
        }

        public ActionResult List()
        {
            return View(_pluginService.PluginBaseList);
        }
        [HttpPost]
        public ActionResult AddNewPlugin(PluginBase newPluginBase)
        {
            //zapisujemy najlepiej za pomocą PluginService.Create(newPluginbase)
            //na razie mozemy zapisać do naszej listy w pamięci
            //+co zwracamy? 
            //1) widok nowo stworzonego plugina
            //2) liste wszystkich pluginow
            return View();
        }
        [HttpGet]
        public ActionResult AddNewPlugin()
        {
            return View();
        }

    }
}