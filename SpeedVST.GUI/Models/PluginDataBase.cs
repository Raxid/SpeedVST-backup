using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SpeedVST.GUI.Models
{
    public class PluginDataBase : DbContext
    {

        public System.Data.Entity.DbSet<SpeedVST.App.Entities.PluginBase> PluginData { get; set; }
    
    }
}
