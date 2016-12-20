using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGOS_LESSON_POLYMORPHYSM
{
    class Chair:Furniture
    {
        public Chair(int ID, int Price, string Country, string Material):base(ID, Price, Country, Material)
        {

        }
    }
}
