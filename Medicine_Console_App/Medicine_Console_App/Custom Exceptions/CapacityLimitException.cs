using System;
using System.Collections.Generic;
using System.Text;

namespace Medicine_Console_App.Custom_Exceptions
{
    class CapacityLimitException:Exception
    {
        public CapacityLimitException(string message): base(message)
        {

        }
        
    }
}
