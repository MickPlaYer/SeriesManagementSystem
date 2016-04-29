using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeriesManagementSystem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SeriesManagementSystemUnitTest
{
    [TestClass]
    public class SeriesManagerUnitTest
    {
        SeriesManager _seriesManager;
        Series[] _series;
        const String SeriesName = "manager's series";
        const String SeriesDescription = "it is a series' description of manager";
        const int SeriesID = 1;

        [TestInitialize]
        public void Initialize()
        {
            _seriesManager = new SeriesManager();
            _series = new Series[3];
            for (int i = 0; i < 3; i++)
            {
                _series[i] = new Series(SeriesName + i.ToString(), SeriesDescription + i.ToString(), SeriesID + i);
            }
        }

        /// <summary>
        /// Test function of AddSeries
        /// </summary>
        [TestMethod]
        public void TestAdd()
        {
            // test AddSeries function with one parameter, series
            _seriesManager.AddSeries(_series[0]);
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
            _seriesManager.AddList(seriesList);
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
            _seriesManager.AddList(new List<Series>(_series));

            // test initialization of selected series is empty
            Assert.IsNull(_seriesManager.SelectedSeries);

            // test selected series after selecting the series
            _seriesManager.SelectSeries(2);
            Assert.AreEqual(_seriesManager.SelectedSeries, _series[1]);
            _seriesManager.SelectSeries(1);
            Assert.AreEqual(_seriesManager.SelectedSeries, _series[0]);
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
