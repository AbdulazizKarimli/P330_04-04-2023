using ConsoleApp1.Interfaces;
using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services
{
    public class PaymentService
    {
        public void Payment(IPayment paypalPayment)
        {
            paypalPayment.Pay();
        }
    }
}
