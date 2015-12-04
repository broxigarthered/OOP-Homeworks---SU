using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankOfKurtovoKonare.Contracts
{
    interface IDepositable
    {
        void DepositAmountToAccount(decimal amountToDeposit);
    }
}
