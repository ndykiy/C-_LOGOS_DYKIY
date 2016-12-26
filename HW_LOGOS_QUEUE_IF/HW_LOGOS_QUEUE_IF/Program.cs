using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_LOGOS_QUEUE_IF
{
    class Program
    {
        static void Main(string[] args)
        {
            ChekString(Console.ReadLine());
        }

        static void ChekString(string s)
        {
            Queue<string> stringIf=new Queue<string>();
            string[] split = s.Split(new Char[] { ' ', ',', ':', ';' });
            int k = split.Length;
            int nResult=0;
            for (int i=0;i<k;i++)
            {
               
                    //тут треба додати елемент в чергу
                  stringIf.Enqueue(split[i]);
                 if(split[i]=="if"||split[i]=="If"||split[i]=="IF")
                {
                     nResult++;
                 }
                
            }

            Console.WriteLine("Elements in queue");

            for (int i = 0; i < stringIf.Count; i++)
            {
                
                Console.WriteLine(stringIf.Peek());
                stringIf.Dequeue();
            }

            Console.WriteLine("Quantity of 'if' words in line is " + nResult);

        }
    }
}
