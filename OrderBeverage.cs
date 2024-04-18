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
        public int Quantity {  get; set; }

        
    }
}
