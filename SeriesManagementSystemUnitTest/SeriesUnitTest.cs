using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeriesManagementSystem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriesManagementSystemUnitTest
{
    [TestClass]
    public class SeriesUnitTest
    {
        Series _series;
        const String SeriesName = "testSeries";
        const String SeriesDescription = "this is a test Series Description";

        [TestInitialize]
        public void Initialize()
        {
            _series = new Series(SeriesName, SeriesDescription);
        }

        [TestMethod]
        public void TestName()
        {
            Assert.AreEqual(_series.Name, SeriesName);
        }

        [TestMethod]
        public void TestDescription()
        {
            Assert.AreEqual(_series.Description, SeriesDescription);
        }
    }
}
