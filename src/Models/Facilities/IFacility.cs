using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trestlebridge.Models.Facilities
{
    public interface IFacility
    {
        string Name { get; set; }
        int Capacity { get; }
        int CurrentAmount { get; set; }
        void AddResource(IResource resource, int amount);
    }
}
