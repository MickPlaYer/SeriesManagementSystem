using SeriesManagementSystem.Foundation;
using System;
using System.Collections.Generic;
using System.Net;

namespace SeriesManagementSystem.Domain
{
    public class Software
    {
        private SeriesManager _seriesManager;
        private IFileSystem _fileManager;
        private IServer _server;
        private bool _isNoInternet = false;
        private bool _isImportFail = false;
        private bool _isLoadFail = false;
        private const string LOCAL_STOREAGE = "./dat/data.dat";

        public Software(IServer server, IFileSystem fileManager)
        {
            _server = server;
            _fileManager = fileManager;
            _seriesManager = new SeriesManager();
            LoadFile();
            AddServerData();
        }

        private void LoadFile()
        {
            _isLoadFail = false;
            try
            {
                _fileManager.LoadFile(LOCAL_STOREAGE);
                _seriesManager.AddLoadedFile(_fileManager.Content);
            }
            catch (Exception)
            {
                _isLoadFail = true;
            }
        }

        public void AddServerData()
        {
            _isNoInternet = false;
            try
            {
                _seriesManager.AddServerData(_server.DownloadData());
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
                _seriesManager.AddList(_fileManager.Content);
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

        ~Software()
        {
            string list = _seriesManager.SeriesListString;
            _fileManager.SaveFile(LOCAL_STOREAGE, list);
        }

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
    }
}
