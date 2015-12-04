using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfKurtovoKonare.Interfaces
{
    interface IAccount
    {
        ICustomer Customer { get; }
        decimal Balance { get; }
        decimal MonthlyInterestRate { get; }
        decimal CalculateInterest(int period);
    }
}
