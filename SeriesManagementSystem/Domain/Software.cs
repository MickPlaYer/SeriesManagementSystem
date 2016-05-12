using SeriesManagementSystem.Foundation;
using System.Collections.Generic;
using System.Net;

namespace SeriesManagementSystem.Domain
{
    public class Software
    {
        private SeriesManager _seriesManager;
        private FileManager _fileManager;
        private bool _isNoInternet = false;
        private bool _isImportFail = false;
        private const string LOCAL_STOREAGE = "./dat/data.dat";

        public Software()
        {
            _fileManager = new FileManager(LOCAL_STOREAGE);
            _seriesManager = new SeriesManager(_fileManager.GetContent());
            AddServerData(new Server());
        }

        public void AddServerData(IServer server)
        {
            try { _seriesManager.AddServerData(server.GetData()); }
            catch (WebException) { _isNoInternet = true; }
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
            try { _seriesManager.AddList(_fileManager.GetContent()); }
            catch { _isImportFail = true; }
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
            _fileManager.SaveFile(list);
        }

        public SeriesManager GetSeriesManager()
        {
            return _seriesManager;
        }

        public bool IsNoInternet
        {
            get { return _isNoInternet; }
        }

        public bool IsImportFail
        {
            get { return _isImportFail; }
        }
    }
}
