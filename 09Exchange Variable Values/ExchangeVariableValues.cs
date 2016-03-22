using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ExchangeVariableValues
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("Before:\na = {0}\nb = {1}",a,b);
        b = b - a;
        a = b+b;
        Console.WriteLine("After:\na = {0}\nb = {1}", a, b);
    }
}

