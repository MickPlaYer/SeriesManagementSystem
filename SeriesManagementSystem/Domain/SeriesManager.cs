using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace SeriesManagementSystem.Domain
{
    public class SeriesManager
    {
        private List<Series> _series = null;
        private Series _selectedSeries;
        private int _count = 0;

        #region Constructor
        public SeriesManager(string list)
        {
            _series = JsonConvert.DeserializeObject<List<Series>>(list) as List<Series>;
            InitializeCount();
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

        public string SeriesListString
        {
            get
            {
                return JsonConvert.SerializeObject(_series);
            }
        }
        #endregion

        public void AddSeries(String name, String description)
        {
            Series series = new Series(name, description, _count++);
            _series.Add(series);
        }

        public void AddList(string content)
        {
            List<Series> list = JsonConvert.DeserializeObject<List<Series>>(content) as List<Series>;
            foreach (Series series in list)
            {
                series.SeriesID = _count++;
            }
            _series.AddRange(list);
        }

        public void SelectSeries(int sid)
        {
            _selectedSeries = _series.Find((x) => x.SeriesID == sid);
        }

        public void ModifySelectedSeries(string newName, string newDescription)
        {
            _selectedSeries.Name = newName;
            _selectedSeries.Description = newDescription;
        }

        public void RemoveSeries(int sid)
        {
            Series series = _series.Find((s) => s.SeriesID == sid);
            _series.Remove(series);
        }

        private void InitializeCount()
        {
            if (_series.Count != 0)
            {
                _count = _series[_series.Count - 1].SeriesID + 1;
            }
        }
    }
}
