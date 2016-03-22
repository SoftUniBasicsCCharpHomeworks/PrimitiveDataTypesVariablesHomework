using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfBits
{
    class GameOfBits
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());
            string binary = Convert.ToString(n, 2).PadLeft(32,'0');
            int countOnes = 0;
            StringBuilder newbinary = new StringBuilder();

            for (int i = 0; i < binary.Length; i++)
            {
                newbinary.Append(binary[i]);
            }
            StringBuilder newbin = new StringBuilder();
            for (int j = 0; j < 30; j++)
            {
                string command = Console.ReadLine();
                if (command == "Odd")
                {
                    for (int i = 1; i < newbinary.Length; i += 2)
                    {
                        newbin.Append(newbinary[i]);
                    }
                }
                else if (command == "Even")
                {
                    for (int i = 0; i < newbinary.Length; i += 2)
                    {
                        newbin.Append(newbinary[i]);
                    }
                }
                else if (command == "Game Over!")
                {
                    
                    break;
                }
                newbinary.Clear();
                for (int i = 0; i < newbin.Length; i++)
                {
                    newbinary.Append(newbin[i]);
                }
                newbin.Clear();
            }
            int number = Convert.ToInt32(newbinary.ToString(), 2);
            countOnes = newbinary.ToString().Split('1').Length - 1;
            Console.WriteLine("{0} -> {1}", number, countOnes);
        }
    }
}
    

