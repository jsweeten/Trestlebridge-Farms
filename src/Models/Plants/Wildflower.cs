using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Models.Plants
{
    public class Wildflower : IPlant
    {
        // Fields
        private Guid _id;

        // Properties
        public IFacility Location { get; set; }
        public Dictionary<ProductInventory, double> Product { get; }
        public ProductInventory Compost { get; }

        // Constructor
        public Wildflower()
        {
            _id = Guid.NewGuid();
            Location = new NaturalField();
            Product = new()
            {
                {Compost, 30.3}
            };
        }
        // Methods
    }
}
