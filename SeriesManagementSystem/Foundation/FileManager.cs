using Newtonsoft.Json;
using SeriesManagementSystem.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SeriesManagementSystem.Foundation
{
    public class FileManager
    {
        private string _content;
        private string _localStorage;
        

        public FileManager(string localStorage)
        {
            try
            {
                ImportFile(localStorage);
            }
            catch (Exception e)
            {
                if (e is FileNotFoundException | e is DirectoryNotFoundException)
                {
                    _content = "[]";
                }
            }
            _localStorage = localStorage;
        }

        public void ImportFile(string filePath)
        {
            String fileContext;
            using (var streamReader = new StreamReader(filePath, Encoding.UTF8))
            {
                fileContext = streamReader.ReadToEnd();
            }
            _content = fileContext;
        }

        public string GetContent()
        {
            return _content;
        }

        public void SaveFile(string content)
        {
            new FileInfo(_localStorage).Directory.Create();
            using (FileStream fs = File.OpenWrite(_localStorage))
            {
                //string data = JsonConvert.SerializeObject(series);
                Byte[] info = new UTF8Encoding(true).GetBytes(content);
                fs.Write(info, 0, info.Length);
                fs.Close();
            }
        }
    }
}
