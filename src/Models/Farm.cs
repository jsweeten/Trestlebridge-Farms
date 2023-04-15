using System;
using System.Collections.Generic;
using System.Text;
using Trestlebridge.Models.Facilities;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Plants;
using System.Reflection;

namespace Trestlebridge.Models
{
    public class Farm
    {
        // Properties
        public Dictionary<IFacility, int> Facilities { get; set; }
        public Dictionary<IAnimal, int> Animals { get; set; }
        public Dictionary<IPlant, int> Plants { get; set; }
        public Dictionary<ProductInventory, int> Products { get; set; }

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
                { new Chicken(), 0},
                { new Cow(), 0 },
                { new Duck(), 0 },
                { new Goat(), 0 },
                { new Ostrich(), 0 },
                { new Pig(), 0 },
                { new Sheep(), 0 }
            };
            Plants = new()
                            {
                { new Wildflower(), 0},
                { new Sunflower(), 0 },
                { new Sesame(), 0 }
            };
            Products = new();
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
            foreach (var Product in Products)
            {
                Console.WriteLine($"{Product.Key}: {Product.Value}");
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
    }
}