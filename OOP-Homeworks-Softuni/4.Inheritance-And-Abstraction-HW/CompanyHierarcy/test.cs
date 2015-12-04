using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHierarcy
{
    class test
    {
        static void Main(string[] args)
        {
           
            var listOfSales = new List<Sale>();
            listOfSales.Add(new Sale("Bonboni", DateTime.Now, 25m));
            listOfSales.Add(new Sale("Duvki", DateTime.Parse("November 26 2015 16:45:30"), 25m));

            var lista = new List<Employee>();
            lista.Add(new SalesEmployee("25155536","Kristina","Summ",2500,DepartmentType.Accounting, listOfSales));
            lista.Add(new SalesEmployee("636621332", "Adelina", "Andreeva", 2500,DepartmentType.Marketing, listOfSales));


            Manager man1 = new Manager("953912","Ivan","Donev",5000,DepartmentType.Sales, lista);
            Developer developer1 = new Developer("5521262","Alek","Boninski",10000,DepartmentType.Marketing);

            Customer c = new Customer("233321","Vankata","Ionkov",25555);

            

            List<Person> merged = new List<Person>();
            merged.Add(man1);
            merged.Add(developer1);
            merged.Add(c);
            merged.AddRange(lista);

            foreach (var v in merged)
            {
                Console.WriteLine(v);
            }
           
        }
    }
}
