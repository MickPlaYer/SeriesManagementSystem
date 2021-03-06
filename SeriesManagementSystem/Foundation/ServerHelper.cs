﻿using SeriesManagementSystem.Properties;
using System.IO;
using System.Net;
using System.Text;

namespace SeriesManagementSystem.Foundation
{
    public class ServerHelper : IServerHelper
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
