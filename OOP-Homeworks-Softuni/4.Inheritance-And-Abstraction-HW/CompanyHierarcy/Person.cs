using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyHierarcy.Interfaces;

namespace CompanyHierarcy
{
   public abstract class Person : IPerson
    {
       public Person(string id, string firstName, string lastName)
       {
           this.Id = id;
           this.FirstName = firstName;
           this.LastName = lastName;
       }

       private string id;
       private string firstName;
       private string lastName;

       public string Id
       {
           get { return id; }
           set { id = value; }
       }

       public string FirstName
       {
           get { return firstName; }
           set
           {
               if (string.IsNullOrWhiteSpace(value))
               {
                   throw new ArgumentException("Name cannot be null or empty.");
               }
               firstName = value;
           }
       }

       public string LastName
       {
           get { return lastName; }
           set
           {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Lastname cannot be null or empty.");
                }
                lastName = value;
           }
       }

       public override string ToString()
       {
           return string.Format("First name - {0}, Last name - {1}, ID - {2}",
               this.FirstName, this.LastName, this.Id);
       }
    }
}
