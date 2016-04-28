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

        public void Add(Series series)
        {
            _series.Add(series);
        }

        public void AddRange(List<Series> list)
        {
            _series.AddRange(list);
        }
    }
}
