using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_LOGOS_STACK_SYMMETRY_
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckString(Console.ReadLine());
        }

        static void CheckString(string s)
        {
            Stack<char> sym = new Stack<char>();
            int i = 0;
            
            while(s[i]!='0')
            {
                sym.Push(s[i]);
                i++;
               
            }

           for(;i<s.Length-1;i++)
           {
               if(sym.Peek()==s[i+1])
               {
                   sym.Pop();
               }
               else
               {
                   Console.WriteLine("wrong");
               }
           }
              
        }
            
   }
}

