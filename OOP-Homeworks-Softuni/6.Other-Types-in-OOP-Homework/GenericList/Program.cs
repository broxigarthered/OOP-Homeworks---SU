using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int>intList = new GenericList<int>();
            intList.Add(5);
            intList.Add(2);
            intList.Add(8);
            intList.Add(12);
            intList.Add(3);

            Console.WriteLine(intList.Access(1));
            Console.WriteLine(intList.ContainsValue(5));
            Console.WriteLine(intList.IndexOf(12));
            intList.Remove(0);


            Console.WriteLine(Environment.NewLine+intList.ToString());
            intList.Clear();
        }
    }
}
