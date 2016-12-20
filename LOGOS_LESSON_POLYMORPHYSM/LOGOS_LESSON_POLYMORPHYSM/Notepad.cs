using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGOS_LESSON_POLYMORPHYSM
{
    class Notepad:Product
    {
        int numOfPages;

        public Notepad(int ID,int Price,string Country,int NumOfPages):base(ID,Price,Country)
        {
            numOfPages = NumOfPages;
        }

    }
}
