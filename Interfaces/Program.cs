using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the amount to pay: ");
            double amount = double.Parse(Console.ReadLine());

            Console.WriteLine("1- Cash");
            Console.WriteLine("2- Card");
            Console.WriteLine("3- Wire transfert");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    
                    cashpayement cash = new cashpayement();
                    cash.makepayment( amount);
                    break;
                case "2":
                    Cardpayment card = new Cardpayment();
                    card.makepayment(amount);
                    break;
                case "3":
                    wirepayment wire = new wirepayment ();
                    wire.makepayment(amount);
                    break;
                default:
                    Console.WriteLine( " typea a valid value");
                    break;
            }

            Console.ReadKey();

        }
    }
}
