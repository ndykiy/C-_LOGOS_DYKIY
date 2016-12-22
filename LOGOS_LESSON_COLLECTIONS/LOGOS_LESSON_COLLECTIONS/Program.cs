using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGOS_LESSON_COLLECTIONS
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            List<int> tmp = new List<int>();
            tmp.Add(5);
            tmp.Add(7);
            tmp.AddRange(new int[] { 3, 4, -7, 9 });
            tmp.Sort();
            foreach(int el in tmp)
            {
                Console.WriteLine(el);
            }

            Stack<char> symbols = new Stack<char>();
            symbols.Push('a');
            symbols.Push('b');
            symbols.Push('-');
            symbols.Push('=');

            while(symbols.Count>0)
            {
                Console.WriteLine(symbols.Pop());
            }
            */

            ChekLine(Console.ReadLine());
            

        }


        static void ChekLine(string line)
        {
            Stack<char> symbols = new Stack<char>();
            for(int i=0;i<line.Length;i++)
            {
                if(line[i]=='{'|| line[i] == '['||line[i] == '(')
                {
                    symbols.Push(line[i]);
                }
                else if(line[i] == '}' || line[i] == ']' || line[i] == ')')
                { 
                    if(line[i]-symbols.Peek()<3)
                    {
                        if (symbols.Count > 0)
                            symbols.Pop();
                        
                        else
                        {
                            Console.WriteLine("wrong");
                        }
                    }
                    else
                    {
                        Console.WriteLine("wrong");
                    }
                }
            }
            if(symbols.Count>0)
                Console.WriteLine("wrong");
        }
    }
}
