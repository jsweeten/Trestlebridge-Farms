using System;
using System.Collections.Generic;
using System.Text;
using Trestlebridge.Models.Facilities;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Plants;

namespace Trestlebridge.Models
{
    public class Farm
    {
        // Properties
        public List<PloughingField> PloughingFields { get; set; } = new List<PloughingField>();
        public List<GrazingField> GrazingFields { get; set; } = new List<GrazingField>();
        public List<NaturalField> NaturalFields { get; set; } = new List<NaturalField>();
        public List<ChickenCoop> ChickenCoops { get; set; } = new List<ChickenCoop>();
        public List<DuckHouse> DuckHouses { get; set; } = new List<DuckHouse>();
        internal int Meat { get; set; }
        internal int Eggs { get; set; }
        internal int Feathers { get; set; }
        internal int Compost { get; set; }
        internal int SesameSeeds { get; set; }
        internal int SunflowerSeeds { get; set; }
        internal int Cows { get; set; }
        internal int Chickens { get; set; }
        internal int Ducks { get; set; }
        internal int Goats { get; set; }
        internal int Ostriches { get; set; }
        internal int Pigs { get; set; }
        internal int Sheep { get; set; }
        internal int Sunflower { get; set; }
        internal int Sesame { get; set; }
        internal int Wildflower { get; set; }

        private List<IFacility> Facilities { get; }
        private List<IAnimal> Animals { get; }
        private List<IPlant> Plants { get; }
        // Constructor

        public Farm()
        {
            GrazingFields = new();
            PloughingFields = new();
            NaturalFields = new();
            ChickenCoops = new();
            DuckHouses = new();
            Meat = 0;
            Eggs = 0;
            Feathers = 0;
            Compost = 0;
            SesameSeeds = 0;
            SunflowerSeeds = 0;
            Cows = 0;
            Chickens = 0;
            Ducks = 0;
            Goats = 0;
            Ostriches = 0;
            Pigs = 0;
            Sheep = 0;
            Sesame = 0;
            Sunflower = 0;
            Wildflower = 0;
        }

        public void InventoryReport()
        {
            Console.Write($@"
    Here's your inventory report:
    -----------------------------
    
    Facilities
    
    Grazing Fields: {GrazingFields.Count}
    Total Capacity: {GrazingFields.Count * 20}

    Natural Fields: {NaturalFields.Count}
    Total Capacity: {NaturalFields.Count * 10}

    Ploughed Fields: {PloughingFields.Count}
    Total Capacity: {PloughingFields.Count * 13}

    Chicken Coops: {ChickenCoops.Count}
    Total Capacity: {ChickenCoops.Count * 15}

    Duck Houses: {DuckHouses.Count}
    Total Capacity: {DuckHouses.Count * 12}

    Animals

    Meat: {Meat}
    Egg: {Eggs}
    Feather: {Feathers}
    Compost: {Compost}
    Chickens: {Chickens}
    Cows: {Cows}
    Ducks: {Ducks}
    Goats: {Goats}
    Ostriches: {Ostriches}
    Pigs: {Pigs}
    Sheep: {Sheep}

    Plants

    Sunflower: {Sunflower * 6}
    Sesame: {Sesame * 5}
    Wildflower: {Wildflower * 6}

    -----------------------------

    Press any key to continue...");
            Console.ReadKey();
        }

        /*
            This method must specify the correct product interface of the
            resource being purchased.
         */
        //public void PurchaseResource<T>(IResource resource, string name)
        //{
        //    Console.WriteLine(typeof(T).ToString());
        //    switch (typeof(T).ToString())
        //    {
        //        case "Cow":
        //            GrazingFields[index].AddResource((IGrazing)resource);
        //            break;
        //        case "Chicken":
        //            GrazingFields[index].AddResource((IAnimal)resource);
        //            break;
        //        case "Duck":
        //            GrazingFields[index].AddResource((IAnimal)resource);
        //            break;
        //        case "Goat":
        //            GrazingFields[index].AddResource((IGrazing)resource);
        //            break;
        //        case "Ostrich":
        //            GrazingFields[index].AddResource((IGrazing)resource);
        //            break;
        //        case "Pig":
        //            GrazingFields[index].AddResource((IGrazing)resource);
        //            break;
        //        case "Sheep":
        //            GrazingFields[index].AddResource((IGrazing)resource);
        //            break;
        //        case "Sesame":
        //            GrazingFields[index].AddResource((IPlant)resource);
        //            break;
        //        case "Sunflower":
        //            GrazingFields[index].AddResource((IPlant)resource);
        //            break;
        //        case "Wildflower":
        //            GrazingFields[index].AddResource((IPlant)resource);
        //            break;
        //        default:
        //            break;
        //    }
        //}

        public void AddGrazingField(GrazingField field)
        {
            GrazingFields.Add(field);
        }
        public void AddPloughingField(PloughingField field)
        {
            PloughingFields.Add(field);
        }
        public void AddNaturalField(NaturalField field)
        {
            NaturalFields.Add(field);
        }
        public void AddChickenCoop(ChickenCoop coop)
        {
            ChickenCoops.Add(coop);
        }
        public void AddDuckHouse(DuckHouse house)
        {
            DuckHouses.Add(house);
        }

        //public override string ToString()
        //{
        //    StringBuilder report = new StringBuilder();

        //    GrazingFields.ForEach(gf => report.Append(gf));
        //    PlowingFields.ForEach(gf => report.Append(gf));
        //    NaturalFields.ForEach(gf => report.Append(gf));


        //    return report.ToString();
        //}
    }
}