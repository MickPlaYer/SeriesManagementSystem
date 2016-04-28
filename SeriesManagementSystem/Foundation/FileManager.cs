using Newtonsoft.Json;
using SeriesManagementSystem.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriesManagementSystem.Foundation
{
    public class FileManager
    {
        private List<Series> _list = new List<Series>();

        public void ImportFile(string filePath)
        {
            String fileContext;
            using (var streamReader = new StreamReader(filePath, Encoding.UTF8))
            {
                fileContext = streamReader.ReadToEnd();
            }
            _list = JsonConvert.DeserializeObject<List<Series>>(fileContext) as List<Series>;
        }

        public List<Series> GetList()
        {
            return _list;
        }
    }
}
