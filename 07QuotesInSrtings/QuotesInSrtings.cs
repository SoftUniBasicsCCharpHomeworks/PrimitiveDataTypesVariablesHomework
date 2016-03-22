using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuotesInSrtings
{
    class QuotesInSrtings
    {
        static void Main()
        {
            string variantOne = "The \"use\" of quotations causes difficulties.";
            string variantTwo = @"The ""use"" of quotations causes difficulties.";
            Console.WriteLine(variantOne);
            Console.WriteLine(variantTwo);
        }
    }
}
