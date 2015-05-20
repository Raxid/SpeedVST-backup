using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpeedVST.App.Models;
using SpeedVST.Mock;
using SpeedVST.App.Entities;
namespace SpeedVST.App
{
    public class PluginService
    {
        public IList<PluginBase> PluginBase { get; set; }

        public PluginService()
        {
            PluginBase = new TableExample().PluginBase;
        }

        public PluginBase FindPlugin(int pluginID)
        {
            return PluginBase.ElementAt(pluginID);
        }

        public void EditPlugin(PluginBase editedPlugin)
        {
            PluginBase[editedPlugin.ID] = editedPlugin;
        }

        public PluginBase AddPlugin(PluginBase newPlugin)
        {
            var NewID;
               return PluginBase.Insert(0,newPlugin);

        }
    }
}
