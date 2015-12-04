using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankOfKurtovoKonare.Interfaces;

namespace BankOfKurtovoKonare.Customers
{
    class Customer : ICustomer
    {
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("name", "Customer's name cannot be empty.");
                }

                if (value.Length < 3)
                {
                    throw new ArgumentException("The customer's name should be at least 3 characters long.", "name");
                }

                this.name = value;
                
            }
        }

        public CustomerType CustomerType { get; set; }


        public Customer(string name,CustomerType customerType)
        {
            this.Name = name;
            this.CustomerType = customerType;
        }

      

       
    }
}
