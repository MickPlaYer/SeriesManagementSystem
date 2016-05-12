using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using SeriesManagementSystem.Domain;
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
            data = _server.DownloadData();
            List<Series> series = JsonConvert.DeserializeObject<List<Series>>(data);
            Series s = series[0];
            Assert.IsTrue(series.Count > 0);
            Assert.AreEqual(-20, s.SeriesID);
        }
    }
}
