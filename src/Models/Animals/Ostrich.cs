﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Models.Animals
{
    public class Ostrich : IGrazing
    {
        // Fields
        private Guid _id;

        // Properties
        public double FeedPerDay { get; set; }
        public IFacility Location { get; set; }
        public Dictionary<string, double> Product { get; set; }

        // Constructor
        public Ostrich(GrazingField field)
        {
            _id = Guid.NewGuid();
            FeedPerDay = 2.3;
            Location = field;
            Product = new()
            {
                {"Meat", 2.6},
                {"Eggs", 3.0}
            };
        }

        // Methods

    }
}
