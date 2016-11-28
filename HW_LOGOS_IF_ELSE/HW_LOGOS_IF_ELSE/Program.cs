using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_LOGOS_IF_ELSE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter distance");
            int nDistance = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter day or night (d or n)");
            char cTime = char.Parse(Console.ReadLine());
            int  nPrice=0,nPriceKm=0;
            if(nDistance<=10)
            {
                nPriceKm = 5;
                
            }
            else
            {
                if(nDistance>10&&nDistance<=20)
                {
                    nPriceKm = 4;
                    
                }
                else
                {
                    if(nDistance>20)
                    {
                        nPriceKm = 3;
                        
                    }
                    
                }
            }
            nPrice = 30 + nDistance * nPriceKm;
            if(cTime=='n')
            {
                nPrice = nPrice / 2;
            }
            Console.WriteLine("Price of trip ={0}", nPrice);

        }
    }
}
