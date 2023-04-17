using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trestlebridge.Models;

namespace Trestlebridge.Menus
{
    public class FacilityMenu
    {
        public static void PurchaseFacilities(Farm Trestlebridge)
        {
            Console.WriteLine();
            Console.WriteLine("1. Grazing Field:");
            Console.WriteLine("Stores: Cows, Pigs, Goats, and Ostriches");
            Console.WriteLine("Capacity: 20");
            Console.WriteLine();
            Console.WriteLine("2. Ploughed Field:");
            Console.WriteLine("Stores: Sunflowers and Sesame");
            Console.WriteLine("Capacity: 13 rows of plants, 5 plants per row");
            Console.WriteLine();
            Console.WriteLine("3. Natural Field:");
            Console.WriteLine("Stores: Sunflowers and Wildflowers");
            Console.WriteLine("Capacity: 10 rows, 6 plants per row");
            Console.WriteLine();
            Console.WriteLine("4. Chicken Coop:");
            Console.WriteLine("Stores: Chickens");
            Console.WriteLine("Capacity: 15");
            Console.WriteLine();
            Console.WriteLine("5. Duck House:");
            Console.WriteLine("Stores: Ducks");
            Console.WriteLine("Capacity: 12");
            Console.WriteLine();
            Console.WriteLine("Choose a facility to create:");
            int input = Int32.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Trestlebridge.AddGrazingField();
                    Console.WriteLine("New Grazing Field Added.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Utils.Clear();
                    break;
                case 2:
                    Trestlebridge.AddPloughingField();
                    Console.WriteLine("New Ploughing Field Added.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Utils.Clear();
                    break;
                case 3:
                    Trestlebridge.AddNaturalField();
                    Console.WriteLine("New Natural Field Added.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Utils.Clear();
                    break;
                case 4:
                    Trestlebridge.AddChickenCoop();
                    Console.WriteLine("New Chicken Coop Added.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Utils.Clear();
                    break;
                case 5:
                    Trestlebridge.AddDuckHouse();
                    Console.WriteLine("New Duck House Added.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Utils.Clear();
                    break;
            }
        }
    }
}
