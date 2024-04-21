using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaClasses
{
    public class Beverage:IBuyable
    {
        public int BeverageID {  get; private set; }
        private string name;
        public double Price {  get;  set; }
        public string Name { 
            get { return name; } 
            set { 
                if (string.IsNullOrEmpty(value) == false)
                    if (value.Length>0 && value.Length <= 50)
                        name = value;
                    else throw new Exception("Invalid name. The name should be greated then 0 and smaller or equal to 50.");
                else throw new Exception("Invalid name. Name is empty.");

            }
        }
        public Beverage()
        {

        }
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
