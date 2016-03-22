using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountData
{
    class BankAccountData
    {
        static void Main()
        {
            string firstName = "Яни";
            string middleName = "Атанасов";
            string lastName = "Петров";
            decimal money = 564850.86m;
            string bankName = "BulBank";
            string iban = "BG32 UBBS 7827 1013 6179 05";
            long cardNumber1 = 123456789123509;
            long cardNumber2 = 908765432123456;
            long cardNumber3 = 574836123456789;
            Console.WriteLine("Name: {0} {1} {2}\nAvailable amount of money: {3} лева\n{4} IBAN: {5}\nCard number: {6}\nCard number: {7}\nCard number: {8}", firstName, middleName, lastName, money, bankName, iban, cardNumber1, cardNumber2, cardNumber3);
        }
    }
}
