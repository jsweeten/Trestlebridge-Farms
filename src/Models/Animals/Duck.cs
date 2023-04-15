using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trestlebridge.Models.Animals;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Models.Animals
{
    public class Duck : IAnimal
    {
        // Fields
        private Guid _id;

        // Properties
        public double FeedPerDay { get; set; }
        public IFacility Location { get; set; }
        public Dictionary<ProductInventory, double> Product { get; set; }
        public ProductInventory Eggs { get; }
        public ProductInventory Feathers { get; }

        // Constructor
        public Duck()
        {
            _id = Guid.NewGuid();
            Location = new DuckHouse();
            FeedPerDay = 0.8;
            Product = new()
            {
                {Eggs, 6},
                {Feathers, 0.75}
            };
        }
    }
}
