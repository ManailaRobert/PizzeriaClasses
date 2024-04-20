using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaClasses
{
    public class Adress
    {
        public int AdressID {  get; set; }
        public int CustomerID { get; set; }
        public string Details {  get; set; }

        public Customers Customer { get; set; }
    }
}
