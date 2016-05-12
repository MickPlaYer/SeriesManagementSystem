using SeriesManagementSystem.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SeriesManagementSystem.Foundation
{
    public class Server : IServer
    {
        const string SERVER_URL = @"https://script.google.com/macros/s/";

        public string DownloadData()
        {
            string data;
            string url = SERVER_URL + Resources.GoogleWebAppID;
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
            request.Method = "GET";
            using (WebResponse wr = request.GetResponse())
            {
                using (StreamReader sr = new StreamReader(wr.GetResponseStream(), Encoding.UTF8))
                {
                    data = sr.ReadToEnd();
                }
            }
            return data;
        }
    }
}
