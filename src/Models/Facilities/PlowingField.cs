using System;
using System.Text;
using System.Collections.Generic;
using Trestlebridge.Interfaces;


namespace Trestlebridge.Models.Facilities
{
    public class PlowingField : IFacility<ISeedProducing>
    {
        private int _capacity = 65;
        private Guid _id = Guid.NewGuid();

        private List<ISeedProducing> _plants = new List<ISeedProducing>();

        public List<List<ISeedProducing>> rows {get;} = new List<List<ISeedProducing>>();
        public int CountPlants()
        {
            return _plants.Count;
        }

        public double Capacity
        {
            get
            {
                return _capacity;
            }
        }

        public void AddResource(ISeedProducing plant)
        {
            _plants.Add(plant);
        }

        public void AddResource(List<ISeedProducing> plants)
        {
            rows.Add(plants);
            _capacity -= 5;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            string shortId = $"{this._id.ToString().Substring(this._id.ToString().Length - 6)}";

            output.Append($"Plowing field {shortId} has {this.rows.Count} rows of plants\n");

            return output.ToString();
        }
    }
}