using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Persons
{
    internal class Persons
    {
        private class Person
        {
            private string name;
            private int age;
            private string email;

            public string Name
            {
                get { return this.name; }
                set
                {
                    if (String.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException("Name cannot be empty.");
                    }

                    if (!ValidateName(value))
                    {
                        throw new ArgumentException(
                            "Name should contain only Latin letters, spaces and hyphens and start with an uppercase letter.");
                    }

                    this.name = value;
                }
            }

            public int Age
            {
                get { return this.age; }
                set
                {
                    if (!ValidateAge(value))
                    {
                        throw new ArgumentOutOfRangeException("Age should be an integer between 1 and 100 inclusive.");
                    }

                    this.age = value;
                }
            }

            public string Email
            {
                get { return this.email; }
                set
                {
                    if (String.IsNullOrWhiteSpace(value))
                    {
                        throw new ArgumentException("Email cannot be empty.");
                    }

                    if (!ValidateEmail(value))
                    {
                        throw new ArgumentException("Email could not be validated."); // Put a more descriptive message
                    }

                    this.email = value;
                }
            }

            private bool ValidateName(string name)
            {
                Regex nameMatcher = new Regex(@"^[A-Z][a-zA-Z- ]+$");
                return nameMatcher.IsMatch(name);
            }

            private bool ValidateAge(int age)
            {
                if (age < 1 || age > 100)
                {
                    return false;
                }
                return true;
            }

            private bool ValidateEmail(string email)
            {
                
                Regex emailMatcher =
                    new Regex(
                        @"^[a-z0-9!#$%&'*+\/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+\/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?$");
                return emailMatcher.IsMatch(email);
            }

            public Person(string name, int age)
            {
                this.Name = name;
                this.Age = age;
            }

            public Person(string name, int age, string email)
            {
                this.Name = name;
                this.Age = age;
                this.Email = email;
            }

            public override string ToString()
            {
                return "This is a person called " + this.name + ". He/she is " + this.age +
                       " years old. His/her email address is " +
                       (string.IsNullOrEmpty(this.email) ? "not set." : this.email);
            }

            public void IntroducePerson()
            {
                Console.WriteLine("Hi, my name is {0} and I'm {1} years old.", this.name, this.age);
            }
        }

        private static void Main()
        {
            Person gosho = new Person("Gosho", 29); // using first constructor
            Person pesho = new Person("Pesho", 33, "pesho@mail.bg"); // using second constructor

            Console.WriteLine(gosho); 
            Console.WriteLine(pesho);
            Console.WriteLine(pesho.Name);
            pesho.IntroducePerson(); // use a non-static method from the Person class

        }
    }
}
