using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarcy
{
    class Manager : Employee, IManager
    {
        public override string ToString()
        {
            var result = base.ToString();
            result += "Employees: ";
            foreach (var v in Employees)
            {
                result += v + Environment.NewLine;
            }
            return result.Substring(0, result.Length - 1);

        }

        public Manager(string id, string firstName, string lastName, int salary, DepartmentType department, List<Employee> employees)
            : base(id, firstName, lastName, salary, department)
        {
         this.Employees = employees;   
        }
        private List<Employee> employees;

        public List<Employee> Employees
        {
            get { return employees; }
            set { employees = value; }
        }

       
    }
}
