﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeriesManagementSystem.Domain;
using System.IO;
using System.Text;
using System.Collections.Generic;
using SeriesManagementSystemUnitTest.FakeItem;
using System.ComponentModel;

namespace SeriesManagementSystemUnitTest
{
    [TestClass]
    public class SoftwareUnitTest
    {
        Software _software;
        PrivateObject _privateObject;
        FakeFileSystem _fakeFileSystem;
        FakeServer _fakeServer;
        const string SeriesName = "Test Series";
        const string SeriesDescription = "This is a test description";
        const string ModifiedSeriesName = "modifiedSeries";
        const string ModifiedSeriesDescription = "this is a modified description";
        const string FILE_PATH = "./dat/data.dat";

        [TestInitialize()]
        public void Initialize()
        {
            _fakeFileSystem = new FakeFileSystem();
            _fakeServer = new FakeServer();
            _software = new Software(_fakeServer, _fakeFileSystem);
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
            String fileContext = "[{ \"Name\":\"" + name + "\", \"Description\":\"" + description + "\", \"SeriesID\":" + seriesID + "}]";
            _fakeFileSystem.PrepareImportFile(fileContext);
            _software.ImportFile(FILE_PATH);
            Series s = GetLastSeries();
            Assert.AreEqual(name, s.Name);
            Assert.AreEqual(description, s.Description);
            // Fail route.
            _fakeFileSystem.PrepareImportFile("[{\"Name\"");
            Assert.IsFalse(_software.IsImportFail);
            _software.ImportFile(FILE_PATH);
            Assert.IsTrue(_software.IsImportFail);
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
        public void TestGetSeriesManager()
        {
            SeriesManager seriesManager = GetSeriesManager();
            Assert.AreEqual(seriesManager, _software.SeriesManager);
        }

        [TestMethod]
        public void TestDestructor()
        {
            string seriesListString = GetSeriesManager().SeriesListString;
            string expected = FILE_PATH + seriesListString;
            _software = null;
            _privateObject = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Assert.AreEqual(expected, _fakeFileSystem.Content);
        }

        [TestMethod]
        public void TestAddServerData()
        {
            Assert.IsFalse(_software.IsNoInternet);
            _fakeServer.IsDownloadFail = true;
            _software.RefreshServerData();
            Assert.IsTrue(_software.IsNoInternet);
            _fakeServer.IsDownloadFail = false;
            _software.RefreshServerData();
            Assert.IsFalse(_software.IsNoInternet);
        }

        [TestMethod]
        public void TestLoadFile()
        {
            Assert.IsFalse(_software.IsLoadFail);
            _fakeFileSystem.IsLoadFail = true;
            _privateObject.Invoke("LoadFile");
            Assert.IsTrue(_software.IsLoadFail);
            _fakeFileSystem.IsLoadFail = false;
            _privateObject.Invoke("LoadFile");
            Assert.IsFalse(_software.IsLoadFail);
        }

        [TestMethod]
        public void TestFollowSeries()
        {
            GetSeriesManager().SelectSeries(2);
            _software.FollowSeries();
            Series s = GetLastFollowingSeries();
            Assert.AreEqual(1, GetSeriesManager().FollowingList.Count);
            Assert.AreEqual(SeriesName + 2, s.Name);
            Assert.AreEqual(SeriesDescription + 2, s.Description);
        }

        [TestMethod]
        public void TestUnfollowSeries()
        {
            GetSeriesManager().SelectSeries(2);
            GetSeriesManager().FollowSeries();
            _software.UnfollowSeries();
            Assert.AreEqual(1, GetSeriesManager().UnfollowingList.Count);
            Assert.AreEqual(0, GetSeriesManager().FollowingList.Count);
            Series s = GetLastUnfollowingSeries();
            Assert.AreEqual(SeriesName + 2, s.Name);
            Assert.AreEqual(SeriesDescription + 2, s.Description);
            int index = GetSeriesManager().FollowingList.IndexOf(s);
            Assert.AreEqual(-1, index);
        }

        [TestMethod]
        public void TestRecoverSeries()
        {
            GetSeriesManager().SelectSeries(2);
            GetSeriesManager().FollowSeries();
            GetSeriesManager().UnfollowSeries();
            _software.RecoverSeries();
            Assert.AreEqual(0, GetSeriesManager().UnfollowingList.Count);
            Assert.AreEqual(1, GetSeriesManager().FollowingList.Count);
            Series s = GetLastFollowingSeries();
            Assert.AreEqual(SeriesName + 2, s.Name);
            Assert.AreEqual(SeriesDescription + 2, s.Description);
            int index = GetSeriesManager().UnfollowingList.IndexOf(s);
            Assert.AreEqual(-1, index);
        }

        [TestMethod]
        public void TestAddEpisode()
        {
            GetSeriesManager().SelectSeries(2);
            Series s = GetSeriesManager().SelectedSeries;
            string eName = "e1", eDesc = "how it is going?";
            Assert.AreEqual(0, s.Episodes.Count);
            _software.AddEpisode(eName, eDesc);
            Assert.AreEqual(1, s.Episodes.Count);
            Episode e = s.Episodes[s.Episodes.Count - 1];
            Assert.AreEqual(eName, e.Name);
            Assert.AreEqual(eDesc, e.Description);
        }

        [TestMethod]
        public void TestRecord()
        {
            string eName = "goodEp", eDesc = "Hero is dead.";
            string command = "So suprise!";
            GetSeriesManager().SelectSeries(1);
            Series s = GetSeriesManager().SelectedSeries;
            s.AddEpisode(eName, eDesc);
            Episode e = s.Episodes[0];
            _software.Record(eName, command);
            Assert.AreEqual(1, e.CommandList.Count);
            Assert.IsTrue(e.IsRead);
        }

        #region Get Private Object
        private Series GetLastSeries()
        {
            SeriesManager seriesManager = GetSeriesManager();
            Assert.IsNotNull(seriesManager.SeriesList);
            Assert.IsTrue(seriesManager.SeriesList.Count > 0, "No any series in the list!");
            return seriesManager.SeriesList[seriesManager.SeriesList.Count - 1];
        }

        private Series GetLastFollowingSeries()
        {
            SeriesManager seriesManager = GetSeriesManager();
            Assert.IsNotNull(seriesManager.FollowingList);
            Assert.IsTrue(seriesManager.FollowingList.Count > 0, "No any series in the following list!");
            return seriesManager.FollowingList[seriesManager.FollowingList.Count - 1];
        }

        private Series GetLastUnfollowingSeries()
        {
            SeriesManager seriesManager = GetSeriesManager();
            Assert.IsNotNull(seriesManager.UnfollowingList);
            Assert.IsTrue(seriesManager.UnfollowingList.Count > 0, "No any series in the following list!");
            return seriesManager.UnfollowingList[seriesManager.UnfollowingList.Count - 1];
        }

        private SeriesManager GetSeriesManager()
        {
            return _privateObject.GetField("_seriesManager") as SeriesManager;
        }
        #endregion
    }
}
