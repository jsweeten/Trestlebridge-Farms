using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Models.Animals
{
    public class Ostrich : IGrazing
    {
        // Fields
        private Guid _id;

        // Properties
        public double FeedPerDay { get; set; }
        public IFacility Location { get; set; }
        public Dictionary<ProductInventory, double> Product { get; set; }
        public ProductInventory Meat { get; }
        public ProductInventory Eggs { get; }

        // Constructor
        public Ostrich()
        {
            _id = Guid.NewGuid();
            FeedPerDay = 2.3;
            Location = new GrazingField();
            Product = new()
            {
                {Meat, 2.6},
                {Eggs, 3.0}
            };
        }
    }
}
