using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sinif_task
{
    internal class Cars
    {
        private static string _model;
        private static double _fuel;
        private static double _km;
        private static int _consum;

        public static string Model
        {
            get => _model;
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    _model = value;
                else
                {
                    while (string.IsNullOrWhiteSpace(value))
                    {
                        Console.WriteLine("PLEASE ADD VALID NAME!");
                        value = Console.ReadLine();
                    }
                }
            }
        }
        public static double Fuel
        {
            get { return _fuel; }
            set
            {
                if (value >= 0)
                {
                    _fuel = value;
                    return;
                }
                else
                {
                    while (value < 0)
                    {
                        Console.WriteLine("PLEASE ADD VALID NUMBER!");
                        value = Convert.ToDouble(Console.ReadLine());
                    }
                }
            }
        }
        public static double Km
        {
            get { return _km; }
            set
            {
                if (value >= 0)
                {
                    _km = value;
                    return;
                }
                else
                {
                    while (value < 0)
                    {
                        Console.WriteLine("PLEASE ADD VALID NUMBER!");
                        value = Convert.ToDouble(Console.ReadLine());
                    }
                }
            }
        }
        public static int Consumption
        {
            get { return _consum; }
            set
            {
                if (value > 0)
                {
                    _consum = value;
                    return;
                }
                else
                {
                    while (value <= 0)
                    {
                        Console.WriteLine("PLEASE ADD VALID NUMBER!");
                        value = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }
        }
        protected Cars()
        {
        }
        protected Cars(string model)
        {
            Model = model;
            Console.WriteLine("GELDI");
        }
        public static void CarDetails()
        {
            Console.WriteLine("CAR MODEL: " + Cars.Model);
            Console.WriteLine("CAR Km: " + Cars.Km+"\n");
        }
        public static void CheckKilometer()
        {
            Console.WriteLine("KILOMETERS LEFT: " + (Fuel / Consumption) * 100+"\n");
        }
        public static void CheckService()
        {
            Console.WriteLine("SERVICES TILL TODAY: "+Convert.ToInt32(Km/5000));
            Console.WriteLine("NEXT SERVICE AFTER:"+(5000-(Km%5000))+" km\n");
        }
    }
}

