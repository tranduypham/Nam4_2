using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using xNet;

namespace Design_Dashboard_Modern
{
    class DataProvider
    {
        private HttpRequest http;
        private static DataProvider instance; // Ctrl + R + E
        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
            
    }
        


        private DataProvider()
        {
            http = new HttpRequest();
           // http.AddHeader("Authorization", authen);
        }

        public string PostData(string url, string data = null)
        {
            if (http == null)
            {
                http = new HttpRequest();
            }
            string html = http.Post(url, data, "application/json").ToString();
            return html;
        }

        public string GetData(string url)
        {
            if (http == null)
            {
                http = new HttpRequest();
            }
            string html = http.Get(url).ToString();
            return html;
        }
    }
}
