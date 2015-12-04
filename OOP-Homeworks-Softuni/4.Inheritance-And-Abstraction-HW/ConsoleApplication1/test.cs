using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class test
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            List<Worker> workers = new List<Worker>();
            List<Merged> merged = new List<Merged>();
            List<Human> all = new List<Human>();
            
            students.Add(new Student("Georgi", "Asparaxuov","3521753"));
            students.Add(new Student("Mladen", "Mladenov", "7521157"));
            students.Add(new Student("Kara", "Karambu4eva", "252175377"));
            students.Add(new Student("Alexandra", "Slavova", "1536853"));
            students.Add(new Student("Burq", "Kurtakova", "9321753"));
            students.Add(new Student("Alex", "Bogdanov", "2521753"));
            students.Add(new Student("Nyxon", "Dimitrov", "157353"));
            students.Add(new Student("Vladimir", "Kunov", "32753"));
            students.Add(new Student("Naum", "Dutskinov", "1521753"));
            students.Add(new Student("Boyan", "Asenov", "7522753"));
            students.Add(new Student("Antron", "Panayotov", "8341753"));
            all.AddRange(students);

            var ordered = students.OrderBy(x => x.FacultyNumber)
                .ToList();
            Console.WriteLine("Students sorted by faculty number.");
            foreach (var v in ordered)
            {
                Console.WriteLine("{0} {1} -> {2}",v.FirstName,
                    v.LastName,
                    v.FacultyNumber);
            }

           workers.Add(new Worker("Georgi", "Asparaxuov",500,8));
           workers.Add(new Worker("Mladen", "Mladenov", 600,8));
           workers.Add(new Worker("Kara", "Karambu4eva", 200,9));
           workers.Add(new Worker("Alexandra", "Slavova", 125,4));
           workers.Add(new Worker("Burq", "Kurtakova", 1200,10));
           workers.Add(new Worker("Alex", "Bogdanov", 300,4));
           workers.Add(new Worker("Nyxon", "Dimitrov", 225,5));
           workers.Add(new Worker("Vladimir", "Kunov", 633,10));
           workers.Add(new Worker("Naum", "Dutskinov", 1000,8));
           workers.Add(new Worker("Boyan", "Asenov", 4000,8));
           workers.Add(new Worker("Antron", "Panayotov", 600,8));
            all.AddRange(workers);

            var orderedWorkers = workers.OrderByDescending(x => x.MoneyPerHour(x.WeekSalary, x.WorkHoursPerDay))
                .ToList();
            Console.WriteLine(Environment.NewLine+"Workers sorted by payment per hour.");
            foreach (var v in orderedWorkers)
            {
                Console.WriteLine("{0} {1} -> {2}", v.FirstName,
                    v.LastName,
                    v.MoneyPerHour(v.WeekSalary,v.WorkHoursPerDay));
            }

            
            //merging
            
            Console.WriteLine("\nBoth lists merged and sorted");
            var allSorted = all.OrderBy(x => x.FirstName)
                .ThenBy(y => y.LastName)
                .ToList();
            foreach (var c in all)
            {
                Console.WriteLine(c.ToString());
            }

           
        }
    }
}
