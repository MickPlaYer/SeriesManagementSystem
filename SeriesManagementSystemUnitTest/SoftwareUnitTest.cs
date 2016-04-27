using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeriesManagementSystem.Domain;
using System.Collections.Generic;

namespace SeriesManagementSystemUnitTest
{
    [TestClass]
    public class SoftwareUnitTest
    {
        Software _software;
        PrivateObject _privateObject;

        [TestInitialize()]
        public void TestInitialize()
        {
            _software = new Software();
            _privateObject = new PrivateObject(_software, new PrivateType(typeof(Software)));
        }

        [TestMethod]
        public void TestAddSeries()
        {
            String name = "First Movie";
            String description = "The first movie in the world.";
            _software.AddSeries(name, description);
            List<Series> sl = _privateObject.GetField("_seriesList") as List<Series>;
            Series s = sl[sl.Count - 1];
            Assert.AreEqual(name, s.Name);
            Assert.AreEqual(description, s.Description);
        }
    }
}
