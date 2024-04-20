using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaClasses
{
    public class Sizes
    {
        public int SizeID {  get; set; }
        public string Size {  get; set; }

        public double Price { get; set; }

        public ICollection<Pizza> Pizzas { get; set; }

        public override string ToString()
        {
            return Size;
        }
    }
}
