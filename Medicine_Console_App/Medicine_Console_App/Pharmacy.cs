using System;
using System.Collections.Generic;
using System.Text;
using Medicine_Console_App.Custom_Exceptions;

namespace Medicine_Console_App
{
    class Pharmacy
    {
        public int MedicineLimit { get; set; }
        public List<Medicine> Medicines ;

        public Pharmacy(int medlimit)
        {
            MedicineLimit = medlimit;
            Medicines = new List<Medicine>(MedicineLimit);
        }
        public void AddMedicine(Medicine medicine)
        {
            if (Medicines.Count==0)
            {
                Medicines.Add(medicine);
            }
            else
            {
                foreach (var item in Medicines)
                {

                    if (item.Name.Equals(medicine.Name))
                    {
                        throw new MedicineAlreadyExistsException("Bu derman artiq movcuddur!!");
                    }
                    else if (Medicines.Count > MedicineLimit)
                    {
                        throw new CapacityLimitException("Derman saxlamaq ucun yeteri qeder hecm yoxdur!!");
                    }
                    else
                    {
                        Medicines.Add(medicine);
                        break;
                    }

                }
            }
            
        }
        public void GetAllMedicines()
        {
            
            foreach (var item in Medicines)
            { 
                if (item.IsDeleted)
                {
                    return;
                }
                Console.WriteLine($"Medicine Count: {item.Count}\nMedicine Name: {item.Name}\nMedicine Price: {item.Price}\n");
            }
        }
        public void FilterMedicinesByPrice(int min, int max)
        {
            int count = 0;
            List<Medicine> FilteredMedicines = new List<Medicine>();

            foreach (var item in Medicines)
            {
                if (item.Price > min && item.Price < max)
                {
                    FilteredMedicines.Add(item);
                    count++;
                }
            }
            if (count == 0)
            {
                throw new NotFoundException("Hal hazirda bu derman depoda movcud deyil!!");
            }
            else
            {
                FilteredMedicines.Sort((x, y) => x.Price.CompareTo( y.Price));
                foreach (var item in FilteredMedicines)
                {
                    Console.WriteLine($"Medicine Count: {item.Count}\nMedicine Name: {item.Name}\nMedicine Price: {item.Price}\n");
                }
            }

        }
        
        public void GetMedicineById(int? id)
        {
            if (id == null)
            {
                throw new NullReferenceException("Bu id movcud deyil!!");
            }
            foreach (var item in Medicines)
            {
                if (item.Id == id && item.IsDeleted==false)
                {
                    Console.WriteLine($"Medicine Count: {item.Count}\nMedicine Name: {item.Name}\nMedicine Price: {item.Price}\n");
                }

            }
        }
        public void DeleteMedicineById(int? id)
        {
            if (id == null)
            {
                throw new NullReferenceException("Bu id movcud deyil!!");
            }
            int count = 0;
            foreach (var item in Medicines)
            {
                if (item.Id == id && item.IsDeleted == false)
                {
                    item.IsDeleted = true;
                    count++;
                }
            }
            if (count == 0)
            {
                throw new NotFoundException("Hal hazirda bu derman depoda movcud deyil!!");
            }
        }
        public void EditMedicineEmail(int? id,string name)
        {
            if (id == null)
            {
                throw new NullReferenceException("Bu id movcud deyil!!");
            }
            int count = 0;
            foreach (var item in Medicines)
            {
                if (item.Id == id && item.IsDeleted == false)
                {
                    item.Name = name;
                    count++;
                }
            }
            if (count == 0)
            {
                throw new NotFoundException("Hal hazirda bu derman depoda movcud deyil!!");
            }
        }

    }
}
