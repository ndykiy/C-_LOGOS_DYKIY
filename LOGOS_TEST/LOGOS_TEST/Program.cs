using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGOS_TEST
{
    class Program
    {
        static void Main(string[] args)
        {

            
            string sQ1 = "Enter course, we attend";
            string[] sA1 = new string[3];
            sA1[0] = "C#";
            sA1[1] = "html css";
            sA1[2] = "sql db";
            

            string sQ2 = "Enter today's month";
            string[] sA2 = new string[3];
            sA2[0] = "august";
            sA2[1] = "december";
            sA2[2] = "half moon";
            
            string sQ3 = "Enter today's day of week";
            string[] sA3 = new string[3];
            sA3[0] = "monday";
            sA3[1] = "tuesday";
            sA3[2] = "thursday";
            
            string sQ4 = "Enter today's year";
            string[] sA4 = new string[3];
            sA4[0] = "2007";
            sA4[1] = "1415";
            sA4[2] = "2016";

            int[] aA = new int[4];
            aA[0] = 1;
            aA[1] = 2;
            aA[2] = 3;
            aA[3] = 3;
            int[] a = new int[4];
            int nResult = 0;
            Question(sQ1, sA1);
            a[0] = int.Parse(Console.ReadLine());
            if (a[0] == aA[0])
                nResult++;

            Question(sQ2, sA2);

            a[1] = int.Parse(Console.ReadLine());
            if (a[1] == aA[1])
                nResult++;

            Question(sQ3, sA3);
            a[2] = int.Parse(Console.ReadLine());
            if (a[2] == aA[2])
                nResult++;

            Question(sQ4, sA4);
            a[3] = int.Parse(Console.ReadLine());
            if (a[3] == aA[3])
                nResult++;


            Console.WriteLine("Your result is " + nResult);


        }

        static void Question(string sQuestion,params string[] sAnswer)
        {
           
           
            Console.WriteLine(sQuestion);
            for (int i=0;i<3;i++)
            {
                Console.WriteLine((i+1)+sAnswer[i]);
                
            }

            



           
        }

    }
}
