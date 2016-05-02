using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeriesManagementSystem.Domain;
using System;

namespace SeriesManagementSystemUnitTest
{
    [TestClass]
    public class SeriesUnitTest
    {
        Series _series;
        const int SeriesID = 10;
        const string SeriesName = "testSeries";
        const string SeriesDescription = "this is a test Series Description";
        const string ModifiedSeriesName = "modifiedSeries";
        const string ModifiedSeriesDescription = "this is a modified description";

        [TestInitialize]
        public void Initialize()
        {
            _series = new Series(SeriesName, SeriesDescription);
        }

        [TestMethod]
        public void TestName()
        {
            Assert.AreEqual(SeriesName, _series.Name);
        }

        [TestMethod]
        public void TestDescription()
        {
            Assert.AreEqual(SeriesDescription, _series.Description);
        }

        [TestMethod]
        public void TestSetName()
        {
            Assert.AreEqual(SeriesName, _series.Name);
            _series.SetName(ModifiedSeriesName);
            Assert.AreEqual(ModifiedSeriesName, _series.Name);
        }

        [TestMethod]
        public void TestSetDescription()
        {
            Assert.AreEqual(SeriesDescription, _series.Description);
            _series.SetDescription(ModifiedSeriesDescription);
            Assert.AreEqual(ModifiedSeriesDescription, _series.Description);
        }
    }
}
