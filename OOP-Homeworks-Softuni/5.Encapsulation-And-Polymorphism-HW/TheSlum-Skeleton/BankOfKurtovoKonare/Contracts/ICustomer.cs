using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankOfKurtovoKonare.Customers;

namespace BankOfKurtovoKonare.Interfaces
{
    interface ICustomer
    {
        string Name { get; }

        CustomerType CustomerType { get; }
    }
}
