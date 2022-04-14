using System;
using System.Collections.Generic;
using System.Text;

namespace Medicine_Console_App
{
    class Medicine
    {
        private static int _id;
        public int Id { get;  }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public bool IsDeleted { get; set; } 

        public Medicine()
        {
            _id++;
            Id = _id;
            IsDeleted = false;
        }
        public Medicine(string name,double price,int count)
        {
            Name = name;
            Price = price;
            Count = count;
        }

        public void Sell()
        {
            IsDeleted = true;
            Count--;
            
        }
        
        public void ShowInfo()
        {
            Console.WriteLine($"Medicine Count: {Count}\nMedicine Name: {Name}\nMedicine Price: {Price}");
        }
    }
}
