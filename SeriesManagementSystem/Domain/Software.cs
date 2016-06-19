using Newtonsoft.Json;
using SeriesManagementSystem.Foundation;
using System;
using System.Net;

namespace SeriesManagementSystem.Domain
{
    public class Software
    {
        private SeriesManager _seriesManager;
        private IFileSystem _fileManager;
        private IServerHelper _serverHelper;
        private bool _isNoInternet = false;
        private bool _isImportFail = false;
        private bool _isLoadFail = false;
        private const string LOCAL_STOREAGE = "./dat/data.dat";
        /// <summary>
        /// 0 => CheckBoxAll
        /// 1 => CheckBoxFollowing
        /// 2 => CheckBoxUnfollowing
        /// </summary>
        //private bool[] _checkBoxList = new bool[3];

        public Software(IServerHelper serverHelper, IFileSystem fileManager)
        {
            _serverHelper = serverHelper;
            _fileManager = fileManager;
            //_checkBoxList[0] = true;
            LoadFile();
            RefreshServerData();
        }

        private void LoadFile()
        {
            _isLoadFail = false;
            try
            {
                _fileManager.LoadFile(LOCAL_STOREAGE);
                _seriesManager = JsonConvert.DeserializeObject<SeriesManager>(_fileManager.Content);
            }
            catch (Exception)
            {
                _seriesManager = new SeriesManager();
                _isLoadFail = true;
            }
        }

        public void RefreshServerData()
        {
            _isNoInternet = false;
            try
            {
                _seriesManager.AddServerData(_serverHelper.DownloadData());
            }
            catch (WebException)
            {
                _isNoInternet = true;
            }
        }

        // Add a new series with name and description.
        public void AddSeries(string name, string description)
        {
            _seriesManager.AddSeries(name, description);
        }

        //Import series data from a file.
        public void ImportFile(string filePath)
        {
            _isImportFail = false;
            _fileManager.ImportFile(filePath);
            try
            {
                string content = _fileManager.Content;
                _seriesManager.AddList(content);
            }
            catch
            {
                _isImportFail = true;
            }
        }

        public void SelectSeries(int sid)
        {
            _seriesManager.SelectSeries(sid);
        }

        public void ModifySeries(string newName, string newDescription)
        {
            _seriesManager.ModifySelectedSeries(newName, newDescription);
        }

        public void RemoveSeries(int sid)
        {
            _seriesManager.RemoveSeries(sid);
        }

        public void FollowSeries()
        {
            _seriesManager.FollowSeries();
        }

        public void UnfollowSeries()
        {
            _seriesManager.UnfollowSeries();
        }

        public void RecoverSeries()
        {
            _seriesManager.RecoverSeries();
        }

        public void AddEpisode(string name, string description)
        {
            _seriesManager.AddEpisode(name, description);
        }

        public void Record(string name, string command)
        {
            _seriesManager.Record(name, command);
        }

        //public void SetCheckBoxesValue(int index, bool value)
        //{
        //    _checkBoxList = new bool[3] { false, false, false };
        //    _checkBoxList[index] = value;
        //    if (index == 0 && !value)
        //        _checkBoxList[index] = true;
        //    else if (index != 0 && !value)
        //        _checkBoxList[0] = true;

        //    if (value)
        //        _seriesManager.SetSeriesFlitter((SeriesListFlitter)index);
        //    else
        //        _seriesManager.SetSeriesFlitter(0);
        //}

        ~Software()
        {
            string list = _seriesManager.SeriesListString;
            _fileManager.SaveFile(LOCAL_STOREAGE, list);
        }

        #region Public Properties
        public SeriesManager SeriesManager
        {
            get
            {
                return _seriesManager;
            }
        }

        public bool IsNoInternet
        {
            get
            {
                return _isNoInternet;
            }
        }

        public bool IsImportFail
        {
            get
            {
                return _isImportFail;
            }
        }

        public bool IsLoadFail
        {
            get
            {
                return _isLoadFail;
            }
        }

        /// <summary>
        /// _checkBoxList => 0
        /// </summary>
        //public bool IsCheckBoxAll
        //{
        //    get
        //    {
        //        return _checkBoxList[0];
        //    }
        //}

        /// <summary>
        /// _checkBoxList => 1
        /// </summary>
        //public bool IsCheckBoxFollowing
        //{
        //    get
        //    {
        //        return _checkBoxList[1];
        //    }
        //}

        /// <summary>
        /// _checkBoxList => 2
        /// </summary>
        //public bool IsCheckBoxUnfollowing
        //{
        //    get
        //    {
        //        return _checkBoxList[2];
        //    }
        //}
        #endregion
    }
}
