using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpeedVST.App.Entities.PluginBase;
using SpeedVST.App.Entities;

namespace SpeedVST.Tests
{
    [TestClass]
    public class PluginBaseTest
    {
        [TestMethod]
        public void PluginBaseIDChanging()
        {
            int CurrentID = 0;
            var changer = new PluginBase("Name",DateTime.Now.AddDays(1),"Author","VSTplugin",0.0);
        }
    }
}
