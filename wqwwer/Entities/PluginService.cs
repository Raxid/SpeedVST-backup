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
        public PluginListViewer PluginBaseList { get; set; }

        public PluginService()
        {
            PluginBaseList = new PluginListViewer(new TableExample().PluginBase);
        }

        public PluginBase FindPlugin(int pluginID)
        {
            return PluginBaseList.PluginBase.ElementAt(pluginID);
        }

        public void EditPlugin(PluginBase editedPlugin)
        {
            PluginBaseList.PluginBase[editedPlugin.ID] = editedPlugin;
        }

        public void AddPlugin(PluginBase newPlugin)
        {
            newPlugin.ID = PluginBaseList.PluginBase.Count();
            PluginBaseList.PluginBase.Add(newPlugin);
        }



        public void DeleteSelectedPlugin(int IdOfDeletingPlugin)
        {
           var pluginToDelete = FindPlugin(IdOfDeletingPlugin);
           PluginBaseList.PluginBase.Remove(pluginToDelete);
        }

        public static PluginService AddPlugin()
        {
            throw new NotImplementedException();
        }
    }
}
