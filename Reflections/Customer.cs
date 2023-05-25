using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflections
{
    internal class Customer
    {
        public int age { get; set; }
        public string name { get; set; }

        public Customer(int age, string name)
        {
            this.age = age;
            this.name = name;
        }

        public Customer()
        {
            this.age = 50;
            this.name = "Sushil";
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"The name is {this.name} and age is {this.age}");

        }

        public void PrintName()
        {
            Console.WriteLine($"The first name is {this.name}");
        }
    }
}
