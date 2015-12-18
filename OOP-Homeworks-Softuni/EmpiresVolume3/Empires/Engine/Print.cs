using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Interfaces;

namespace Empires.Models
{
    class Print : IOutPut
    {

        public void Output(string args)
        {
            Console.WriteLine(args);

        }
    }
}
