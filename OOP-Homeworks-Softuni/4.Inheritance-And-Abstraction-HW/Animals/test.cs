using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class test
    {
        static void Main(string[] args)
        {
            
            List<Cat> catsList = new List<Cat>();
            catsList.Add(new Tomcat("Koko",8));
            catsList.Add(new Kitten("Suzi",3));
            catsList.Add(new Cat("Mira",2,"female"));
            catsList.Add(new Tomcat("Mert",5));
            catsList.Add(new Tomcat("Correy",9));

            List<Dog> dogsList = new List<Dog>();
            dogsList.Add(new Dog("Barky",3,"male"));
            dogsList.Add(new Dog("Rexy", 3, "male"));
            dogsList.Add(new Dog("Doge", 2, "female"));
            dogsList.Add(new Dog("Kyckata", 5, "male"));
            dogsList.Add(new Dog("Mi6ka", 4, "female"));

            List<Frog> frogsList = new List<Frog>();
            frogsList.Add(new Frog("Grrlr",2,"undentified"));
            frogsList.Add(new Frog("Aaaaaughibbrgubugbugrguburgle",10,"unknown"));
            frogsList.Add(new Frog("Wrlrlrllr", 8, "unknown"));
            frogsList.Add(new Frog("Glglglpwplwslls", 6, "unknown"));

            var avgCats = catsList.Average(x => x.Age);
            Console.WriteLine("The average age of the cats is {0}",avgCats);

            var avgDogs = dogsList.Average(x => x.Age);
            Console.WriteLine("The Average age of the dogs is {0}",avgDogs);

            var avgFrogs = frogsList.Average(x => x.Age);
            Console.WriteLine("The Average age of the dogs is {0}", avgFrogs);
        }
    }
}
