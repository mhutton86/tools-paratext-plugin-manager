﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using PpmMain.LocalInstallerService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace PpmMain.LocalInstallerService.Tests
{
    [TestClass()]
    public class LocalInstallerServiceTests
    {
        [TestMethod()]
        public void GetInstalledPluginsTest()
        {
            List<PluginDescription> plugins = LocalInstallerService.GetInstalledPlugins();
            Assert.IsTrue("Some Plugin".Equals(plugins[0].name));
        }

        [TestMethod()]
        public void GetPluginPath_works_for_Paratext8_on_a_64bit_system()
        {
            Assert.IsTrue("C:\\Program Files (x86)\\Paratext 8\\plugins\\ParatextPluginManagerPlugin".Equals(LocalInstallerService.GetPluginPath()));
        }
    }
}