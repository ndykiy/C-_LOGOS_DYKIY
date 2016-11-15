using System;


namespace lesson00
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("enter 1 number");
            int i1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter 2 number");
            int i2 = int.Parse(Console.ReadLine());
            int sum = i1 + i2;
            int diff = i1 - i2;
            int mult = i1 * i2;
            float div = i1 /(float)i2;
            Console.WriteLine("suma " + sum);
            Console.WriteLine("riznytsia " + diff);
            Console.WriteLine("mnozhennya " + mult);
            Console.WriteLine("dilennya " + div);
            

            uint max = uint.MaxValue;
            max = max + 10;
            Console.WriteLine(max);
            */

            Console.WriteLine("enter number 0-7");
            int num = int.Parse(Console.ReadLine());
            int v3 = num % 2;
            int knum = num;
            num = num / 2;
            int v2 = num / 2;
            num = num / 2;
            int v1 = num / 2;
            Console.WriteLine("{0}={1}{2}{3}",knum,v1,v2,v3);
       }
    }
}
