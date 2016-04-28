using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeriesManagementSystem.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriesManagementSystemUnitTest
{
    [TestClass]
    public class SeriesManagerUnitTest
    {
        SeriesManager _seriesManager;
        Series[] _series;
        const String SeriesName = "manager's series";
        const String SeriesDescription = "it is a series' description of manager";

        [TestInitialize]
        public void Initialize()
        {
            _seriesManager = new SeriesManager();
            _series = new Series[3];
            for(int i = 0;i < 3;i++){
                _series[i] = new Series(SeriesName+i.ToString(), SeriesDescription+i.ToString());
            }
        }

        // Test function of AddSeries
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

        // test the function of AddRange with a parameter, List<Series>
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

        private List<Series> GetSeriesList()
        {
            return _seriesManager.SeriesList;
        }
    }
}
