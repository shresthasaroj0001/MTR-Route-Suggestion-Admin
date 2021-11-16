using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp2.Helper;

namespace WindowsFormsApp2.Helper
{
    class WebApiConnection
    {
        public HttpClient _client;
        public WebApiConnection()
        {
            _client = new HttpClient();
            var BASEURL = ConfigurationManager.AppSettings["WebApiURL"];
            _client.BaseAddress = new Uri(BASEURL + "/");
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
