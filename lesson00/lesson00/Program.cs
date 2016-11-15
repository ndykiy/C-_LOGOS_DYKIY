using System;


namespace lesson00
{
    class Program
    {
        static void Main(string[] args)
        {
            
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
        }
    }
}
