using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingFloats
{
    class ComparingFloats
    {
        static void Main()
        {
            Console.WriteLine("Enter  two numbers:");
            double numberOne = double.Parse(Console.ReadLine());
            double numberTwo = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            bool isEqual = Math.Abs(numberOne - numberTwo) < eps;
            Console.WriteLine(isEqual);
        }
    }
}
