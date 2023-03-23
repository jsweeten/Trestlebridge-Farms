using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trestlebridge.Models.Interfaces;

namespace Trestlebridge.Models.Animals
{
    public class Chicken : IAnimal
    {
        // Fields
        private Guid _id;

        // Properties
        public double FeedPerDay { get; set; }
        public string Location { get; set; }
        public Dictionary<string, double> Product { get; set; }

        // Constructor
        public Chicken()
        {
            _id = Guid.NewGuid();
            FeedPerDay = 0.9;
            Location = "Chicken House";
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
