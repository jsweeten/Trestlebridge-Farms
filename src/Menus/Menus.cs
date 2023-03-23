using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trestlebridge.Menus
{
    public class Menus
    {
        
        // Main Menu
        public static void MainMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1. Create Facility");
            Console.WriteLine("2. Purchase Animals");
            Console.WriteLine("3. Purchase Seeds");
            Console.WriteLine("4. Processing Options");
            Console.WriteLine();
            Console.WriteLine("0. End Simulation");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Choose A FARMS Option:");
        }

        // Create Facility Menu
        public static void FacilityMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1. Grazing Field");
            Console.WriteLine("2. Ploughed Field");
            Console.WriteLine("3. Natural Field");
            Console.WriteLine("4. Chicken House");
            Console.WriteLine("4. Duck House");
            Console.WriteLine();
            Console.WriteLine("Choose a facility to create:");
        }

        //Animal Purchase Menu
        public static void AnimalPurchaseMenu()
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
        public static void SeedPurchaseMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1. Sesame");
            Console.WriteLine("2. Sunflower");
            Console.WriteLine("3. Wildflower");
            Console.WriteLine();
            Console.WriteLine("Choose seeds to purchase:");
        }

        //Processing Menu
        public static void ProcessingMenu()
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
