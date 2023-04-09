using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Trestlebridge.Models.Facilities;
using Trestlebridge.Models.Plants;

namespace Trestlebridge.Models.Facilities
{
    public class NaturalField : IPlantField
    {
        // Fields
        private Guid _id;
        private readonly int rows;
        private readonly int plantsPerRow;

        // Properties
        public string Name { get; set; }
        public int Capacity { get; }
        public int CurrentAmount { get; set; }

        // Methods
        public void AddResource(IResource plant, int amount)
        {
            if (CurrentAmount + amount > Capacity)
            {
                Console.WriteLine(@"
        This facility does not have the capacity to add that amount of plants.
        Please lower your amount or add another facility.");
            }
            else if (CurrentAmount + amount == Capacity)
            {
                CurrentAmount = CurrentAmount + amount;
                Console.WriteLine("Plants added to field. This field is now at capacity!");
            }
            else
            {
                CurrentAmount = CurrentAmount + amount;
                Console.WriteLine($"Plants added to field. This field is now at {CurrentAmount}/{Capacity} capacity!");
            }
        }

        // Constructor
        public NaturalField()
        {
            _id = Guid.NewGuid();
            rows = 10;
            plantsPerRow = 6;
            Capacity = rows * plantsPerRow;
            CurrentAmount = 0;
        }
    }
}