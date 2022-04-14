using System;
using System.Collections.Generic;
using System.Text;

namespace Medicine_Console_App.Custom_Exceptions
{
    class NotFoundException:Exception
    {
        public NotFoundException(string message) : base(message )
        {

        }
    }
}
