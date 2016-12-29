using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class TestStack
    {
        public void CheckLine(string s)
        {
            Stack<string> sLine = new Stack<string>();
            string[] split = s.Split(new Char[] { ' ' });
            for(int i=0;i<split.Length;i++)
            {
                sLine.Push(split[i]);
            }

            Console.WriteLine("Elements in sentence:\n");

            for(int i = 0; i < split.Length; i++)
            {
                Console.WriteLine(sLine.Peek());
                sLine.Pop();
            }

        }
        


    }
}
