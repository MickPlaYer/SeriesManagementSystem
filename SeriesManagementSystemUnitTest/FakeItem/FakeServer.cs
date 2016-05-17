using SeriesManagementSystem.Foundation;
using System;
using System.Net;

namespace SeriesManagementSystemUnitTest.FakeItem
{
    public class FakeServer : IServer
    {
        public bool IsDownloadFail { get; set; }

        public FakeServer()
        {
            IsDownloadFail = false;
        }

        public string DownloadData()
        {
            if (IsDownloadFail)
                throw new WebException();
            else
                return "[{\"Name\":\"FakeServerSeries\",\"Description\":\":)\"}]";
        }
    }
}
