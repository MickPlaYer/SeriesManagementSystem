using SeriesManagementSystem.Foundation;
using System.Collections.Generic;

namespace SeriesManagementSystem.Domain
{
    public class Software
    {
        private Series _selectedSeries;
        private SeriesManager _seriesManager;
        private FileManager _fileManager = new FileManager();

        public Software()
        {
            _seriesManager = new SeriesManager();
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
            List<Series> list = _fileManager.GetList();
            _seriesManager.AddList(list);
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
    }
}
