using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeriesManagementSystem.Foundation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeriesManagementSystemUnitTest
{
    [TestClass]
    public class ServerUnitTest
    {
        Server _server;

        [TestInitialize]
        public void Initialize()
        {
            _server = new Server();
        }

        [TestMethod]
        public void TestGetData()
        {
            string data;
            data = _server.GetData();
            Assert.IsTrue(false);
        }
    }
}
