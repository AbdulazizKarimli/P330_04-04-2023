using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models
{
    public class Student
    {
        private int Id { get; set; } 
        public string Name { get; set; }
        public string Surname { get; set; }

        public string age;

        public void ShowInfo()
        {
            Console.WriteLine($"{Id} - {Name} - {Surname}");
        }
    }
}
