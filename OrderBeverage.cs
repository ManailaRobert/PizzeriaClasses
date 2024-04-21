using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaClasses
{
    public class OrderBeverage
    {
        public int OrderBeverageID {  get; set; }
        public int OrderID {  get; set; }
        public int BeverageID { get; set; }


        public Order Order { get; set; }
        public Beverage Beverage { get; set; }
        
        public OrderBeverage() { }  
        public OrderBeverage(int orderId, int beverageId)
        {
            OrderID = orderId;
            BeverageID = beverageId;
        }
    }
}
