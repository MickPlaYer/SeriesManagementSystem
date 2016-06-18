﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace SeriesManagementSystem.Domain
{
    public enum SeriesListFlitter
    {
        All = 0,
        Following,
        Unfollowing
    }

    [JsonObject(MemberSerialization.OptIn)]
    public class SeriesManager
    {
        [JsonProperty]
        private List<Series> _series = new List<Series>();
        [JsonProperty]
        private List<Series> _followingList = new List<Series>();
        [JsonProperty]
        private List<Series> _unfollowingList = new List<Series>();
        private Series _selectedSeries;
        private int _count = 0;
        private bool _isExistNewOne = false;
        private SeriesListFlitter _seriesFlitter = SeriesListFlitter.All;

        #region Public Object
        public List<Series> SeriesList
        {
            get
            {
                switch (_seriesFlitter)
                {
                    case SeriesListFlitter.All:
                        return _series;
                    case SeriesListFlitter.Following:
                        return _followingList;
                    default:                // this is equal to SeriesListFlitter.Unfollowing
                        return _unfollowingList;
                }
            }
        }

        public List<Series> FollowingList 
        { 
            get
            {
                return _followingList;
            }
        }

        public List<Series> UnfollowingList
        {
            get
            {
                return _unfollowingList;
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
                return JsonConvert.SerializeObject(this);
            }
        }

        public bool IsExistNewOne
        {
            get
            {
                return _isExistNewOne;
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

        public void AddServerData(string content)
        {
            List<Series> list = JsonConvert.DeserializeObject<List<Series>>(content);
            _isExistNewOne = false;
            foreach (Series series in list)
            {
                if (_series.Find((s) => s.SeriesID == series.SeriesID) == null)
                {
                    _series.Add(series);
                    _isExistNewOne = true;
                }
            }
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

        public void FollowSeries()
        {
            _followingList.Add(_selectedSeries);
        }

        public void UnfollowSeries()
        {
            _followingList.Remove(_selectedSeries);
            _unfollowingList.Add(_selectedSeries);
        }

        public void RecoverSeries()
        {
            _unfollowingList.Remove(_selectedSeries);
            _followingList.Add(_selectedSeries);
        }

        public void AddEpisode(string name, string description)
        {
            _selectedSeries.AddEpisode(name, description);
        }

        public void Record(string name, string command)
        {
            _selectedSeries.Record(name, command);
        }

        public void SetSeriesFlitter(SeriesListFlitter flitter)
        {
            _seriesFlitter = flitter;
        }

        [OnDeserialized]
        private void InitializeCount(StreamingContext context)
        {
            if (_series.Count != 0)
            {
                _series.Sort((s1, s2) =>
                {
                    return s1.SeriesID - s2.SeriesID;
                });
                int count = _series[_series.Count - 1].SeriesID + 1;
                if (count > 0)
                    _count = count;
            }
        }
    }
}
