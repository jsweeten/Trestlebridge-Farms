using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trestlebridge.Models.Facilities;

namespace Trestlebridge.Models
{
    public interface IResource
    {
        Dictionary<string, double> Product { get; set; }
        string Location { get; set; }
    }
}
