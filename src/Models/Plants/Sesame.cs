using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Models.Plants
{
    public class Sesame : IPlant
    {
        // Fields
        private Guid _id;

        // Properties
        public string Location { get; set; }
        public Dictionary<string, double> Product { get; set; }

        // Constructor
        public Sesame()
        {
            _id = Guid.NewGuid();
            Location = "Ploughing Field";
            Product = new()
            {
                {"Seed", 520}
            };
        }

        // Methods

    }
}
