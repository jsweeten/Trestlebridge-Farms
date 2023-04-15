using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Models.Animals
{
    public class Pig : IGrazing
    {
        // Fields
        private Guid _id;

        // Properties
        public double FeedPerDay { get; set; }
        public IFacility Location { get; set; }
        public Dictionary<ProductInventory, double> Product { get; set; }
        public ProductInventory Meat { get; }


        // Constructor
        public Pig()
        {
            _id = Guid.NewGuid();
            FeedPerDay = 3.2;
            Location = new GrazingField();
            Product = new()
            {
                {Meat, 8.4}
            };
        }
    }
}
