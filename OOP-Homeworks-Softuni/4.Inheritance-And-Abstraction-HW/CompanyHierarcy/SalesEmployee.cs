using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarcy
{
    class SalesEmployee : Employee
    {
        public override string ToString()
        {
            var result = base.ToString();
            result += "Sales: ";
            foreach (var v in Sales)
            {
                result += v + Environment.NewLine;
            }

            return result.Substring(0, result.Length - 1);
        }

        public SalesEmployee(string id, string firstName, string lastName, int salary, DepartmentType department, List<Sale> sales ) 
            : base(id, firstName, lastName, salary, department)
        {
            this.Sales = sales;
        }

        public List<Sale> Sales { get; set; }
    }

    class Sale
    {
        protected string productName;
        protected DateTime date;
        protected decimal price;

        public Sale(string productName, DateTime date, decimal price)
        {
            this.productName = productName;
            this.Date = date;
            this.Price = price;
        }

        public override string ToString()
        {
            return string.Format("\n{0}, {1}, {2}",
                this.ProductName, this.Date, this.Price);
        }

        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }


    }
}
