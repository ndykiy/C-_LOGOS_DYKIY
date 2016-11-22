using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_1_LOGOS
{
    class Program
    {
        static void Main(string[] args)
        {
            int nFirstMark;
            int nSecondMark;
            int nThirdMark;
            Console.WriteLine("Enter 3 marks:");
            nFirstMark = int.Parse(Console.ReadLine());
            nSecondMark = int.Parse(Console.ReadLine());
            nThirdMark = int.Parse(Console.ReadLine());
            Console.WriteLine("The average mark is: {0}",(float)(nFirstMark+nSecondMark+nThirdMark)/3);
        }
    }
}
