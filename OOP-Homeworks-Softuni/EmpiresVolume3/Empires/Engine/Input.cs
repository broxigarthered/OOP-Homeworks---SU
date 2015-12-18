using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Empires.Interfaces;

namespace Empires.Models
{
    class Input : IInput
    {

        public string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
