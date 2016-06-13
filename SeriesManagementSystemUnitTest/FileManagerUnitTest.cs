using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeriesManagementSystem.Foundation;
using System;
using System.IO;
using System.Text;

namespace SeriesManagementSystemUnitTest
{
    [TestClass]
    public class FileManagerUnitTest
    {
        private FileManager _fileManager;
        private PrivateObject _privateObject;
        private const string LOCAL_STORAGE = "./testFileManager.txt";
        private const string EMPTY_CONTENT = "{\"_series\":[],\"_followingList\":[],\"_unfollowingList\":[]}";

        [TestInitialize()]
        public void Initialize()
        {
            _fileManager = new FileManager();
            _privateObject = new PrivateObject(_fileManager, new PrivateType(typeof(FileManager)));
            Assert.AreEqual(EMPTY_CONTENT, _privateObject.GetField("_content"));
        }

        [TestCleanup]
        public void CleanUp()
        {
            if (File.Exists(LOCAL_STORAGE))
                File.Delete(LOCAL_STORAGE);
        }

        [TestMethod]
        public void TestLoadFile()
        {
            string testString = "Gorira parrrrrrty";
            _fileManager.LoadFile(LOCAL_STORAGE);
            Assert.AreEqual(EMPTY_CONTENT, _privateObject.GetField("_content"));
            PrepareFile(LOCAL_STORAGE, testString);
            _fileManager.LoadFile(LOCAL_STORAGE);
            Assert.AreEqual(testString, _privateObject.GetField("_content"));
        }

        [TestMethod]
        public void TestGetContent()
        {
            string testString = "Banana usually drop.";
            _privateObject.SetField("_content", testString);
            Assert.AreEqual(testString, _fileManager.Content);
        }

        [TestMethod]
        public void TestImportFile()
        {
            string testString = "Why monkey can't talk?";
            PrepareFile(LOCAL_STORAGE, testString);
            _fileManager.ImportFile(LOCAL_STORAGE);
            Assert.AreEqual(testString, _privateObject.GetField("_content"));
        }

        [TestMethod]
        public void TestSaveFile()
        {
            string testString = "Super monkey fly bat.";
            PrepareFile(LOCAL_STORAGE, "[]");
            _fileManager.SaveFile(LOCAL_STORAGE, testString);
            // test the file contains the string
            String fileContext;
            using (var streamReader = new StreamReader(LOCAL_STORAGE, Encoding.UTF8))
            {
                fileContext = streamReader.ReadToEnd();
            }
            Assert.AreEqual(testString, fileContext);
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
