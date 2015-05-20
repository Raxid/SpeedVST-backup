using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SpeedVST.App.Entities;
namespace SpeedVST.Mock
{
    public class TableExample
    {
        public int IDCounter { get { return PluginBase.Count(); } }
        public IList<PluginBase> PluginBase { get; set; }

        public TableExample()
        {
            PluginBase = new List<PluginBase> {
                new PluginBase(0,"FatBass", new DateTime(2014, 10, 10, 19, 0, 0), "DJdj","Phasers", 1.1M),
                new PluginBase(1, "Cracker", new DateTime(2015, 11, 9, 15, 30, 0), "Garisk", "Flangers", 1.1M)};
        }
    }
}