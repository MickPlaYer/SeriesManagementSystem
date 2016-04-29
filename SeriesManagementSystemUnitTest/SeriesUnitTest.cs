using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeriesManagementSystem.Domain;
using System;

namespace SeriesManagementSystemUnitTest
{
    [TestClass]
    public class SeriesUnitTest
    {
        Series _series;
        const String SeriesName = "testSeries";
        const String SeriesDescription = "this is a test Series Description";
        const int SeriesID = 10;

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
