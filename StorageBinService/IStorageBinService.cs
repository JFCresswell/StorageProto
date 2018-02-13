using StorageBin.Core.Types;
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
        Result Add(string batchBarcode, string binBarcode);

        [OperationContract]
        Result Remove(string batchBarcode);

        [OperationContract]
        Result ReturnToStock(string batchBarcode);

        [OperationContract]
        Result Bins();
    }
}
