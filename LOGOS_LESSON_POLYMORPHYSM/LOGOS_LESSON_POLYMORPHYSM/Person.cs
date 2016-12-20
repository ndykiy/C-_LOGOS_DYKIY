using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGOS_LESSON_POLYMORPHYSM
{
    abstract class Person
    {
        /*public  string fullName { get; set; }

         public Person(string name)
         {
             fullName = name;
         }

         public virtual void Print()
         {
             Console.WriteLine(fullName);
         }
         */


        public string fullName;
        public int age;

        /*public Person(string Name,int Age)
        {
            fullName = Name;
            age = Age;
        }
        */
        public void SetFullName(string val)
        {
            Console.WriteLine("Enter full name");
            fullName = val;
        }

        


        public override string ToString()
        {
            return (fullName + " " + age + " years old");
        }

    }
}
