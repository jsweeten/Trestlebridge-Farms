using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trestlebridge.Models.Facilities;
using Trestlebridge.Models;

namespace Trestlebridge.Models.Plants
{
    public class Sunflower : IPlant
    {
        // Fields
        private Guid _id;

        // Properties
        public IFacility Location { get; set; }
        public Dictionary<ProductInventory, double> Product { get; set; }
        public ProductInventory Compost { get; }
        public ProductInventory SunflowerSeeds { get; }

        // Constructor
        public Sunflower()
        {
            _id = Guid.NewGuid();
            Product = new()
            {
                {Compost, 650},
                {SunflowerSeeds, 21.6}
            };
        }

        // Methods

    }
}
