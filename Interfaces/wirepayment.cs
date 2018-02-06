using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
   public class wirepayment : payment
    {
    public bool makepayment(double amount)
        {
            Console.Write(  "Enter the Bank :");
            string bank = Console.ReadLine();

            Console.Write("Enter the acccount :");
            string account = Console.ReadLine();

            Console.Write("Enter the acccount name :");
            string name = Console.ReadLine();
            Console.WriteLine("Success ");
            Console.WriteLine(account +" of " + name + " credited of " + amount) ;

            Console.WriteLine();

            return true;
        }
    }
}
