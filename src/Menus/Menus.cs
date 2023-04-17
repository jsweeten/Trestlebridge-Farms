using System;
using Trestlebridge.Models;
using Trestlebridge.Models.Facilities;
using Trestlebridge.Models.Animals;
using System.Collections.Generic;
using Trestlebridge.Models.Plants;
using System.Linq;
using System.Reflection;

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
            var input = Int32.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Utils.Clear();
                    FacilityMenu.PurchaseFacilities(Trestlebridge);
                    break;
                case 2:
                    Utils.Clear();
                    AnimalMenu.PurchaseAnimals(Trestlebridge);
                    break;
                case 3:
                    Utils.Clear();
                    SeedMenu.PurchaseSeeds(Trestlebridge);
                    break;
                case 4:
                    Utils.Clear();
                    ProcessingMenu.ProcessResources(Trestlebridge);
                    break;
                case 0:
                    Utils.Clear();
                    Trestlebridge.InventoryReport();
                    break;
            }
        }
    }
}
