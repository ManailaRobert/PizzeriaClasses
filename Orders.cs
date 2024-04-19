using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaClasses
{
    public class Orders
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public string PaymentMethod { get; set; }
    }
}
