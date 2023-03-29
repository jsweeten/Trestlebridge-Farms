using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Models.Animals
{
    public class Goat : IGrazing
    {
        // Fields
        private Guid _id;

        // Properties
        public double FeedPerDay { get; set; }
        public IFacility Location { get; set; }
        public Dictionary<string, double> Product { get; set; }


        // Constructor
        public Goat(GrazingField field)
        {
            _id = Guid.NewGuid();
            FeedPerDay = 4.1;
            Location = field;
            Product = new()
            {
                {"Compost", 7.5}
            };
        }

        // Methods

    }
}
