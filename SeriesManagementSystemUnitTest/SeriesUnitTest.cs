using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeriesManagementSystem.Domain;
using System;
using System.Collections.Generic;

namespace SeriesManagementSystemUnitTest
{
    [TestClass]
    public class SeriesUnitTest
    {
        Series _series;
        List<Episode> _episodes;
        const int SeriesID = 10;
        const string SeriesName = "testSeries";
        const string SeriesDescription = "this is a test Series Description";
        const string ModifiedSeriesName = "modifiedSeries";
        const string ModifiedSeriesDescription = "this is a modified description";
        static readonly string[] EPISODE_NAMES = new string[] { "episode 0", "episode 1" };
        static readonly string[] EPISODE_DESCRIPTIONS = new string[] { "episode description 0", "episode description 1" };

        [TestInitialize]
        public void Initialize()
        {
            _series = new Series(SeriesName, SeriesDescription);
            _episodes = new List<Episode>();
            _episodes.Add(new Episode(EPISODE_NAMES[0], EPISODE_DESCRIPTIONS[0], 0));
            _episodes.Add(new Episode(EPISODE_NAMES[1], EPISODE_DESCRIPTIONS[1], 1));
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
            _series.Name = ModifiedSeriesName;
            Assert.AreEqual(ModifiedSeriesName, _series.Name);
        }

        [TestMethod]
        public void TestSetDescription()
        {
            Assert.AreEqual(SeriesDescription, _series.Description);
            _series.Description = ModifiedSeriesDescription;
            Assert.AreEqual(ModifiedSeriesDescription, _series.Description);
        }

        [TestMethod]
        public void TestAddEpisode()
        {
            Assert.AreEqual(0, GetEpisodes().Count);
            _series.AddEpisode(EPISODE_NAMES[0], EPISODE_DESCRIPTIONS[0]);
            Assert.AreEqual(1, GetEpisodes().Count);
        }

        [TestMethod]
        public void TestRecord()
        {
            string command = "Very well.";
            GetEpisodes().AddRange(_episodes);
            _series.Record(EPISODE_NAMES[0], command);
            Assert.AreEqual(1, _episodes[0].CommandList.Count);
            Assert.IsTrue(_episodes[0].IsRead);
            command = "";
            _series.Record(EPISODE_NAMES[1], command);
            Assert.AreEqual(0, _episodes[1].CommandList.Count);
            Assert.IsTrue(_episodes[1].IsRead);
        }

        private List<Episode> GetEpisodes()
        {
            return new PrivateObject(_series).GetFieldOrProperty("_episodes") as List<Episode>;
        }
    }
}
