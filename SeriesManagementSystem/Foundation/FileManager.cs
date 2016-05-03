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
        private List<Series> _list;
        private const string LOCAL_STOREAGE = "./dat/data.dat";

        public FileManager()
        {
            try
            {
                ImportFile(LOCAL_STOREAGE);
            }
            catch (Exception e)
            {
                if (e is FileNotFoundException || e is DirectoryNotFoundException)
                {
                    _list = new List<Series>();
                }
                else
                    throw e;
            }
        }

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

        public void SaveFile(List<Series> series)
        {
            new FileInfo(LOCAL_STOREAGE).Directory.Create();
            using (FileStream fs = File.OpenWrite(LOCAL_STOREAGE))
            {
                string data = JsonConvert.SerializeObject(series);
                Byte[] info = new UTF8Encoding(true).GetBytes(data);
                fs.Write(info, 0, info.Length);
                fs.Close();
            }
        }
    }
}
