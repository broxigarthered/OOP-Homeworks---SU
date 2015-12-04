using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Merged : Worker
    {
        public Merged(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public Merged(string firstName, string lastName, decimal weekSalary, int workHoursPerDay)
            : base(firstName, lastName, weekSalary, workHoursPerDay)
        {
        }



        protected string facultyNumber;

        public string FacultyNumber
        {
            get { return facultyNumber; }
            set
            {
                if (value.Length < 5 || value.Length > 10)
                {
                    throw new ArgumentOutOfRangeException("Invalid faculty number");
                }
                facultyNumber = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + "Faculty number: " + this.FacultyNumber;

        }
    }
}
