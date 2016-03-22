using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptedMatrix
{
    class EncryptedMatrix
    {
        static void Main()
        {
            string s = Console.ReadLine();
            byte[] asciiBytes = Encoding.ASCII.GetBytes(s);
            List<int> convertNumber = new List<int>();
            int a;
            string direction = Console.ReadLine();
            for (int i = 0; i < asciiBytes.Length; i++)
            {
                string asc=asciiBytes[i].ToString();
                string lastNumber = asc.Substring(asc.Length-1);
                convertNumber.Add(int.Parse(lastNumber));
            }
            List<int> encryptNumber = new List<int>();
            if (convertNumber.Count == 1)
            {
                if (convertNumber[0] % 2 == 0)
                {
                    convertNumber[0] *= convertNumber[0];
                }
                encryptNumber.Add(convertNumber[0]);
            }
            else if (convertNumber.Count > 1)
            {
                if (convertNumber[0] % 2 == 0)
                {
                    a = convertNumber[0] * convertNumber[0];
                }
                else
                    a = convertNumber[0] + convertNumber[1];
                encryptNumber.Add(a);

                for (int i = 1; i < convertNumber.Count - 1; i++)
                {
                    if (convertNumber[i] % 2 != 0)
                    {
                        a=convertNumber[i] + convertNumber[i - 1] + convertNumber[i + 1];
                    }
                    else
                        a= convertNumber[i] * convertNumber[i];
                    encryptNumber.Add(a);
                }
                if (convertNumber[convertNumber.Count - 1] % 2 == 0)
                {
                    convertNumber[convertNumber.Count - 1] *= convertNumber[convertNumber.Count - 1];
                }
                else
                    convertNumber[convertNumber.Count - 1] += convertNumber[convertNumber.Count - 2];
                encryptNumber.Add(convertNumber[convertNumber.Count - 1]);
            }
            string result = string.Join("", encryptNumber);
            if (result.Length == 1)
            {
                Console.WriteLine(result);
            }
            else if (direction == "\\")
            {
                Console.WriteLine("{0} {1}", result[0], string.Concat(Enumerable.Repeat("0 ", result.Length - 1)));
                for (int i = 1; i < result.Length - 1; i++)
                {
                    Console.WriteLine("{0}{1} {2}", string.Concat(Enumerable.Repeat("0 ", i)), result[i], string.Concat(Enumerable.Repeat("0 ", result.Length - i - 1)));
                }
                Console.WriteLine("{0}{1}", string.Concat(Enumerable.Repeat("0 ", result.Length - 1)), result[result.Length - 1]);
            }
            else
            {
                Console.WriteLine("{0}{1}", string.Concat(Enumerable.Repeat("0 ", result.Length - 1)), result[result.Length - 1]);
                for (int i = result.Length - 2; i > 0; i--)
                {
                    Console.WriteLine("{0}{1} {2}", string.Concat(Enumerable.Repeat("0 ", i)), result[i], string.Concat(Enumerable.Repeat("0 ", result.Length - i - 1)));
                }
                Console.WriteLine("{0} {1}", result[0], string.Concat(Enumerable.Repeat("0 ", result.Length - 1)));
            }
        }
    }
}
