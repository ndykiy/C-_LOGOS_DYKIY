using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_LOGOS_ENCAPSULATION_RUNNER
{
    class Program
    {
        static void Main(string[] args)
        {
            Runner[] runner = new Runner[2];


            runner[0] = new Runner() ;
           
            runner[1] = new Runner() ;

            runner[0].Print();
            runner[1].Print();


            int nMin = runner[0].time;
            for(int i=0;i<2;i++)
            {
                if(runner[i].time<nMin)
                {
                    nMin = runner[i].time;
                }
            }

            Console.WriteLine("The fastest is {0}", nMin);

        }
    }
}
