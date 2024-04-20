using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaClasses
{
    public class Customers
    {
        public int CustomerID {  get; set; }
        public string Name {  get; set; }
        public string PhoneNumber {  get; set; }   
        public ICollection<Adress> Adresses { get; set; }
        public ICollection<Order>Orders { get; set; }
    }
}
