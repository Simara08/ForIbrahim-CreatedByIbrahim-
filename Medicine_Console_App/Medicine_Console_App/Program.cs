using System;
using System.Collections.Generic;
using Medicine_Console_App.Custom_Exceptions;

namespace Medicine_Console_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Medicine medicine1 = new Medicine("basagri", 0.2, 3);
            Medicine medicine2 = new Medicine("basagri2", 0.23, 6);
            Medicine medicine3 = new Medicine("basagriasxa", 0.2, 3);
            Medicine medicine4 = new Medicine("basagri2asx", 22323, 612);
            Pharmacy pharmacy = new Pharmacy(5);

            pharmacy.AddMedicine(medicine1);
            pharmacy.AddMedicine(medicine2);
            pharmacy.AddMedicine(medicine3);
            pharmacy.AddMedicine(medicine4);
            

            pharmacy.EditMedicineEmail(1, "dfgdg");
            pharmacy.GetAllMedicines();
        }
    }
}
