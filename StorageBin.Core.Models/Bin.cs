using System;
using System.Collections.Generic;
using System.Text;

namespace StorageBin.Core.Models
{
    public class Bin
    {
        int Id { get; set; }

        string Barcde { get; set; }

        List<Batch> Batches { get; set; }
    }
}
