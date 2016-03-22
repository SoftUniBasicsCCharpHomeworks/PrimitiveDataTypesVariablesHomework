using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main()
        {
            string wordOne = "Hello";
            string wordTwo = "World";
            object greeting = wordOne + " " + wordTwo;
            string castedGreeting = (string)greeting;
            Console.WriteLine(castedGreeting);

        }
    }
}
