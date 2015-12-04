

using System;
using System.Security.Cryptography;

namespace ConsoleApplication1
{
    class Student : Human
    {
        public Student(string firstName, string lastName)
            : base(firstName, lastName)
        {
        }

        public Student(string firstName, string lastName, string facultyNumber) : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
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
           // return base.ToString();
            return string.Format("{0} -> {1}", base.ToString(),
                this.FacultyNumber);
        }
    }
}
