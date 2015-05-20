using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SpeedVST.App.Entities;

namespace SpeedVST.App.Models
{
    public class PluginListViewer
    {
        public IList<PluginBase> PluginBase;

        public PluginListViewer()
        {
        }

        public PluginListViewer(IList<PluginBase> pluginList)
        {
            PluginBase = pluginList;
        }
    }


}