using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SeriesManagementSystem.Foundation
{
    public interface IFileSystem
    {
        void ImportFile(string filePath);
        void LoadFile(string localStorage);
        void SaveFile(string localStorage, string content);
        string Content { get; }
    }
}
