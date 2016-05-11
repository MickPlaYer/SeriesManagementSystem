using SeriesManagementSystem.Foundation;
using System;
using System.Net;

namespace SeriesManagementSystemUnitTest.TestItem
{
    public class TestServer : IServer
    {
        public string GetData()
        {
            throw new WebException();
        }
    }
}
