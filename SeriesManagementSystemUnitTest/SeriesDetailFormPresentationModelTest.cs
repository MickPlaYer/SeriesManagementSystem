using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeriesManagementSystem.Domain;
using SeriesManagementSystem.UI.ViewModel;

namespace SeriesManagementSystemUnitTest
{
    [TestClass]
    public class SeriesDetailFormPresentationModelTest
    {
        SeriesDetailFormPresentationModel _pModel;
        Series _series;
        const string SERIES_NAME = "series name";
        const string SERIES_DES = "series des";
        const string EPISODE_NAME = "episode name";
        const string EPISODE_DES = "episode des";

        [TestInitialize]
        public void Initialize()
        {
            _series = new Series(SERIES_NAME, SERIES_DES);
            _pModel = new SeriesDetailFormPresentationModel(_series);
        }

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(SERIES_DES, _pModel.SeriesDescription);
            Assert.AreEqual(SERIES_NAME, _pModel.SeriesName);
            Assert.AreEqual(0, _pModel.EpisodeNumber);

            _series.AddEpisode(EPISODE_NAME, EPISODE_DES);
            Assert.AreEqual(1, _pModel.EpisodeNumber);
        }
    }
}
