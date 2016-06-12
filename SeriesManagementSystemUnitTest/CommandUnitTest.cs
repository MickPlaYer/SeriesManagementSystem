using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeriesManagementSystem.Domain;

namespace SeriesManagementSystemUnitTest
{
    [TestClass]
    public class CommandUnitTest
    {
        private Command _command;
        private const string DEFAULT_CONTENT = "It's good.";

        [TestInitialize()]
        public void Initialize()
        {
            _command = new Command(DEFAULT_CONTENT);
        }

        [TestMethod]
        public void TestGetContent()
        {
            Assert.AreEqual(DEFAULT_CONTENT, _command.Context);
        }
    }
}
