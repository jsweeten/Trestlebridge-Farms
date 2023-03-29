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
        public IFacility Location { get; set; }
        public Dictionary<string, double> Product { get; set; }

        // Constructor
        public Sesame(PlowingField field)
        {
            _id = Guid.NewGuid();
            Location = field;
            Product = new()
            {
                {"Seed", 520}
            };
        }

        // Methods

    }
}
