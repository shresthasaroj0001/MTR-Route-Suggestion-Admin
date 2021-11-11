using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Model
{
    class WebApiConnection
    {
        public HttpClient _client;
        public HttpResponseMessage _responseMessage;
        public WebApiConnection()
        {
            _client = new HttpClient();
            var BASEURL = ConfigurationManager.AppSettings["WebApiURL"];
            _client.BaseAddress = new Uri(BASEURL + "/");
            _client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
