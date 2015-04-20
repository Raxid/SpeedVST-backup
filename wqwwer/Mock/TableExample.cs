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

        public void PluginExampleMock()
        {
            PluginBase = new List<PluginBase> {
                new PluginBase(0,"FatBass", new DateTime(2014, 10, 10, 19, 0, 0), "DJdj",""),
                new PluginBase(1, "C# For Masters", new DateTime(2015, 11, 9, 15, 30, 0), "Cocomo", "C# Training Aimed for C# Masters"),                

    };
        }
    }
}