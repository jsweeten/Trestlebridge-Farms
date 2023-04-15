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
        private double _meat;
        private double _eggs;
        private double _feathers;
        private double _compost;
        private double _sunflowerSeeds;
        private double _sesameSeeds;

        // Properties
        public double Meat { get { return _meat; } set { _meat = value; } }
        public double Eggs { get { return _eggs; } set { _eggs = value; } }
        public double Feathers { get { return _feathers; } set { _feathers = value; } }
        public double Compost { get { return _compost; } set { _compost = value; } }
        public double SunflowerSeeds { get { return _sunflowerSeeds; } set { _sunflowerSeeds = value; } }
        public double SesameSeeds { get { return _sesameSeeds; } set { _sesameSeeds = value; } }
    }
}
