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
        private string details;

        public string Details
        {
            get { return details; }
            set
            {
                if (string.IsNullOrEmpty(value) == false)
                {
                    if (value.Length <=150)
                    {
                        details = value;
                    }
                    else throw new Exception("Invalid adress, should have less or equal to 150 characters");

                }
                else throw new Exception("Invalid adress. Has Empty spaces");

            }
        }
        public Customers Customer { get; set; }
        public ICollection<Order> Orders { get; set; }
        public Adress() { }
        public Adress(string details) { 

            Details = details;
        }

        public override string ToString()
        {
            return Details;
        }
    }
}
