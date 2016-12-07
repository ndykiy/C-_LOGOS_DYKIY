using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_LOGOS_ENCAPSULATION_RUNNER
{
    class Runner
    {
        private string sName;
        private int nTime;

        private static readonly Random getrandom = new Random();
        private static readonly object syncLock = new object();
        public static int GetRandomNumber(int min, int max)
        {
            lock (syncLock)
            { // synchronize
                return getrandom.Next(min, max);
            }
        }

        public Runner()
        {
            nTime = GenerateTime();
            sName = GenerateName();
        }

        public string name
        {
            get
            {
                return sName;
            }
            set
            {
                sName= GenerateName();
            }
        }

        public static  string GenerateName()
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            int size = 10;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Runner.GetRandomNumber(0,26) + 65));
                builder.Append(ch);
            }
            return builder.ToString();
        }


        public int time
        {
            get
            {
                return nTime;
            }
            set
            {
                nTime = GenerateTime();
            }
        }

        public static int GenerateTime()
        {
            Random rand = new Random();
            return Runner.GetRandomNumber(1, 15);
       
        }

        public void Print()
        {
            Console.WriteLine("{0} {1}", sName, nTime);
        }

    }
}
