
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
