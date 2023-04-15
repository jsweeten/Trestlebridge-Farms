using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Models.Plants
{
    public class Sesame : IPlant
    {
        // Fields
        private Guid _id;

        // Properties
        public IFacility Location { get; set; }
        public Dictionary<ProductInventory, double> Product { get; set; }
        public ProductInventory SesameSeeds { get;}

        // Constructor
        public Sesame()
        {
            _id = Guid.NewGuid();
            Location = new PloughingField();
            Product = new()
            {
                {SesameSeeds, 520}
            };
        }
        // Methods
    }
}
