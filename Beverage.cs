using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaClasses
{
    public class Beverage
    {
        public int BeverageID {  get; private set; }
        public string Name {  get;  set; }
        public double Price {  get;  set; }

        public Beverage(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public ICollection<OrderBeverage> OrderBeverages { get; set; }
    
        public override string ToString()
        {
            return $"{Name} - {Price} RON";
        }
    }
}
