using System;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;
using System.Collections.Generic;

namespace Trestlebridge.Menus
{
    public class Menus
    {
        // Main Menu
        public static void MainMenu(Farm Trestlebridge)
        {
            Utils.Clear();
            Console.WriteLine();
            Console.WriteLine("1. Create Facility");
            Console.WriteLine("2. Purchase Animals");
            Console.WriteLine("3. Purchase Seeds");
            Console.WriteLine("4. Processing Options");
            Console.WriteLine();
            Console.WriteLine("0. Inventory");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Choose A FARMS Option:");
            int input = Int32.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Utils.Clear();
                    FacilityMenu(Trestlebridge);
                    break;
                case 2:
                    Utils.Clear();
                    AnimalPurchaseMenu(Trestlebridge);
                    break;
                case 3:
                    Utils.Clear();
                    SeedPurchaseMenu(Trestlebridge);
                    break;
                case 4:
                    Utils.Clear();
                    ProcessingMenu(Trestlebridge);
                    break;
                case 0:
                    Utils.Clear();
                    Trestlebridge.InventoryReport();
                    break;
            }
        }

        // Create Facility Menu
        public static void FacilityMenu(Farm Trestlebridge)
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
            Console.WriteLine("4. Chicken House:");
            Console.WriteLine("Stores: Chickens");
            Console.WriteLine("Capacity: 15");
            Console.WriteLine();
            Console.WriteLine("4. Duck House:");
            Console.WriteLine("Stores: Ducks");
            Console.WriteLine("Capacity: 12");
            Console.WriteLine();
            Console.WriteLine("Choose a facility to create:");
            int input = Int32.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Utils.Clear();
                    var field = new GrazingField();
                    Trestlebridge.AddGrazingField(field);
                    Console.WriteLine("New Grazing Field Added.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;
                case 2:
                    Utils.Clear();
                    
                    break;
                case 3:
                    Utils.Clear();
                    
                    break;
                case 4:
                    Utils.Clear();
                    
                    break;
            }
        }

        //Animal Purchase Menu
        public static void AnimalPurchaseMenu(Farm Trestlebridge)
        {
            Console.WriteLine();
            Console.WriteLine("1. Chicken");
            Console.WriteLine("2. Cow");
            Console.WriteLine("3. Duck");
            Console.WriteLine("4. Goat");
            Console.WriteLine("5. Ostrich");
            Console.WriteLine("6. Pig");
            Console.WriteLine("7. Sheep");
            Console.WriteLine();
            Console.WriteLine("Choose an animal to purchase:");
        }

        //Seed Purchase Menu
        public static void SeedPurchaseMenu(Farm Trestlebridge)
        {
            Console.WriteLine();
            Console.WriteLine("1. Sesame");
            Console.WriteLine("2. Sunflower");
            Console.WriteLine("3. Wildflower");
            Console.WriteLine();
            Console.WriteLine("Choose seeds to purchase:");
        }

        //Processing Menu
        public static void ProcessingMenu(Farm Trestlebridge)
        {
            Console.WriteLine();
            Console.WriteLine("1. Seed Harvester");
            Console.WriteLine("2. Meat Processor");
            Console.WriteLine("3. Egg Gatherer");
            Console.WriteLine("4. Composter");
            Console.WriteLine("5. Feather Harvester");
            Console.WriteLine();
            Console.WriteLine("Choose equipment to use:");
        }
    }
}
