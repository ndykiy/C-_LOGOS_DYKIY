using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_LOGOS_STACK_1_
{
    class Program
    {
        static void Main(string[] args)
        {
            ChekString(Console.ReadLine());
        }

        static void ChekString(string s)
        {
            Stack<char> one = new Stack<char>();
            for(int i=0;i<s.Length;i++)
                {
                if(s[i]=='1')
                {
                    one.Push(s[i]); 
                }
                }
            int sRez = one.Count;
            if (sRez % 2 == 0)
            {
                Console.WriteLine("parna kilkist");
            }
            else Console.WriteLine("neparna kilkist");
        }
    }
}
