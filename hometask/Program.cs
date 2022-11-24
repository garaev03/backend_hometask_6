using System.Diagnostics.CodeAnalysis;

namespace hometask_6
{
    internal class Program
    {
        public  static bool MilkOrNot=false;
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("-----------------------");
                Console.WriteLine("ENTER PRODUCT");
                Console.Write("ENTER PRODUCT NAME: ");
                string name = Console.ReadLine();
                Product products = new(name);
                Console.Write("ENTER PRODUCT PRICE: ");
                products.Price = Convert.ToDouble(Console.ReadLine());
                Console.Write("ENTER PRODUCT COUNT: ");
                products.Count = Convert.ToInt32(Console.ReadLine());

                if (name == "milk" || name == "Milk")
                {
                    MilkOrNot = true;
                    Console.Write("ENTER MILK VOLUME: ");
                    Milk.Volume = Convert.ToDouble(Console.ReadLine());
                    Console.Write("ENTER MILK FATRATE:");   
                    Milk.FatRate = Convert.ToDouble(Console.ReadLine());
                }
                Console.WriteLine("PRODUCT HAS BEEN ADDED!");
                Console.WriteLine("-----------------------");
                Console.WriteLine();
                Console.WriteLine("1.SEE THE PRODUCT DETAILS");
                Console.WriteLine("2.SELL PRODUCT");
                Console.WriteLine("3.SEE THE TOTAL INCOME");
                Console.WriteLine("4.EXIT");
                Console.WriteLine("-----------------------");
                Console.WriteLine();

                while (true)
                {
                    Console.WriteLine();
                    Console.Write("ENTER A KEY: ");
                    int value = Convert.ToInt32(Console.ReadLine());
                    switch (value)
                    {
                        case 1:
                            products.ProductDetails();
                            break;
                        case 2:
                            products.Sell();
                            break;
                        case 3:
                            Console.WriteLine("TOTAL INCOME IS: " + products.TotalInCome);
                            break;
                        case 4:
                            return;
                    }
                }

            }
        }
    }
}