using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Worker : Human
    {
        public Worker(string firstName, string lastName)
            : base(firstName, lastName)
        {
        }

        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay) 
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.workHoursPerDay = workHoursPerDay;
        }

        private decimal weekSalary;
        private int workHoursPerDay;

        public decimal WeekSalary
        {
            get { return weekSalary; }
            set { weekSalary = value; }
        }

        public int WorkHoursPerDay
        {
            get { return workHoursPerDay; }
            set { workHoursPerDay = value; }
        }

        public int MoneyPerHour(decimal weekSalary, int workHoursPerDay)
        {
            int payment = 0;
            payment = (int) weekSalary/5/workHoursPerDay;
            return payment;
        }

        public override string ToString()
        {
            return string.Format("{0} -> {1}",base.ToString(),
                this.MoneyPerHour(this.WeekSalary, this.WorkHoursPerDay));
        }
    }
}
