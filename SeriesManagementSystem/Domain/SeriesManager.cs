using System;
using System.Collections.Generic;

namespace SeriesManagementSystem.Domain
{
    public class SeriesManager
    {
        private List<Series> _series = null;
        private Series _selectedSeries;

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

        public Series SelectedSeries
        {
            get
            {
                return _selectedSeries;
            }
            private set
            {
                _selectedSeries = value;
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
            _series.AddRange(list);
        }

        public void SelectSeries(int sid)
        {
            _selectedSeries = _series.Find((x) => x.SeriesID == sid);
        }
    }
}
