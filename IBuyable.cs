using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaClasses
{
    public interface IBuyable
    {
        string Name { get; set; }
        double Price { get; set;}
    }
}
