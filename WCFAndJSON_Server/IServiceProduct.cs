using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFAndJSON_Server
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceProduct" in both code and config file together.
    [ServiceContract]
    public interface IServiceProduct
    {
        [OperationContract]
        Product find();

        [OperationContract]
        List<Product> findAll();
    }
}
