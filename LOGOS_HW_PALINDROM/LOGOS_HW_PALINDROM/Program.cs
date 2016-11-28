using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGOS_HW_PALINDROM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter word");
            string sWord = Console.ReadLine();
            char[] cWord = sWord.ToCharArray();
            int nLength = sWord.Length;
            bool[] bPal=new bool[nLength];
            Console.WriteLine(sWord);
            for (int i=0;i<nLength/2;i++)
            {
                if (cWord[i]==cWord[nLength-i-1])
                {
                    bPal[i] = true;
                }
            }
            bool bResult = true;
            for (int i=0;i<nLength/2;i++)
            {
                if (bPal[i] != true)
                    bResult = false;
            }
            Console.WriteLine(bResult);
            if (bResult == true)
                Console.WriteLine("This word is palindrom");
            else
            {
                Console.WriteLine("This word is not palindrom");
            }
        }
    }
}
