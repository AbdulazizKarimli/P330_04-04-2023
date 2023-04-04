using ConsoleApp1.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class CreditCardPayment : IPayment
    {
        public void Pay()
        {
            Console.WriteLine("Credit card payment");
        }
    }
}