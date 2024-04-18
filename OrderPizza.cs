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
        public int Quantity {  get; set; }
        public DateTime SpoilTime { get; set; }
    }
}
