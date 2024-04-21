using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaClasses
{
    public class OrderPizza
    {
        public int OrderPizzaID { get; set; }  
        public int OrderID { get; set; }
        public int PizzaID { get;set; }

        public Pizza Pizza { get; set; }
        public Order Order { get; set; }
        public OrderPizza() { }
        public OrderPizza(int orderId, int pizzaId) { 
            OrderID = orderId;
            PizzaID = pizzaId;  
        }
    }
}
