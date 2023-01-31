using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Human
    {
        string name;
        string lastName;
        ushort age;
        public Human() { }

        public Human(string name, string lastName, ushort age)
        {
            this.name = name;
            this.lastName = lastName;
            this.age = age;
        }
    }
}