using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trestlebridge.Models.Interfaces;

namespace Trestlebridge.Models.Animals
{
    public class Goat : IGrazing
    {
        // Fields
        private Guid _id;

        // Properties
        public double FeedPerDay { get; set; }
        public string Location { get; set; }
        public Dictionary<string, double> Product { get; set; }


        // Constructor
        public Goat()
        {
            _id = Guid.NewGuid();
            FeedPerDay = 4.1;
            Location = "Grazing Fields";
            Product = new()
            {
                {"Compost", 7.5}
            };
        }

        // Methods

    }
}
