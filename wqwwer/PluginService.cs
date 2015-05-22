using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpeedVST.App.Models;
using SpeedVST.Mock;
using SpeedVST.App.Entities;
using SpeedVST;

namespace SpeedVST.App
{
    public class PluginService
    {
        public IList<PluginBase> PluginBaseList { get; set; }

        public PluginService()
        {
            PluginBaseList = new TableExample().PluginBase;
        }

        public PluginBase FindPlugin(int pluginID)
        {
            return PluginBaseList.ElementAt(pluginID);
        }

        public void EditPlugin(PluginBase editedPlugin)
        {
            PluginBaseList[editedPlugin.ID] = editedPlugin;
        }

        public void AddPlugin(PluginBase newPlugin)
        {
            newPlugin.ID = PluginBaseList.Count();
            PluginBaseList.Add(newPlugin);
        }



        public void DeleteSelectedPlugin(int IdOfDeletingPlugin)
        {
           var PluginToDelete = FindPlugin(IdOfDeletingPlugin);
           PluginBaseList.Remove(PluginToDelete);
        }
    }
}
