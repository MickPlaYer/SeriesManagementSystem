using System;
using System.IO;
using System.Text;

namespace SeriesManagementSystem.Foundation
{
    public class FileManager : IFileSystem
    {
        private string _content = "{\"_series\":[],\"_followingList\":[],\"_unfollowingList\":[]}";

        public void ImportFile(string filePath)
        {
            String fileContext;
            using (var streamReader = new StreamReader(filePath, Encoding.UTF8))
            {
                fileContext = streamReader.ReadToEnd();
            }
            _content = fileContext;
        }

        public void LoadFile(string localStorage)
        {
            try { ImportFile(localStorage); }
            catch (Exception e)
            {
                if (e is FileNotFoundException | e is DirectoryNotFoundException)
                    _content = "{\"_series\":[],\"_followingList\":[],\"_unfollowingList\":[]}";
            }
        }

        public void SaveFile(string localStorage, string content)
        {
            using (var streamReader = new StreamWriter(localStorage, false))
            {
                streamReader.Write(content);
            }
        }

        public string Content
        {
            get { return _content; }
        }
    }
}
