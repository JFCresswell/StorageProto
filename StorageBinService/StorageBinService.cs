using StorageBin.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace StorageBinService
{
    public class StorageBinService : IStorageBinService
    {
        private BatchRepository batchRepository = new BatchRepository();

        public string Add(string batchBarcode, string binBarcode)
        {
            return "not implemented";
        }

        public string Remove(string batchBarcode)
        {
            return "not implemented";
        }

        public string ReturnToStock(string batchBarcode)
        {
            return "not implemented";
        }

        public string Bins()
        {
            return "not implemented";
        }
    }
}
