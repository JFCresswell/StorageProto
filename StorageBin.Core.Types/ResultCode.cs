using System;
using System.Collections.Generic;
using System.Text;

namespace StorageBin.Core.Types
{
    public enum ResultCode : Int32
    {
        // sample of decorators
        // [Description("Success"), XmlEnum("0"), Log("0: Success")]
        Success = 0,

        // warning range - if any
        // we may have results that aren't fatal to our processing


        // error range
    }
}
