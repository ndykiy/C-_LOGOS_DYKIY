using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            TestStack test = new TestStack();
            Console.WriteLine("Enter line");
            test.CheckLine(Console.ReadLine());
        }
        
        
       
    }
}
