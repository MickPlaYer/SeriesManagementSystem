using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeriesManagementSystem.Domain;
using SeriesManagementSystem.UI.ViewModel;
using System.Collections.Generic;

namespace SeriesManagementSystemUnitTest
{
    [TestClass]
    public class SeriesDetailFormPresentationModelTest
    {
        SeriesDetailFormPresentationModel _pModel;
        Series _series;
        PrivateObject _privateObject;
        const string SERIES_NAME = "series name";
        const string SERIES_DES = "series des";
        const string EPISODE_NAME = "episode name";
        const string EPISODE_DES = "episode des";

        [TestInitialize]
        public void Initialize()
        {
            _series = new Series(SERIES_NAME, SERIES_DES);
            _pModel = new SeriesDetailFormPresentationModel(_series);
            _privateObject = new PrivateObject(_pModel);
        }

        [TestMethod]
        public void TestGetter()
        {
            Assert.AreEqual(SERIES_DES, _pModel.SeriesDescription);
            Assert.AreEqual(SERIES_NAME, _pModel.SeriesName);
            Assert.AreEqual(0, _pModel.EpisodeNumber);

            _series.AddEpisode(EPISODE_NAME, EPISODE_DES);
            Assert.AreEqual(1, _pModel.EpisodeNumber);
        }

        [TestMethod]
        public void TestSetSeriesState()
        {
            List<Series> followingList = new List<Series>();
            List<Series> unfollowingList = new List<Series>();
            _pModel.SetSeriesState(followingList, unfollowingList);
            Assert.AreEqual("追蹤影集", _pModel.SeriesState);
            followingList.Add(_series);
            _pModel.SetSeriesState(followingList, unfollowingList);
            Assert.AreEqual("放棄影集", _pModel.SeriesState);
            followingList.Clear();
            unfollowingList.Add(_series);
            _pModel.SetSeriesState(followingList, unfollowingList);
            Assert.AreEqual("復原該影集", _pModel.SeriesState);
        }

        [TestMethod]
        public void TestMoveSeries()
        {
            string eventName = string.Empty;
            _pModel.FollowSeriesEvent += delegate()
            {
                eventName = "Follow Series";
            };
            _pModel.UnfollowSeriesEvent += delegate()
            {
                eventName = "Unfollow Series";
            };
            _pModel.RecoverSeriesEvent += delegate()
            {
                eventName = "Recover Series";
            };
            Assert.AreEqual(string.Empty, eventName);
            _pModel.MoveSeries();
            Assert.AreEqual("Follow Series", eventName);
            _privateObject.SetFieldOrProperty("_seriesState", SeriesState.Followed);
            _pModel.MoveSeries();
            Assert.AreEqual("Unfollow Series", eventName);
            _privateObject.SetFieldOrProperty("_seriesState", SeriesState.Unfollowed);
            _pModel.MoveSeries();
            Assert.AreEqual("Recover Series", eventName);
        }

        [TestMethod]
        public void TestGetCommandList()
        {
            _series.AddEpisode(EPISODE_NAME, EPISODE_DES);
            Episode episode = _series.Episodes[0];

            List<Command> commands = new List<Command>();
            Assert.AreEqual(0, _pModel.GetCommands(episode.Name).Count);
            episode.Record("this is a test command");
            Assert.AreEqual(1, _pModel.GetCommands(episode.Name).Count);
        }
    }
}
