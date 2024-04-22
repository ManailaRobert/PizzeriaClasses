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
        public int AdressID { get; set; }
        public string PaymentMethod { get; set; }

        public double OrderPrice {  get; set; }
        public string OrderStatus { get; set; }
        public DateTime OrderDate { get; set; }
        public Customers Customer { get; set; }
        public Adress Adress { get; set; }
        public  ICollection<OrderBeverage> OrderBeverages { get; set; }
        public ICollection<OrderPizza> OrderPizza { get; set;}
    
    
        public Order(int customerID, int adressID,string paymentMethod, double orderPrice,DateTime orderDate ,string orderStatus = "active")
        {
            CustomerID = customerID;
            AdressID = adressID;
            PaymentMethod = paymentMethod;
            OrderStatus = orderStatus;
            OrderPrice = orderPrice;
            OrderDate = orderDate;
        }

        public override string ToString()
        {
            return $"#{OrderID}";
        }
    }
}
