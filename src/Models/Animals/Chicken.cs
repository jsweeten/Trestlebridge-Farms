using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Models.Animals
{
    public class Chicken : IAnimal
    {
        // Fields
        private Guid _id;

        // Properties
        public double FeedPerDay { get; set; }
        public IFacility Location { get; set; }
        public Dictionary<ProductInventory, double> Product { get; set; }
        public ProductInventory Eggs { get; }
        public ProductInventory Meat { get; }
        public ProductInventory Feathers { get; }

        // Constructor
        public Chicken()
        {
            _id = Guid.NewGuid();
            Location = new ChickenCoop();
            FeedPerDay = 0.9;
            Product = new()
            {
                {Eggs, 7.0},
                {Feathers, 0.5},
                {Meat, 1.7}
            };
        }
    }
}
