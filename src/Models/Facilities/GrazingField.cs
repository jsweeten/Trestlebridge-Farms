using System;
using System.Collections.Generic;

namespace Trestlebridge.Models.Facilities
{
    public class GrazingField : IFacility
    {
        // Fields
        private Guid _id;

        // Properties
        public string Name { get; set; }
        public int Capacity { get; }
        public int CurrentAmount { get; set; }

        // Methods
        public void AddResource(IResource animal, int amount)
        {
            if (CurrentAmount + amount > Capacity)
            {
                Console.WriteLine(@"
This facility does not have the capacity to add that amount of animals.
Please lower your amount or add another facility.");
            }
            else if (CurrentAmount + amount == Capacity)
            {
                CurrentAmount = CurrentAmount + amount;
                Console.WriteLine("Animals added to facility. This facility is now at capacity!");
            }
            else
            {
                CurrentAmount = CurrentAmount + amount;
                Console.WriteLine($"Animal added to facility. This facility is now at {CurrentAmount}/{Capacity} capacity!");
            }
        }

        // Constructor
        public GrazingField()
        {
            _id = Guid.NewGuid();
            Capacity = 20;
            CurrentAmount = 0;
        }
    }
}