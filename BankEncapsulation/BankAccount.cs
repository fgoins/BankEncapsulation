using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using System.Xml.Linq;

namespace BankEncapsulation
{
    //A private field of type double named balance with a value of 0
    //Define a method named Deposit that will accept a double and store that value in the balance field
    //Define a method named GetBalance that will return the amount stored in the balance field
    public class BankAccount
    {
        private double balance = 50;
         public void Deposit(double amount) 
        {
            balance += amount;
            Console.WriteLine($"{balance}");
        }
        public double GetBalance() 
        {
            return balance;
        }

    }
}
