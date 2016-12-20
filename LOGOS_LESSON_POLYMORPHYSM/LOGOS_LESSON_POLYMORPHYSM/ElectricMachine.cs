using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGOS_LESSON_POLYMORPHYSM
{
    abstract class ElectricMachine
    {
        public int price { get; set; }
        public string manufacture { get; set; }
        
        public ElectricMachine(string manuf,int pr)
        {
            manufacture = manuf;
            price = pr;
        }

        public virtual void GetParts()
        {
            Console.WriteLine("No parts");
        }

        public abstract int GetNumberOfParts();
        
    }
}
