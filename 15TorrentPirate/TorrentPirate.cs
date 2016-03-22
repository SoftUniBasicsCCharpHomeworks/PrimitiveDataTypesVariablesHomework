using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorrentPirate
{
    class TorrentPirate
    {
        static void Main()
        {
            decimal d = decimal.Parse(Console.ReadLine());
            decimal p = decimal.Parse(Console.ReadLine());
            decimal w = decimal.Parse(Console.ReadLine());
            decimal hoursMall = d/2/60/60;
            decimal mallPrice = hoursMall * w;
            decimal downloadedMovies = d / 1500;
            decimal moviePrise = p * downloadedMovies;
            if (moviePrise>= mallPrice)
            {
                Console.WriteLine("mall -> {0}lv",Convert.ToDecimal(String.Format("{0:0.00}", mallPrice)).ToString());
            }
            else
                Console.WriteLine("cinema -> {0}lv", Convert.ToDecimal(String.Format("{0:0.00}", moviePrise)).ToString());

        }
    }
}
