using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFAndJSON_Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceProduct" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceProduct.svc or ServiceProduct.svc.cs at the Solution Explorer and start debugging.
    public class ServiceProduct : IServiceProduct
    {
        [WebInvoke(Method = "GET", UriTemplate = "find", ResponseFormat = WebMessageFormat.Json)]
        public Product find()
        {
            return new Product { Id = "p01", Name = "Name 1", Price = 1000 };
        }

        [WebInvoke(Method = "GET", UriTemplate = "findall", ResponseFormat = WebMessageFormat.Json)]
        public List<Product> findAll()
        {
            List<Product> result = new List<Product>()
            {
                new Product { Id = "p01", Name = "Name 1", Price = 1000 },
                new Product { Id = "p02", Name = "Name 2", Price = 2000 },
                new Product { Id = "p03", Name = "Name 3", Price = 3000 }
            };
            return result;
        }
    }
}
