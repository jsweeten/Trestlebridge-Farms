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
        public Dictionary<string, double> Product { get; set; }

        // Constructor
        public Chicken(ChickenCoop chickenCoop)
        {
            _id = Guid.NewGuid();
            Location = chickenCoop;
            FeedPerDay = 0.9;
            Product = new()
            {
                {"Eggs", 7.0},
                {"Feather", 0.5},
                {"Meat", 1.7}
            };
        }

        // Methods

    }
}
