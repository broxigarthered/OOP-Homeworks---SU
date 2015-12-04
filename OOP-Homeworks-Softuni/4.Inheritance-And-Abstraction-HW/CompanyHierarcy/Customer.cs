using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarcy
{
    class Customer : Person
    {
        public override string ToString()
        {
            return string.Format("{0}, Total money spent - {1}", base.ToString(),
                this.TotalAmountOfMoneySpent);
        }

        public Customer(string id, string firstName, string lastName, decimal netPurchaseAmount)
            : base(id, firstName, lastName)
        {
            this.TotalAmountOfMoneySpent = netPurchaseAmount;
        }

        public decimal TotalAmountOfMoneySpent { get; set; }
    }
}
