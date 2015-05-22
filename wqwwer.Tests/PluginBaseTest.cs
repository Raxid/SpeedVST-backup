using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpeedVST.App.Entities;
using SpeedVST.App;
using SpeedVST.App.Models;
using SpeedVST.Mock;
using System.Linq;

namespace SpeedVST.Tests
{
    [TestClass]
    public class PluginBaseTest
    {
        [TestMethod]
        public void ShouldGetListOfAllPlugins()
        {
            var pluginService = new PluginService();
            var expectedList = new TableExample().PluginBase;

            var resultList = pluginService.PluginBaseList;

            Assert.AreEqual(expectedList[0], resultList[0]);
            Assert.AreEqual(expectedList[1], resultList[1]);
        }

        [TestMethod]
        public void ShouldGetSpecifiedPlugin()
        {
            var pluginService = new PluginService();
            var expectedPlugin = new PluginBase(1, "Cracker", new DateTime(2015, 11, 9, 15, 30, 0), "Garisk", "Flangers", 1.1M);
            
            var pluginFound = pluginService.FindPlugin(1);

            Assert.AreEqual(expectedPlugin, pluginFound);
        }

        [TestMethod]
        public void EditSpecifiedPlugin()
        {
            var pluginService = new PluginService();
            var pluginToBeEdited = new PluginBase(1, "GGGG", new DateTime(2012, 11, 9, 15, 30, 0), "WEREDA", "Pads", 32.5M);

            pluginService.EditPlugin(pluginToBeEdited);

            var editedPlugin = pluginService.FindPlugin(pluginToBeEdited.ID);

            Assert.AreEqual(pluginToBeEdited, editedPlugin);
        }

        [TestMethod]
        public void DeleteSelectedPlugin()
        {
            var pluginService = new PluginService();
            pluginService.DeleteSelectedPlugin(0);
            var resultList = pluginService.PluginBaseList.F;
            Assert.AreEqual(, resultList);
        }

        [TestMethod]
         public void AddNewPlugin()
        {
            var pluginService = new PluginService();
            var pluginToAdd = new PluginBase("Gjh", new DateTime(2012, 11, 9, 15, 30, 0), "WEREDA", "Pads", 32.5M);
            pluginService.AddPlugin(pluginToAdd);
            var resultPlugin = pluginService.PluginBaseList.Last();
            Assert.AreEqual(pluginToAdd, resultPlugin);
        }
        }
    }
