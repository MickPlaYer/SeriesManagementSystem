using SeriesManagementSystem.Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriesManagementSystem.Domain
{
    public class Software
    {
        private Series _selectedSeries;
        private FileManager _fileManager = new FileManager();
        private List<Series> _seriesList = new List<Series>();

        // Add a new series with name and description.
        public void AddSeries(string name, string description)
        {
            Series s = new Series(name, description);
            _seriesList.Add(s);
        }

        //Import series data from a file.
        public void ImportFile(string filePath)
        {
            _fileManager.ImportFile(filePath);
            List<Series> list = _fileManager.GetList();
            _seriesList.AddRange(list);
        }
    }
}
