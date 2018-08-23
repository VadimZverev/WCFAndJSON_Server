using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Script.Serialization;

namespace WCFAndJSON_Client.Models
{
    public class ProductServicClient
    {
        private string BASE_URL = "http://localhost:32171/ServiceProduct.svc/";

        public Product Find()
        {
            var syncClient = new WebClient();
            var content = syncClient.DownloadString(BASE_URL + "find");
            var json_serializer = new JavaScriptSerializer();
            return json_serializer.Deserialize<Product>(content);
        }

        public List<Product> FindAll()
        {
            var syncClient = new WebClient();
            var content = syncClient.DownloadString(BASE_URL + "findall");
            var json_serializer = new JavaScriptSerializer();
            return json_serializer.Deserialize<List<Product>>(content);
        }
    }
}