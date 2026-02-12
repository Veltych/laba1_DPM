using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Fundamentals_Library
{
    public abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"{GetType().Name}: {Name}, {Age} years old");
        }
    }
}
