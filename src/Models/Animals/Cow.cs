using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Models.Animals
{
    public class Cow : IGrazing
    {
        // Fields
        private Guid _id;

        // Properties
        public double FeedPerDay { get; set; }
        public IFacility Location { get; set; }
        public Dictionary<string, double> Product { get; set; }

        // Constructor
        public Cow(GrazingField field)
        {
            _id = Guid.NewGuid();
            FeedPerDay = 5.4;
            Location = field;
            Product = new()
            {
                {"Meat", 18.25}
            };
        }

        // Methods

    }
}
