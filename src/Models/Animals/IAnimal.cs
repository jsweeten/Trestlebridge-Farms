using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Trestlebridge.Models.Animals
{
    public interface IAnimal : IResource
    {
        double FeedPerDay { get; set; }
    }
}
