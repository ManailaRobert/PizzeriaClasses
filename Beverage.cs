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
        public string Name {  get; private set; }
        public double Price {  get; private set; }

        public Beverage(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public ICollection<OrderBeverage> OrderBeverages { get; set; }
    }
}
