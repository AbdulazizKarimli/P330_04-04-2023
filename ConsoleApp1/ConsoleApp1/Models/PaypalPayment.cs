using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class PaypalPayment : IPayment
    {
        public void Pay()
        {
            Console.WriteLine("Paypal payment");
        }
    }
}
