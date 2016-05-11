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
        const string SERVER_URL = @"https://script.google.com/macros/s/AKfycbyYu-99imRw9KZ3osDFbzbVHscLB4nWVMlc2G2JDV9cB98889L2/exec";

        public string GetData()
        {
            string data;
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(SERVER_URL);
            request.Method = "GET";
            using (WebResponse wr = request.GetResponse())
            {
                using (Stream s = wr.GetResponseStream())
                {
                    using (StreamReader sr = new StreamReader(s, Encoding.UTF8))
                    {
                        data = sr.ReadToEnd();
                    }
                }
            }
            return data;
        }
    }
}
