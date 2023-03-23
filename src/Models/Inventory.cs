using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Trestlebridge.Models.Interfaces;

namespace Trestlebridge.Models
{
    public class Inventory
    {
        internal int Meat { get; set; }
        internal int Eggs { get; set; }
        internal int Feathers { get; set; }
        internal int Compost { get; set; }
        internal int Seeds { get; set; }
        internal int Cows { get; set; }
        internal int Chickens { get; set; }
        internal int Ducks { get; set; }
        internal int Goats{ get; set; }
        internal int Ostriches { get; set; }
        internal int Pigs { get; set; }
        internal int Sheep { get; set; }
        void Process(IResource resource)
        {
            foreach (var product in resource.Product)
            {
                Type t = GetType();
                PropertyInfo p = t.GetProperty(product.Key);
                if (p.ToString() == product.Key)
                {
                    p.SetValue(p, + product.Value); 
                }
            }
        }
        void InventoryReport()
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
    }
}
