using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Trestlebridge.Models.Facilities
{
    public class ChickenCoop : IFacility
    {
        // Fields
        private Guid _id;

        // Properties
        public string Name { get; set; }
        public int Capacity { get; }
        public int CurrentAmount { get; set; }

        // Methods
        public void AddResource(IResource chicken, int amount)
        {
            if (CurrentAmount + amount > Capacity)
            {
                Console.WriteLine(@"
This facility does not have the capacity to add that amount of chickens.
Please lower your amount or add another facility.");
            }
            else if (CurrentAmount + amount == Capacity)
            {
                CurrentAmount = CurrentAmount + amount;
                Console.WriteLine("Chickens added to facility. This facility is now at capacity!");
            }
            else
            {
                CurrentAmount = CurrentAmount + amount;
                Console.WriteLine($"Chickens added to facility. This facility is now at {CurrentAmount}/{Capacity} capacity!");
            }
        }

        // Constructor
        public ChickenCoop(string name)
        {
            _id = Guid.NewGuid();
            Name = name;
            Capacity = 15;
            CurrentAmount = 0;
        }
    }
}
