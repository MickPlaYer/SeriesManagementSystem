using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeriesManagementSystem.Foundation;
using System.IO;
using Newtonsoft.Json;
using System.Text;

namespace SeriesManagementSystemUnitTest
{
    [TestClass]
    public class FileManagerUnitTest
    {
        private FileManager _fileManager;
        private PrivateObject _privateObject;
        private const string LOCAL_STORAGE = "./testFileManager.txt";
        private const string  CONTENT = "[{ \"Name\":\"First Movie\", \"Description\":\"The first movie in the world.\" }]";

        [TestCleanup]
        public void CleanUp()
        {
            if (File.Exists(LOCAL_STORAGE))
                File.Delete(LOCAL_STORAGE);
        }

        [TestMethod]
        public void TestConstructor()
        {
            _fileManager = new FileManager(LOCAL_STORAGE);
            Assert.AreEqual(GetListString(), "[]");
            PrepareFile(LOCAL_STORAGE, "test");
            _fileManager = new FileManager(LOCAL_STORAGE);
            Assert.IsNotNull(_fileManager);
        }

        [TestMethod]
        public void TestGetList()
        {
            PrepareFile(LOCAL_STORAGE, CONTENT);
            _fileManager = new FileManager(LOCAL_STORAGE);
            Assert.IsTrue(_fileManager.GetContent() == CONTENT);
        }

        [TestMethod]
        public void TestImportFile()
        {
            PrepareFile(LOCAL_STORAGE, "[]");
            _fileManager = new FileManager(LOCAL_STORAGE);
            Assert.IsTrue(GetListString() == "[]");
        }

        [TestMethod]
        public void TestSaveFile()
        {
            PrepareFile(LOCAL_STORAGE, "[]");
            _fileManager = new FileManager(LOCAL_STORAGE);
            _fileManager.SaveFile(CONTENT);

            // test the file contains the string
            String fileContext;
            using (var streamReader = new StreamReader(LOCAL_STORAGE, Encoding.UTF8))
            {
                fileContext = streamReader.ReadToEnd();
            }
            Assert.AreEqual(fileContext, CONTENT);
        }

        private string GetListString()
        {
            _privateObject = new PrivateObject(_fileManager);
            return _fileManager.GetContent();
        }

        /// <summary>
        /// this function is used to prepare a file with some setting
        /// </summary>
        /// <param name="path">the file's location</param>
        /// <param name="content">file's content</param>
        private void PrepareFile(string path, string content)
        {
            using (var streamReader = new StreamWriter(path, false))
            {
                streamReader.Write(content);
            }
        }
    }
}
