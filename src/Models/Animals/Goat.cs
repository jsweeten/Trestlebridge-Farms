using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Models.Animals
{
    public class Goat : IGrazing
    {
        // Fields
        private Guid _id;

        // Properties
        public double FeedPerDay { get; set; }
        public IFacility Location { get; set; }
        public Dictionary<ProductInventory, double> Product { get; set; }
        public ProductInventory Compost { get; }

        // Constructor
        public Goat()
        {
            _id = Guid.NewGuid();
            FeedPerDay = 4.1;
            Location = new GrazingField();
            Product = new()
            {
                {Compost, 7.5}
            };
        }
    }
}
