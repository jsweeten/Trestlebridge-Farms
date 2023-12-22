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
        public ProductInventory Products { get; set; }

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
            Products = new()
            {
                Meat = 0,
                Eggs = 0,
                Feathers = 0,
                SunflowerSeeds = 0,
                SesameSeeds = 0,
                Compost = 0
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
            Console.WriteLine($"Meat: {Products.Meat}");
            Console.WriteLine($"Eggs: {Products.Eggs}");
            Console.WriteLine($"Feathers: {Products.Feathers}");
            Console.WriteLine($"Compost: {Products.Compost}");
            Console.WriteLine($"Sunflower Seeds: {Products.SunflowerSeeds}");
            Console.WriteLine($"Sesame Seeds: {Products.SesameSeeds}");
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

        //public void UpdateInventory(IResource resource, double amount)
        //{
        //    PropertyInfo p = Products.p;
        //    if (resource.ToString() == Products)
        //}

        //void Process(IResource resource, int count)
        //{
        //    Type t = GetType();
        //    PropertyInfo p = t.GetProperty(resource.ToString());
        //    foreach (var p of resource.Product)
        //    {
        //        if (p == product.Key)
        //        {
        //            p.SetValue(p, ++product.Value);
        //        }
        //    }
        //}
    }
}