using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketBattle
{
    class BasketBattle
    {
        static void Main()
        {
            string f = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            int Simeon = 0;
            int Nakov = 0;
            bool simeonFirst = f=="Simeon";
                for (int i = 0; i < n; i++)
                 {
                    count++;
                    int p = int.Parse(Console.ReadLine());
                    string inf = Console.ReadLine();
                    simeonFirst |= false;
                    if (inf== "success" && simeonFirst==true)
                    {
                        Simeon += p;
                        if (Simeon>500)
                        {
                            Simeon -= p;
                        }
                    }
                    else if (inf == "success" && simeonFirst==false)
                    {
                        Nakov += p;
                        if (Nakov>500)
                        {
                            Nakov -= p;
                        }
                    }
                if (Simeon==500 || Nakov==500)
                {
                    break;
                }
                    simeonFirst ^= true;
                    p = int.Parse(Console.ReadLine());
                    inf = Console.ReadLine();
                    if (inf == "success" && simeonFirst == true)
                    {
                        Simeon += p;
                        if (Simeon > 500)
                        {
                            Simeon -= p;
                        }
                }
                    else if (inf == "success" && simeonFirst == false)
                    {
                        Nakov += p;
                        if (Nakov > 500)
                        {
                            Nakov -= p;
                        }
                }
                    
                if (Simeon == 500 || Nakov == 500)
                {
                    break;
                }
            }
            if (Simeon==Nakov)
            {
                Console.WriteLine("DRAW");
                Console.WriteLine(Simeon);
            }
            else if (Simeon==500 || Nakov==500)
            {
                if (Simeon == 500)
                {
                    Console.WriteLine("Simeon");
                    Console.WriteLine(count);
                    Console.WriteLine(Nakov);
                }
                if (Nakov == 500)
                {
                    Console.WriteLine("Nakov");
                    Console.WriteLine(count);
                    Console.WriteLine(Simeon);
                }
            }
            else if (Simeon>Nakov && Simeon != 500)
                {
                    Console.WriteLine("Simeon");
                    Console.WriteLine(Math.Abs(Simeon-Nakov));
                }
            else if (Nakov>Simeon && Nakov != 500)
            {
                Console.WriteLine("Nakov");
                Console.WriteLine(Math.Abs(Simeon - Nakov));
            }
            
        }
    }
}




