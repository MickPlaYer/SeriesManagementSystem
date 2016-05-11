using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeriesManagementSystem.Domain;
using System.IO;
using System.Text;
using System.Collections.Generic;
using SeriesManagementSystemUnitTest.TestItem;

namespace SeriesManagementSystemUnitTest
{
    [TestClass]
    public class SoftwareUnitTest
    {
        Software _software;
        PrivateObject _privateObject;
        const String _filePath = "../test.txt";
        const string SeriesName = "Test Series";
        const string SeriesDescription = "This is a test description";
        const string ModifiedSeriesName = "modifiedSeries";
        const string ModifiedSeriesDescription = "this is a modified description";
        const string FILE_PATH = "./dat/data.dat";

        [TestInitialize()]
        public void TestInitialize()
        {
            _software = new Software();
            _privateObject = new PrivateObject(_software, new PrivateType(typeof(Software)));

            for (int i = 0; i < 3; i++)
            {
                _software.AddSeries(SeriesName + i.ToString(), SeriesDescription + i.ToString());
            }
        }

        [TestCleanup]
        public void CleanUp()
        {
            if (File.Exists(FILE_PATH))
                File.Delete(FILE_PATH);
        }

        [TestMethod]
        public void TestAddSeries()
        {
            String name = "First Movie";
            String description = "The first movie in the world.";
            _software.AddSeries(name, description);
            Series s = GetLastSeries();
            Assert.AreEqual(name, s.Name);
            Assert.AreEqual(description, s.Description);
        }

        [TestMethod]
        public void TestImportFile()
        {
            String name = "First Movie";
            String description = "The first movie in the world.";
            int seriesID = 1;
            String fileContext = "[{ \"Name\":\"" + name + "\", \"Description\":\"" + description + "\", \"SeriesID\":" + seriesID + "}]";
            PrepareImportFile(fileContext);
            _software.ImportFile(_filePath);
            Series s = GetLastSeries();
            Assert.AreEqual(name, s.Name);
            Assert.AreEqual(description, s.Description);
        }

        [TestMethod]
        public void TestSelectSeries()
        {
            _software.SelectSeries(1);
            Assert.AreEqual(SeriesName + 1, GetSeriesManager().SelectedSeries.Name);
            Assert.AreEqual(SeriesDescription + 1, GetSeriesManager().SelectedSeries.Description);
        }

        [TestMethod]
        public void TestModifySeries()
        {
            _software.SelectSeries(1);
            Assert.AreEqual(SeriesName + 1, GetSeriesManager().SelectedSeries.Name);
            Assert.AreEqual(SeriesDescription + 1, GetSeriesManager().SelectedSeries.Description);
            _software.ModifySeries(ModifiedSeriesName, ModifiedSeriesDescription);
            Assert.AreEqual(ModifiedSeriesName, GetSeriesManager().SelectedSeries.Name);
            Assert.AreEqual(ModifiedSeriesDescription, GetSeriesManager().SelectedSeries.Description);
        }

        [TestMethod]
        public void TestRemoveSeries()
        {
            SeriesManager seriesManager = GetSeriesManager();
            List<Series> seriesList = seriesManager.SeriesList;
            Assert.AreEqual(4, seriesList.Count);
            _software.RemoveSeries(1);
            Assert.AreEqual(3, seriesList.Count);
            Assert.IsNull(seriesList.Find((s) => s.Name == SeriesName + 1));
        }

        [TestMethod]
        public void TestGetSeriesList()
        {
            SeriesManager seriesManager = GetSeriesManager();
            Assert.AreEqual(seriesManager.SeriesList, _software.GetSeriesList());
        }

        [TestMethod]
        public void TestDestructor()
        {
            Assert.IsFalse(File.Exists(FILE_PATH));
            _software = null;
            _privateObject = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Assert.IsTrue(File.Exists(FILE_PATH));
        }

        [TestMethod]
        public void TestAddServerData()
        {
            Assert.IsFalse(_software.IsNoInternet);
            _privateObject.Invoke("AddServerData", new TestServer());
            Assert.IsTrue(_software.IsNoInternet);
        }

        private void PrepareImportFile(string fileContext)
        {
            if (File.Exists(_filePath))
                File.Delete(_filePath);
            using (FileStream fs = File.OpenWrite(_filePath))
            {
                Byte[] info = new UTF8Encoding(true).GetBytes(fileContext);
                fs.Write(info, 0, info.Length);
            }
        }

        #region Get Private Object
        private Series GetLastSeries()
        {
            SeriesManager seriesManager = GetSeriesManager();
            Assert.IsNotNull(seriesManager.SeriesList);
            Assert.IsTrue(seriesManager.SeriesList.Count > 0, "No any series in the list!");
            return seriesManager.SeriesList[seriesManager.SeriesList.Count - 1];
        }
        private SeriesManager GetSeriesManager()
        {
            return _privateObject.GetField("_seriesManager") as SeriesManager;
        }
        #endregion
    }
}
