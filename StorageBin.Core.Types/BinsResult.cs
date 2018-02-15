﻿using StorageBin.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StorageBin.Core.Types
{
    public class BinsResult : Result
    {
        public List<Bin> Bins { get; set; }
    }
}
