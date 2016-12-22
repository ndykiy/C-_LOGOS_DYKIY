using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGOS_LESSON_INTERFACE
{
    class Person:IPrintable
    {
        string name;
        int age;

        public Person(string n, int a)
        {
            name = n;
            age = a;
        }

        public void Print()
        {
            Console.WriteLine("My name is {0}");
        }
    }
}
