using SeriesManagementSystem.Foundation;
using System.Collections.Generic;

namespace SeriesManagementSystem.Domain
{
    public class Software
    {
        private SeriesManager _seriesManager;
        private FileManager _fileManager;
        private const string LOCAL_STOREAGE = "./dat/data.dat";

        public Software()
        {
            _fileManager = new FileManager(LOCAL_STOREAGE);
            _seriesManager = new SeriesManager(_fileManager.GetContent());
        }

        // Add a new series with name and description.
        public void AddSeries(string name, string description)
        {
            _seriesManager.AddSeries(name, description);
        }

        //Import series data from a file.
        public void ImportFile(string filePath)
        {
            _fileManager.ImportFile(filePath);
            _seriesManager.AddList(_fileManager.GetContent());
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
    }
}
