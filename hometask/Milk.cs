using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace hometask_6
{

    internal class Milk:Product
    {
        private static double _volume;
        private static double _fatrate;
        public static double Volume
        {
            get => _volume;
            set
            {
                while (value <= 0)
                {
                    Console.WriteLine("PLEASE ENTER VALID VOLUME");
                    value=Convert.ToDouble(Console.ReadLine());
                }
                _volume = value;
            }
        }
        public static double FatRate
        {
            get => _fatrate;
            set
            {
                while (value < 0)
                {
                    Console.WriteLine("PLEASE ENTER VALID FATRATE");
                    value = Convert.ToDouble(Console.ReadLine());
                }
                _fatrate = value;
            }
        }

        public  static void getMilk()
        {   
            Console.WriteLine("MILK VOLUME: "+Volume);
            Console.WriteLine("MILK FATRATE: "+FatRate);
        }
    }
}
