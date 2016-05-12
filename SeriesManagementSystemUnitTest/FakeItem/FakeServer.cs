using SeriesManagementSystem.Foundation;
using System;
using System.Net;

namespace SeriesManagementSystemUnitTest.FakeItem
{
    public class FakeServer : IServer
    {
        public bool TestDownLoadFail { get; set; }

        public FakeServer()
        {
            TestDownLoadFail = false;
        }

        public string DownloadData()
        {
            if (TestDownLoadFail)
                throw new WebException();
            else
                return "[{\"Name\":\"FakeServerSeries\",\"Description\":\":)\"}]";
        }
    }
}
