using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeriesManagementSystem.Domain;
using System.IO;
using System.Text;

namespace SeriesManagementSystemUnitTest
{
    [TestClass]
    public class SoftwareUnitTest
    {
        Software _software;
        PrivateObject _privateObject;
        Series[] _series;
        const String _filePath = "../test.txt";
        const string SeriesName = "Test Series";
        const string SeriesDescription = "This is a test description";
        const string ModifiedSeriesName = "modifiedSeries";
        const string ModifiedSeriesDescription = "this is a modified description";

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
            String fileContext = "[{ \"Name\":\"" + name + "\", \"Description\":\"" + description + "\", \"SeriesID\":"+seriesID+"}]";
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
            Assert.AreEqual(GetSeriesManager().SelectedSeries.Name, SeriesName + 0);
            Assert.AreEqual(GetSeriesManager().SelectedSeries.Description, SeriesDescription + 0);
        }

        [TestMethod]
        public void TestModifySeries()
        {
            _software.SelectSeries(1);
            Assert.AreEqual(GetSeriesManager().SelectedSeries.Name, SeriesName + 0);
            Assert.AreEqual(GetSeriesManager().SelectedSeries.Description, SeriesDescription + 0);
            _software.ModifySeries(ModifiedSeriesName, ModifiedSeriesDescription);
            Assert.AreEqual(GetSeriesManager().SelectedSeries.Name, ModifiedSeriesName);
            Assert.AreEqual(GetSeriesManager().SelectedSeries.Description, ModifiedSeriesDescription);
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
