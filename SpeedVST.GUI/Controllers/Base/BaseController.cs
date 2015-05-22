using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SpeedVST.Mock;
using SpeedVST.App.Models;
using SpeedVST.App;
using SpeedVST.App.Entities;
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
    }
}