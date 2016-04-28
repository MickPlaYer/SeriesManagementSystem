using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeriesManagementSystem.Domain;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SeriesManagementSystemUnitTest
{
    [TestClass]
    public class SoftwareUnitTest
    {
        Software _software;
        PrivateObject _privateObject;
        const String _filePath = "./test.txt";

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
            Series s = GetLastSeries();
            Assert.AreEqual(name, s.Name);
            Assert.AreEqual(description, s.Description);
        }

        [TestMethod]
        public void TestImportFile()
        {
            String name = "First Movie";
            String description = "The first movie in the world.";
            String fileContext = "[{ \"Name\":\"" + name + "\", \"Description\":\"" + description + "\" }]";
            PrepareImportFile(fileContext);
            _software.ImportFile(_filePath);
            Series s = GetLastSeries();
            Assert.AreEqual(name, s.Name);
            Assert.AreEqual(description, s.Description);
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
            SeriesManager sl = _privateObject.GetField("_seriesManager") as SeriesManager;
            Assert.IsTrue(sl.SeriesList.Count > 0, "Not any series in the list!");
            return sl.SeriesList[sl.SeriesList.Count - 1];
        }
        #endregion
    }
}
