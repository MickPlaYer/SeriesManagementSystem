using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeriesManagementSystem.Domain;

namespace SeriesManagementSystemUnitTest
{
    [TestClass]
    public class EpisodeUnitTest
    {
        Episode _episode;
        const string EPISODE_NAME = "episode name";
        const string EPISODE_DESCRIPTION = "epispode description";
        const string MODIFIED_NAME = "modified name";
        const string MODIFIED_DESCRIPTION = "modified description";

        [TestInitialize]
        public void Initialize()
        {
            _episode = new Episode(EPISODE_NAME, EPISODE_DESCRIPTION);
        }

        [TestMethod]
        public void TestProperties()
        {
            Assert.AreEqual(EPISODE_NAME, _episode.Name);
            Assert.AreEqual(EPISODE_DESCRIPTION, _episode.Description);

            _episode.Name = MODIFIED_NAME;
            _episode.Description = MODIFIED_DESCRIPTION;
            Assert.AreEqual(MODIFIED_NAME, _episode.Name);
            Assert.AreEqual(MODIFIED_DESCRIPTION, _episode.Description);
        }
    }
}
