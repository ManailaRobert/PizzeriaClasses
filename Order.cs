using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaClasses
{
    public class Order
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public string PaymentMethod { get; set; }

        public Customers Customer { get; set; }
        public  ICollection<OrderBeverage> OrderBeverages { get; set; }
        public ICollection<OrderPizza> OrderPizza { get; set;}
    }
}
