using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Cardpayment : payment
    {
        public bool makepayment(double amount)
        {
            Console.Write("Enter the card Number :");
            string cardNum = Console.ReadLine();
            Console.Write("Security code for the card Number: ");
            string security = Console.ReadLine();

            Console.WriteLine("checking card number :  valid");
            Console.WriteLine("success :  account credited");

            return true;
        }
    }
}
