using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class cashpayement : payment
    {
        public bool makepayment(double amount)
        {
            Console.WriteLine("Succes, account credited");
            return true;
        }
    }
}
