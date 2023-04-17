using System;
using System.Collections.Generic;
using System.Text;
using Trestlebridge.Models.Facilities;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Plants;
using System.Reflection;
using System.Resources;

namespace Trestlebridge.Models
{
    public class Farm
    {
        // Properties
        public Dictionary<IFacility, int> Facilities { get; set; }
        public Dictionary<string, int> Animals { get; set; }
        public Dictionary<string, int> Plants { get; set; }
        public Dictionary<string, double> Products { get; set; }

        // Constructor

        public Farm()
        {
            Facilities = new()
            {
                { new GrazingField(), 0 },
                { new PloughingField(), 0 },
                { new NaturalField(), 0 },
                { new ChickenCoop(), 0 },
                { new DuckHouse(), 0 }
            };
            Animals = new()
            {
                { "Chickens", 0},
                { "Cows", 0 },
                { "Ducks", 0 },
                { "Goats", 0 },
                { "Ostriches", 0 },
                { "Pigs", 0 },
                { "Sheep", 0 }
            };
            Plants = new()
            {
                { "Wildflowers", 0},
                { "Sunflowers", 0 },
                { "Sesame", 0 }
            };
            Products = new()
            {
                { "Meat", 0 },
                { "Eggs", 0 },
                { "Feathers", 0 },
                { "SunflowerSeeds", 0 },
                { "SesameSeeds", 0 },
                { "Compost", 0 }
            };
        }
            

        public void InventoryReport()
        {
            Console.WriteLine("Here's your inventory report:");
            Console.WriteLine("-----------------------------");
            Console.WriteLine();
            Console.WriteLine("Facilities");
            Console.WriteLine();

            foreach (var Facility in Facilities)
            {
                Console.WriteLine($"{Facility.Key}s: {Facility.Value}");
                Console.WriteLine($"Total Capacity: {Facility.Key.Capacity * Facility.Value}");
            }

            Console.WriteLine();
            Console.WriteLine("Plants");
            Console.WriteLine();

            foreach (var Animal in Animals)
            {
                Console.WriteLine($"{Animal.Key}: {Animal.Value}");
            }

            Console.WriteLine();
            Console.WriteLine("Plants");
            foreach (var Plant in Plants)
            {
                Console.WriteLine($"{Plant.Key}: {Plant.Value}");
            }
            
            Console.WriteLine();
            Console.WriteLine("Products for Sale");
            Console.WriteLine();
            foreach (var product in Products)
            {
                Console.WriteLine($"{product.Key}: {product.Value}");
            }
            Console.WriteLine();
            Console.WriteLine("-----------------------------");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        public void AddGrazingField()
        {
            GrazingField field = new();
            if (Facilities.Keys.GetType() == field.GetType())
            {
                Facilities[field]++;
            }
        }
        public void AddPloughingField()
        {
            PloughingField field = new();
            if (Facilities.Keys.GetType() == field.GetType())
            {
                Facilities[field]++;
            }
        }
        public void AddNaturalField()
        {
            NaturalField field = new();
            if (Facilities.Keys.GetType() == field.GetType())
            {
                Facilities[field]++;
            }
        }
        public void AddChickenCoop()
        {
            ChickenCoop c = new();
            if (Facilities.Keys.GetType() == c.GetType())
            {
                Facilities[c]++;
            }
        }
        public void AddDuckHouse()
        {
            DuckHouse d = new();
            if (Facilities.Keys.GetType() == d.GetType())
            {
                Facilities[d]++;
            }
        }
        public KeyValuePair<string, int> ResourceFinder(string key, out KeyValuePair<string, int> match)
        {
            if (key == Plants[key].ToString())
            {
                match =  { key, Plants[key]};
                return match;
            }
            foreach (string k in Plants.Keys)
            {
                if (key == k)
                {
                    match = { k.Key, k.Value };
                }
            }
            foreach (string k in Animals.Keys)
            {
                if (key == k)
                {
                    return 
                }
            }
        }

        public void UpdateInventory(string resourceUsed, int resourceAmount)
        {


        }
        public void AddProduct(string resourceUsed, int resourceAmount)
        {
            Products[resourceUsed] = Products[] + inventoryAmount;   
        }

        public void RemoveResource(string resourceUsed, int resourceAmount)
        {
            Products[inventoryItem] = Products[inventoryItem] + inventoryAmount;
        }
    }
}