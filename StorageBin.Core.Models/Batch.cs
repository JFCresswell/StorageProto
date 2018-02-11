using System;
using System.Collections.Generic;
using System.Text;

namespace StorageBin.Core.Models
{
    public class Batch
    {
        public int Id { get; set; }

        public string Barcode { get; set; }

        public string StorageLocation { get; set; }
    }
}
