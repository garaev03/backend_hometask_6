using System.Reflection.Metadata.Ecma335;

namespace sinif_task
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Bmw bmw = new();
            Audi audi = new();
            Mercedes merc = new();
            while (true)
            {
                Console.WriteLine("\n--------------------------");
                Console.WriteLine("WHICH CAR DO YO WANT?");
                Console.WriteLine("1. BMW");
                Console.WriteLine("2. MERCEDES");
                Console.WriteLine("3. AUDI");
                Console.WriteLine("--------------------------\n");
                Console.Write("ENTER KEY: ");
                int value = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nENTER MODEL: ");
                if (value == 1)
                {
                    bmw = new(Console.ReadLine());
                }
                else if (value == 2)
                {
                    merc = new(Console.ReadLine());
                }
                else if (value == 3)
                {
                    audi = new(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("PLEASE CHOOSE VALID CAR NAME");
                    continue;
                }
                Console.Write("ENTER FUEL: ");
                Cars.Fuel = Convert.ToDouble(Console.ReadLine());
                Console.Write("ENTER ODOMETR: ");
                Cars.Km = Convert.ToDouble(Console.ReadLine());
                Console.Write("ENTER CONSUMPTION: ");
                Cars.Consumption = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("----------------------------------");
                Console.WriteLine("WHAT DO YOU WANT TO DO?");
                Console.WriteLine("1.CHECK CAR'S FULL INFO");
                Console.WriteLine("2.CHECK FUEL");
                Console.WriteLine("3.CHECK KILOMETERES CAN BE DRIVEN");
                Console.WriteLine("4.CHECK SERVICE DETAILS");
                Console.WriteLine("5.EXIT");
                Console.WriteLine("----------------------------------");
                Console.WriteLine();
                while (true)
                {
                    Console.Write("ENTER KEY: ");
                    value = Convert.ToInt32(Console.ReadLine());
                    switch (value)
                    {
                        case 1:
                            Cars.CarDetails();
                            break;
                        case 2:
                            Console.WriteLine("CAR'S CURRET FUEL: "+Cars.Fuel+"L\n");
                            break;
                        case 3:
                            Cars.CheckKilometer();
                            break;
                        case 4:
                            Cars.CheckService();
                            break;
                        case 5:
                            return;
                    }
                }
            }
        }
    }
}