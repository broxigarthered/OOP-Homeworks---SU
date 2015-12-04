using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListVersion
{
    class Program
    {
        [Versions(2,1)]
        static void Main(string[] args)
        {

            System.Reflection.MemberInfo info = typeof(Versions);
            foreach (object attribute in info.GetCustomAttributes(false))
            {
                Console.WriteLine(attribute);
            }


        }
    }
}
