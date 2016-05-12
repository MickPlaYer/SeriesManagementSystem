using Newtonsoft.Json;
using SeriesManagementSystem.Domain;
using SeriesManagementSystem.Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriesManagementSystemUnitTest.FakeItem
{
    public class FakeFileSystem : IFileSystem
    {
        private string _content = "[]";

        public void ImportFile(string filePath)
        {
            // Empty
        }

        public void LoadFile(string localStorage)
        {
            // Empty
        }

        public void SaveFile(string localStorage, string content)
        {
            _content = localStorage + content;
        }

        public string Content
        {
            get { return _content; }
        }

        public void PrepareImportFile(string fileContext)
        {
            _content = fileContext;
        }
    }
}
