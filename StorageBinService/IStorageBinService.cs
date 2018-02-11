using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace StorageBinService
{
    [ServiceContract]
    public interface IStorageBinService
    {
        [OperationContract]
        string Add(string batchBarcode, string binBarcode);

        [OperationContract]
        string Remove(string batchBarcode);

        [OperationContract]
        string ReturnToStock(string batchBarcode);

        [OperationContract]
        string Bins();
    }
}
