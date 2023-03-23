using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trestlebridge.Models.Interfaces;

namespace Trestlebridge.Models.Animals
{
    public class Pig : IGrazing
    {
        // Fields
        private Guid _id;

        // Properties
        public double FeedPerDay { get; set; }
        public string Location { get; set; }
        public Dictionary<string, double> Product { get; set; }


        // Constructor
        public Pig()
        {
            _id = Guid.NewGuid();
            FeedPerDay = 3.2;
            Location = "Grazing Fields";
            Product = new()
            {
                {"Meat", 8.4}
            };
        }

        // Methods

    }
}
