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
        private string name;
        private string phoneNumber;  


        public ICollection<Adress> Adresses { get; set; }
        public ICollection<Order>CustomerOrders { get; set; }
        

        public string Name
        {
            get { return name; }
            set {
                if (string.IsNullOrEmpty(value) == false)
                {
                    if (value.Length <= 50)
                    {
                        name = value;
                    }
                    else throw new Exception("Invalid name, should have less or equal to 50 characters.");

                }
                else throw new Exception("Invalid adress. Has Empty spaces");
            }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set
            {
                
            
                if (string.IsNullOrEmpty(value) == false)
                {
                    if (int.TryParse(value, out int result))
                    {  
                        if (value.Length <= 10 && value.Length >= 4)
                        {
                        phoneNumber = value;
                        }
                        else throw new Exception("Invalid phone number, should have more then 3 charaters less or equal to 10 characters .");
                    }
                    else throw new Exception("Invalid phone number. It needs to be a numeric value");

                }
                else throw new Exception("Invalid phone number. Has Empty spaces");
            }
        }
        public Customers(string name,string phoneNumber) { 
            Name = name;
            PhoneNumber = phoneNumber;
        }

        public override string ToString()
        {
            return Name;
        }

    }
}
