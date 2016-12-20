using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGOS_LESSON_POLYMORPHYSM
{
    class Printer:ElectricMachine
    {
        public Printer (string manuf, int pr):base(manuf,pr)
        {

        }

        public override void GetParts()
        {
            Console.WriteLine("Cartrige, block, power");
        }

        public override int GetNumberOfParts()
        {

            return 3;
            //throw new NotImplementedException();
        }
    }
}
