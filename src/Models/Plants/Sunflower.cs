using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Models.Plants
{
    public class Sunflower : IPlant
    {
        // Fields
        private Guid _id;

        // Properties
        public string Location { get; set; }
        public Dictionary<string, double> Product { get; set; }

        // Constructor
        public Sunflower()
        {
            _id = Guid.NewGuid();
            Location = "Ploughing or Natural Field";
            Product = new()
            {
                {"Compost", 650},
                {"Seed", 21.6}
            };
        }

        // Methods

    }
}
