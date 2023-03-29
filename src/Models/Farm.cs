using System;
using System.Collections.Generic;
using System.Text;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Models
{
    public class Farm
    {
        // Properties
        public string Name { get; set; }
        public List<GrazingField> GrazingFields { get; } = new List<GrazingField>();
        public List<PlowingField> PlowingFields { get; } = new List<PlowingField>();
        public List<NaturalField> NaturalFields { get; } = new List<NaturalField>();
        internal int Meat { get; set; }
        internal int Eggs { get; set; }
        internal int Feathers { get; set; }
        internal int Compost { get; set; }
        internal int Seeds { get; set; }
        internal int Cows { get; set; }
        internal int Chickens { get; set; }
        internal int Ducks { get; set; }
        internal int Goats { get; set; }
        internal int Ostriches { get; set; }
        internal int Pigs { get; set; }
        internal int Sheep { get; set; }

        // Constructor

        public Farm()
        {
            Name = "Trestlebridge Farm";
            GrazingFields = new List<GrazingField>();
            PlowingFields = new List<PlowingField>();
            NaturalFields = new List<NaturalField>();
            Meat = 0;
            Eggs = 0;
            Feathers = 0;
            Compost = 0;
            Seeds = 0;
            Cows = 0;
            Chickens = 0;
            Ducks = 0;
            Goats = 0;
            Ostriches = 0;
            Pigs = 0;
            Sheep = 0;
        }

        public void InventoryReport()
        {
            Console.Write($@"
    Here's your inventory report:
    -----------------------------
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
    -----------------------------");
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

        public void AddPlowingField(PlowingField field)
        {
            PlowingFields.Add(field);
        }
        public void AddNaturalField(NaturalField field)
        {
            NaturalFields.Add(field);
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