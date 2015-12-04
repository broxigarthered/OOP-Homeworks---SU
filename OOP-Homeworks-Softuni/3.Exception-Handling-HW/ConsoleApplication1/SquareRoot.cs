using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
     class SquareRoot
    {
        private static void Main(string[] args)
        {
            string line = Console.ReadLine();

            try
            {   
                int n  = int.Parse(line);
                if (n < 0)
                {
                    throw new IndexOutOfRangeException();
                }
                
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid number");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }

        }
    }
   
}