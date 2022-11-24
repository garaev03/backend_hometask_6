using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hometask_6
{
    internal class Product
    {
        private string _name;
        private double _price;
        private int _count;
        private bool active = true;
        public string Name
        {
            get => _name;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _name = value;
                else
                {
                    while (string.IsNullOrWhiteSpace(value))
                    {
                        Console.WriteLine("PLEASE ENTER VALID NAME");
                        value = Console.ReadLine();
                    }
                    _name = value;
                }
            }
        }
        public double Price
        {
            get => _price;
            set
            {
                if (value > 0)
                    _price = value;
                else
                {
                    while (value <= 0)
                    {
                        if (value == 0)
                            Console.WriteLine("IS IT FREE?!\n");
                        else
                        {
                            Console.WriteLine("PRICE CANNOT BE UNDER ZERO\n");
                        }
                        Console.Write("ENTER PRODUCT PRICE: ");
                        value = Convert.ToInt32(Console.ReadLine());
                    }
                    _price = value;
                }
            }
        }
        public int Count
        {
            get => _count;
            set
            {
                while (value < 0)
                {
                    Console.WriteLine("PLEASE ENTER A VALID NUMBER");
                    value = Convert.ToInt32(Console.ReadLine());
                }
                _count = value;
            }
        }

        public double TotalInCome;

        public Product(string name)
        {
            Name = name;
        }

        protected Product()
        {

        }
        public void ProductDetails()
        {
            Console.WriteLine("PRODCUT NAME: " + Name);
            Console.WriteLine("PRODCUT PRICE: " + Price);
            Console.WriteLine("PRODCUT Count: " + Count);
            if (Program.MilkOrNot)
            {
                Milk.getMilk();
            }
        }
        public void Sell()
        {
            if (Count > 0)
            {
                Console.WriteLine("1 PRODUCT HAS BEEN SOLD!\n");
                Count = Count - 1;
                TotalInCome += Price;
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("THERE IS NO PRODUCT LEFT!\n");
            }
        }
    }
}
