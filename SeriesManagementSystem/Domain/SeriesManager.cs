﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace SeriesManagementSystem.Domain
{
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

        #region Public Object
        public List<Series> SeriesList
        {
            get
            {
                return _series;
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
            if (_followingList.Contains(series))
                _followingList.Remove(series);
            if (_unfollowingList.Contains(series))
                _unfollowingList.Remove(series);
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

        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            InitializeCount();
            InitializeSeries();
        }

        private void InitializeCount()
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

        private void InitializeSeries()
        {
            List<Series> followingList = new List<Series>();
            List<Series> unfollowingList = new List<Series>();
            foreach (Series s in _followingList)
            {
                Series series = _series.Find((x) => x.SeriesID == s.SeriesID);
                followingList.Add(series);
            }
            foreach (Series s in _unfollowingList)
            {
                Series series = _series.Find((x) => x.SeriesID == s.SeriesID);
                unfollowingList.Add(series);
            }
            _followingList = followingList;
            _unfollowingList = unfollowingList;
        }
    }
}
