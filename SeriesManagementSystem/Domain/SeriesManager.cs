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
        }
        #endregion

        public void AddSeries(Series series)
        {
            _series.Add(series);
        }

        public void AddSeries(String name, String description)
        {
            Series series = new Series(name, description, 1);
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

        public void ModifySelectedSeries(string newName, string newDescription)
        {
            _selectedSeries.SetName(newName);
            _selectedSeries.SetDescription(newDescription);
        }
    }
}
