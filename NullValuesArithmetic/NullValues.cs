using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullValuesArithmetic
{
    class NullValues
    {
        static void Main()
        {
            int? valueInt = null;
            double? valueDouble = null;
            Console.WriteLine("Null int value:" + valueInt);
            Console.WriteLine("Null double value:" + valueDouble);
            valueInt += 1;
            valueDouble += 0.5;
            Console.WriteLine("Null int value + number:" + valueInt);
            Console.WriteLine("Null double value + number:" + valueDouble );
            valueInt += null;
            valueDouble += null;
            Console.WriteLine("Null int value + null:" + valueInt);
            Console.WriteLine("Null double value + null:" + valueDouble);
        }
    }
}
