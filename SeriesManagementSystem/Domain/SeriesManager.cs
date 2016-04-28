using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriesManagementSystem.Domain
{
    public class SeriesManager
    {
        private List<Series> _series;

        #region Constructor
        public SeriesManager()
        {
            _series = new List<Series>();
        }

        public SeriesManager(List<Series> list)
        {
            _series = new List<Series>(list);
        }
        #endregion

        #region Public Object
        public List<Series> SeriesList
        {
            get
            {
                return _series;
            }
        }
        #endregion

        public void AddSeries(Series series)
        {
            _series.Add(series);
        }

        public void AddSeries(String name, String description)
        {
            Series series = new Series(name, description);
            AddSeries(series);
        }

        public void AddList(List<Series> list)
        {
            Console.WriteLine("in Test");
            Console.WriteLine(list.Count);
            _series.AddRange(list);
            Console.WriteLine(_series.Count);
            Console.WriteLine(_series[0].Name + "  " + _series[0].Description);
        }
    }
}
