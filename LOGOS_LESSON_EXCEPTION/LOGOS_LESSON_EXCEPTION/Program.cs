using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LOGOS_LESSON_EXCEPTION
{

    /* class VeryBadFatalExceptionError:ApplicationException
     {
         public VeryBadFatalExceptionError()
         {
             Data.Add("Message", "Very Bad Fatal Exception Error");
         }
     }
     */

         class SpaceNotFoundException : ApplicationException
     {

         public SpaceNotFoundException()
         {
             Data.Add("Message", "Positions of spaces are wrong");
         }
     }
     


    class Program
    {
        static void Main(string[] args)
        {
            /*
            int result = 0;
            try
            {
                Console.WriteLine("Enter number");
                int num = int.Parse(Console.ReadLine());
                if(num>1999)
                {
                    throw new VeryBadFatalExceptionError();
                }
                result = 5 / num;
            }
            
          

            catch (Exception e)
            {
                if(e is DivideByZeroException)
                {
                    Console.WriteLine("Error: {0}\nInfo {1}", "DivideByZeroException", e.Message);
                }
                if(e is FormatException)
                {
                    Console.WriteLine(e.Message);
                }
                if(e is StackOverflowException)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("StackOverflow");
                }
                if(e is VeryBadFatalExceptionError)
                {
                    Console.WriteLine(e.Data["Message"]);
                }
            }
            


            int a = 0;
            int b = 0;
            char op=' ';
            string s;
            int num=0;
            int rez = 0;

            Console.WriteLine("Enter line:\n");
            s = Console.ReadLine();



            try
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == ' ')
                    {
                        num++;
                    }

                    if (num != 2)
                    {
                        throw new SpaceNotFoundException();
                    }

                }          
            }
            

            catch (SpaceNotFoundException e)
            {
                
                    Console.WriteLine(e.Data["Message"]);
                
            }


            int[] k = new int[2];
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    if (k[0] == 0)
                    {
                        k[0] = i;
                    }
                    else k[1] = i;
                }
            }
            op = s[k[0] + 1];
            rez = 0;

            a = int.Parse(s.Substring(0, k[0]));
            b = int.Parse(s.Substring(k[1] + 1, s.Length - k[1] - 1));
            Console.WriteLine("a {0},b {1}, op {2}", a, b, op);

            switch (op)
            {
                case '+':
                    rez = a + b;
                    break;
                case '-':
                    rez = a - b;
                    break;
                case '*':
                    rez = a * b;
                    break;
                case '/':
                    rez = a / b;
                    break;
            }

            Console.WriteLine("{0} {1} {2} = {3} ", a, op, b, rez);


    */

            /*File.Create("D:\\file.txt");
            File.WriteAllText("D:\\file.txt", "hello");
            

            FileStream file = new FileStream("D:\\new_file.txt",FileMode.Create,FileAccess.ReadWrite);

            StreamWriter w = new StreamWriter(file);
            w.WriteLine("hello, new file");
            w.WriteLine("hello!") ;


            StreamReader r = new StreamReader(file);
            Console.WriteLine(r.ReadToEnd());

            w.Close();
            r.Close();*/






            int a = 0;
            int b = 0;
            char op = ' ';

            int num = 0;
            int rez = 0;
      

            StreamReader fileAction = new StreamReader(new FileStream("D:\\file_action.txt", FileMode.Open, FileAccess.Read));
            StreamWriter fileResult = new StreamWriter(new FileStream("D:\\file_result.txt", FileMode.OpenOrCreate, FileAccess.Write));


            Stack<string> strichka=new Stack<string>();


            while (!fileAction.EndOfStream)
            {
                strichka.Push(fileAction.ReadLine());
            }


            fileAction.Close();

            foreach(string s in strichka) { 
            int[] k = new int[2];
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    if (k[0] == 0)
                    {
                        k[0] = i;
                    }
                    else k[1] = i;
                }
            }
            op = s[k[0] + 1];
            rez = 0;

            a = int.Parse(s.Substring(0, k[0]));
            b = int.Parse(s.Substring(k[1] + 1, s.Length - k[1] - 1));


            switch (op)
            {
                case '+':
                    rez = a + b;
                    break;
                case '-':
                    rez = a - b;
                    break;
                case '*':
                    rez = a * b;
                    break;
                case '/':
                    rez = a / b;
                    break;
            }

            fileResult.WriteLine(rez);
        }


        fileResult.Close();
        }
    }
}
