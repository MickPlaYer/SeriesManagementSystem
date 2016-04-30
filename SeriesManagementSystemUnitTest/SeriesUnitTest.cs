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
            Assert.AreEqual(_series.Name, SeriesName);
        }

        [TestMethod]
        public void TestDescription()
        {
            Assert.AreEqual(_series.Description, SeriesDescription);
        }

        [TestMethod]
        public void TestSetName()
        {
            Assert.AreEqual(_series.Name, SeriesName);
            _series.SetName(ModifiedSeriesName);
            Assert.AreEqual(_series.Name, ModifiedSeriesName);
        }

        [TestMethod]
        public void TestSetDescription()
        {
            Assert.AreEqual(_series.Description, SeriesDescription);
            _series.SetDescription(ModifiedSeriesDescription);
            Assert.AreEqual(_series.Description, ModifiedSeriesDescription);
        }
    }
}
