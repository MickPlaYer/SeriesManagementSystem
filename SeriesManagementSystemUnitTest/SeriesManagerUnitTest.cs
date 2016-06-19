using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using SeriesManagementSystem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace SeriesManagementSystemUnitTest
{
    [TestClass]
    public class SeriesManagerUnitTest
    {
        SeriesManager _seriesManager;
        Series[] _series;
        PrivateObject _privateObject;
        const int SeriesID = 0;
        const string SeriesName = "manager's series";
        const string SeriesDescription = "it is a series' description of manager";
        const string ModifiedSeriesName = "modifiedSeries";
        const string ModifiedSeriesDescription = "this is a modified description";

        [TestInitialize]
        public void Initialize()
        {
            _seriesManager = new SeriesManager();
            _series = new Series[3];
            for (int i = 0; i < 3; i++)
            {
                _series[i] = new Series(SeriesName + i.ToString(), SeriesDescription + i.ToString(), SeriesID + i);
            }
            _privateObject = new PrivateObject(_seriesManager);
        }

        [TestMethod]
        public void TestInitializeCount()
        {
            Assert.AreEqual(0, _privateObject.GetFieldOrProperty("_count"));
            _privateObject.SetField("_series", new List<Series>(_series));
            _privateObject.Invoke("InitializeCount");
            Assert.AreEqual(3, _privateObject.GetFieldOrProperty("_count"));
        }

        [TestMethod]
        public void TestInitializeSeries()
        {
            List<Series> seriesList = _privateObject.GetField("_series") as List<Series>;
            List<Series> followingList = _privateObject.GetField("_followingList") as List<Series>;
            List<Series> unfollowingList = _privateObject.GetField("_unfollowingList") as List<Series>;
            seriesList.AddRange(_series);
            followingList.Add(new Series("The important", "is ID. >>", 0));
            unfollowingList.Add(new Series("The important", "is ID. >>", 1));
            unfollowingList.Add(new Series("The important", "is ID. >>", 2));
            _privateObject.Invoke("InitializeSeries");
            followingList = _privateObject.GetField("_followingList") as List<Series>;
            unfollowingList = _privateObject.GetField("_unfollowingList") as List<Series>;
            Assert.AreEqual(seriesList[0], followingList[0]);
            Assert.AreEqual(seriesList[1], unfollowingList[0]);
            Assert.AreEqual(seriesList[2], unfollowingList[1]);
        }

        /// <summary>
        /// Test function of AddSeries
        /// </summary>
        [TestMethod]
        public void TestAdd()
        {
            // test AddSeries function with one parameter, series
            _seriesManager.AddSeries(_series[0].Name, _series[0].Description);
            List<Series> seriesList = GetSeriesList();
            Series series = seriesList.Last();
            Assert.AreEqual(series.Name, _series[0].Name);
            Assert.AreEqual(series.Description, _series[0].Description);

            // test AddSeries function with two parameter, name ,and description
            Initialize();
            _seriesManager.AddSeries(SeriesName, SeriesDescription);
            seriesList = GetSeriesList();
            series = seriesList.Last();
            Assert.AreEqual(series.Name, SeriesName);
            Assert.AreEqual(series.Description, SeriesDescription);
        }

        /// <summary>
        /// test the function of AddRange with a parameter, List<Series>
        /// </summary>
        [TestMethod]
        public void TestAddRange()
        {
            List<Series> content = GetSeriesList();
            Assert.IsTrue(content.Count == 0, "the initialized series list is not empty");
            List<Series> seriesList = new List<Series>(_series);
            string contentString = JsonConvert.SerializeObject(seriesList);
            _seriesManager.AddList(contentString);
            content = GetSeriesList();
            Assert.IsTrue(content.Count != 0, "the series list is still empty after adding a list of series");
        }

        /// <summary>
        /// Test function of SelectSeries
        /// </summary>
        [TestMethod]
        public void TestSelectSeries()
        {
            // add series into series manager
            List<Series> seriesList = GetSeriesList();
            seriesList.AddRange(new List<Series>(_series));

            // test initialization of selected series is empty
            Assert.IsNull(_seriesManager.SelectedSeries);

            // test selected series after selecting the series
            _seriesManager.SelectSeries(2);
            Assert.AreEqual(_series[2], _seriesManager.SelectedSeries);
            _seriesManager.SelectSeries(1);
            Assert.AreEqual(_series[1], _seriesManager.SelectedSeries);

            // test if manager does not find the series in the list, it returns null
            _seriesManager.SelectSeries(10);
            Assert.IsNull(_seriesManager.SelectedSeries);
        }

        [TestMethod]
        public void TestModifiedSelectedSeries()
        {
            GetSeriesList().AddRange(new List<Series>(_series));

            _seriesManager.SelectSeries(2);
            Assert.AreEqual(_series[2], _seriesManager.SelectedSeries);

            _seriesManager.ModifySelectedSeries(ModifiedSeriesName, ModifiedSeriesDescription);
            Assert.AreEqual(ModifiedSeriesName, _seriesManager.SelectedSeries.Name);
            Assert.AreEqual(ModifiedSeriesDescription, _seriesManager.SelectedSeries.Description);

            Assert.AreEqual(ModifiedSeriesName, GetSeriesList().Find((x) => x.SeriesID == 2).Name);
            Assert.AreEqual(ModifiedSeriesDescription, GetSeriesList().Find((x) => x.SeriesID == 2).Description);
        }

        [TestMethod]
        public void TestRemoveSeries()
        {
            List<Series> seriesList = _privateObject.GetField("_series") as List<Series>;
            List<Series> followingList = _privateObject.GetField("_followingList") as List<Series>;
            List<Series> unfollowingList = _privateObject.GetField("_unfollowingList") as List<Series>;
            seriesList.AddRange(_series);
            followingList.Add(_series[1]);
            unfollowingList.Add(_series[2]);
            Assert.AreEqual(3, seriesList.Count);
            Assert.AreEqual(1, followingList.Count);
            Assert.AreEqual(1, unfollowingList.Count);
            _seriesManager.RemoveSeries(0);
            Assert.AreEqual(2, seriesList.Count);
            Assert.AreEqual(1, followingList.Count);
            Assert.AreEqual(1, unfollowingList.Count);
            _seriesManager.RemoveSeries(2);
            Assert.AreEqual(1, seriesList.Count);
            Assert.AreEqual(1, followingList.Count);
            Assert.AreEqual(0, unfollowingList.Count);
            _seriesManager.RemoveSeries(1);
            Assert.AreEqual(0, seriesList.Count);
            Assert.AreEqual(0, followingList.Count);
            Assert.AreEqual(0, unfollowingList.Count);
            Assert.AreEqual(-1, seriesList.IndexOf(_series[1]));
        }

        [TestMethod]
        public void TestAddServerData()
        {
            List<Series> seriesList = GetSeriesList();
            string content = "[{\"Name\":\"ServerSeries1\",\"Description\":\"This is on the server.\",\"SeriesID\":-256}]";
            Assert.IsFalse(_seriesManager.IsExistNewOne);
            _seriesManager.AddServerData(content);
            Assert.IsTrue(_seriesManager.IsExistNewOne);
            Assert.AreEqual(1, seriesList.Count);
            _seriesManager.AddServerData(content);
            Assert.IsFalse(_seriesManager.IsExistNewOne);
            Assert.AreEqual(1, seriesList.Count);
        }

        [TestMethod]
        public void TestFollowSeries()
        {
            _privateObject.SetField("_series", new List<Series>(_series));
            _privateObject.SetField("_selectedSeries", _series[2]);
            _seriesManager.FollowSeries();
            List<Series> followingList = _privateObject.GetField("_followingList") as List<Series>;
            Series s = followingList[followingList.Count - 1];
            Assert.AreEqual(1, followingList.Count);
            Assert.AreEqual(SeriesName + 2, s.Name);
            Assert.AreEqual(SeriesDescription + 2, s.Description);
        }

        [TestMethod]
        public void TestUnfollowSeries()
        {
            List<Series> followingList = _privateObject.GetField("_followingList") as List<Series>;
            List<Series> unfollowingList = _privateObject.GetField("_unfollowingList") as List<Series>;
            followingList.AddRange(new List<Series>(_series));
            _privateObject.SetField("_selectedSeries", _series[2]);
            Assert.AreEqual(0, unfollowingList.Count);
            Assert.AreEqual(3, followingList.Count);
            _seriesManager.UnfollowSeries();
            Assert.AreEqual(1, unfollowingList.Count);
            Assert.AreEqual(2, followingList.Count);
            Series s = unfollowingList[unfollowingList.Count - 1];
            Assert.AreEqual(SeriesName + 2, s.Name);
            Assert.AreEqual(SeriesDescription + 2, s.Description);
            int index = followingList.IndexOf(s);
            Assert.AreEqual(-1, index);
        }

        [TestMethod]
        public void TestRecoverSeries()
        {
            List<Series> followingList = _privateObject.GetField("_followingList") as List<Series>;
            List<Series> unfollowingList = _privateObject.GetField("_unfollowingList") as List<Series>;
            unfollowingList.AddRange(new List<Series>(_series));
            _privateObject.SetField("_selectedSeries", _series[2]);
            Assert.AreEqual(3, unfollowingList.Count);
            Assert.AreEqual(0, followingList.Count);
            _seriesManager.RecoverSeries();
            Assert.AreEqual(2, unfollowingList.Count);
            Assert.AreEqual(1, followingList.Count);
            Series s = followingList[followingList.Count - 1];
            Assert.AreEqual(SeriesName + 2, s.Name);
            Assert.AreEqual(SeriesDescription + 2, s.Description);
            int index = unfollowingList.IndexOf(s);
            Assert.AreEqual(-1, index);
        }

        [TestMethod]
        public void TestAddEpisode()
        {
            List<Series> followingList = _privateObject.GetField("_followingList") as List<Series>;
            Series s = _series[2];
            string eName = "e1", eDesc = "how it is going?";
            followingList.AddRange(_series);
            _privateObject.SetField("_selectedSeries", s);
            Assert.AreEqual(0, s.Episodes.Count);
            _seriesManager.AddEpisode(eName, eDesc);
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
            List<Series> followingList = _privateObject.GetField("_followingList") as List<Series>;
            Series s = _series[1];
            s.AddEpisode(eName, eDesc);
            Episode e = s.Episodes[0];
            followingList.Add(s);
            _privateObject.SetField("_selectedSeries", s);
            _seriesManager.Record(eName, command);
            Assert.AreEqual(1, e.CommandList.Count);
            Assert.IsTrue(e.IsRead);
        }

        [TestMethod]
        public void TestToJson()
        {
            Series s = new Series("s1", "456");
            s.AddEpisode("e1", "sad");
            _seriesManager.SeriesList.Add(s);
            var jSetting = new JsonSerializerSettings();
            jSetting.Formatting = Formatting.Indented;
            String json = JsonConvert.SerializeObject(_seriesManager, jSetting);
            SeriesManager sm = JsonConvert.DeserializeObject<SeriesManager>(json);
            Assert.AreEqual("s1", sm.SeriesList[0].Name);
            Assert.AreEqual("456", sm.SeriesList[0].Description);
            Assert.AreEqual("e1", sm.SeriesList[0].Episodes[0].Name);
            Assert.AreEqual("sad", sm.SeriesList[0].Episodes[0].Description);
        }

        [TestMethod]
        public void TestSetSeriesFlitter()
        {
            _seriesManager.SetSeriesFlitter(SeriesListFlitter.Following);
            Assert.AreEqual(SeriesListFlitter.Following, _privateObject.GetFieldOrProperty("_seriesFlitter"));
        }

        [TestMethod]
        public void TestGetSeriesList()
        {
            List<Series> seriesList = _privateObject.GetFieldOrProperty("_series") as List<Series>;
            seriesList.Add(_series[0]);

            List<Series> followingList = _privateObject.GetFieldOrProperty("_followingList") as List<Series>;
            followingList.Add(_series[1]);

            List<Series> unfollowingList = _privateObject.GetFieldOrProperty("_unfollowingList") as List<Series>;
            unfollowingList.Add(_series[2]);

            Assert.AreEqual(seriesList, _seriesManager.SeriesList);
            _privateObject.SetFieldOrProperty("_seriesFlitter", SeriesListFlitter.Unfollowing);
            Assert.AreEqual(unfollowingList, _seriesManager.SeriesList);
            _privateObject.SetFieldOrProperty("_seriesFlitter", SeriesListFlitter.Following);
            Assert.AreEqual(followingList, _seriesManager.SeriesList);
            _privateObject.SetFieldOrProperty("_seriesFlitter", SeriesListFlitter.All);
            Assert.AreEqual(seriesList, _seriesManager.SeriesList);
        }

        /// <summary>
        /// get the series list of series manager
        /// </summary>
        /// <returns></returns>
        private List<Series> GetSeriesList()
        {
            return _seriesManager.SeriesList;
        }
    }
}
