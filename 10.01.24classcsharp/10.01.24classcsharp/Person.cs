using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1001taskscsharp
{
    class Person
    {
        public String name { get; set; }
        public int age { get; set; }
        public Person(String name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }
}
