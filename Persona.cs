using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructores
{
    internal class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person()
        {
            Name = string.Empty;
            Age = 0;
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;

            Console.WriteLine($"--- Hi {Name} your current age is {Age}----");
        }
    }
}  
