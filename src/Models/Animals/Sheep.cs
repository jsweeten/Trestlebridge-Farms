using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trestlebridge.Models.Interfaces;

namespace Trestlebridge.Models.Animals
{
    public class Sheep : IGrazing
    {
        // Fields
        private Guid _id;

        // Properties
        public double FeedPerDay { get; set; }
        public string Location { get; set; }
        public Dictionary<string, double> Product { get; set; }

        // Constructor
        public Sheep()
        {
            _id = Guid.NewGuid();
            FeedPerDay = 4.0;
            Location = "Grazing Fields";
            Product = new()
            {
                {"Meat", 5.0}
            };
        }

        // Methods
    }
}
