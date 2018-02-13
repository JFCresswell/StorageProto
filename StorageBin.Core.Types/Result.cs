using System;
using System.Collections.Generic;
using System.Text;

namespace StorageBin.Core.Types
{
    public class Result
    {
        public Result ()
        {
            this.ResultCode = ResultCode.Success;
        }

        public ResultCode ResultCode { get; set; }
    }
}
