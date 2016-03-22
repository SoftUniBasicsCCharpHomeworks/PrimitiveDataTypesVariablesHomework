﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dumbbell
{
    class Dumbbell
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}{1}{2}{1}{0}",new string('.',(n-1)/2), new string('&', (n + 1) / 2), new string('.', n ));
            for (int i = 0; i < (n-3)/2; i++)
            {
                Console.WriteLine("{0}&{1}&{2}&{1}&{0}", new string('.', ((n - 3) / 2)-i), new string('*', ((n - 1) / 2)+i), new string('.', n));
            }
            Console.WriteLine("&{0}&{1}&{0}&", new string('*',n - 2), new string('=',n ));
            for (int i = 0; i < (n - 3) / 2; i++)
            {
                Console.WriteLine("{0}&{1}&{2}&{1}&{0}", new string('.', 1+i), new string('*',((n - 3)- i)), new string('.', n));
            }
            Console.WriteLine("{0}{1}{2}{1}{0}", new string('.', (n - 1) / 2), new string('&', (n + 1) / 2), new string('.', n));

        }
    }
}
