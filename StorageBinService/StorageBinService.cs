using StorageBin.Core.Repository;
using StorageBin.Core.Types;
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

        public Result Add(string batchBarcode, string binBarcode)
        {
            return new Result();
        }

        public Result Remove(string batchBarcode)
        {
            return new Result();
        }

        public Result ReturnToStock(string batchBarcode)
        {
            return new Result();
        }

        public BinResult Bin(string binBarcode)
        {
            return new BinResult();
        }

        public BinsResult Bins()
        {
            return new BinsResult();
        }
    }
}
