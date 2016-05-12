using SeriesManagementSystem.Foundation;
using System;
using System.Net;

namespace SeriesManagementSystemUnitTest.FakeItem
{
    public class FakeDeadServer : IServer
    {
        public string GetData()
        {
            throw new WebException();
        }
    }
}
