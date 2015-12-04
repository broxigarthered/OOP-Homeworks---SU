using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyHierarcy.Interfaces;

namespace CompanyHierarcy
{
    abstract class Employee : Person, IEmployee
    {
        private DepartmentType department;
        public override string ToString()
        {
           return string.Format("\n{0}, Salary - {1}, Department - {2}", base.ToString(),
                this.Salary,
                this.Department);
        }

        public Employee(string id, string firstName, string lastName, decimal salary, DepartmentType department)
            : base(id, firstName, lastName)
        {
            this.Salary = salary;
            this.Department = department;
        }

        protected int salary;
       

        public decimal Salary
        {
            get { return salary; }
            protected set { salary = (int) value; }
        }

        public DepartmentType Department
        {
            get { return department; }
            set { department = value; }
        }

        public string ID
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        decimal IEmployee.Salary
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        string IEmployee.Department
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
