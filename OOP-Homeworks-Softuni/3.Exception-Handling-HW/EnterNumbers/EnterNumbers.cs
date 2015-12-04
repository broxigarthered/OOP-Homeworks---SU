using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterNumbers
{
    class EnterNumbers
    {
        static void Main(string[] args)
        {

            int start = 1;
            const int end = 100;
            int counter = 0;
            int num = 0;
           

            while (counter < 10)
            {
                try
                {
                    num = ReadNumbers(start, end);
                    start = num;
                    
                    counter++;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Number!");
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("The number is not in the requested range!");
                }
            }
        }

        public static int ReadNumbers(int start, int end)
        {
            Console.WriteLine("Enter a number between {0} and {1}: ", start, end);
            int num = int.Parse(Console.ReadLine());

            if (num <= start || num >= end)
            {
                throw new ArgumentException("The number is not in the requested range!");
            }

            return num;
        }
    }
}