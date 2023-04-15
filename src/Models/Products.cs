using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trestlebridge.Models
{
    public class ProductInventory
    {
        // Fields
        private static double _meat;
        private static double _eggs;
        private static double _feathers;
        private static double _compost;
        private static double _sunflowerSeeds;
        private static double _sesameSeeds;

        // Properties
        public static double Meat { get { return _meat; } set { _meat = value; } }
        public static double Eggs { get { return _eggs; } set { _eggs = value; } }
        public static double Feathers { get { return _feathers; } set { _feathers = value; } }
        public static double Compost { get { return _compost; } set { _compost = value; } }
        public static double SunflowerSeeds { get { return _sunflowerSeeds; } set { _sunflowerSeeds = value; } }
        public static double SesameSeeds { get { return _sesameSeeds; } set { _sesameSeeds = value; } }
    }
}
