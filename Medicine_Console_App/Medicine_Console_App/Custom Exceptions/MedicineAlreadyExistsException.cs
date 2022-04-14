using System;
using System.Collections.Generic;
using System.Text;

namespace Medicine_Console_App.Custom_Exceptions
{
    class MedicineAlreadyExistsException:Exception
    {
        public MedicineAlreadyExistsException(string message) : base(message)
        {

        }
    }
}
