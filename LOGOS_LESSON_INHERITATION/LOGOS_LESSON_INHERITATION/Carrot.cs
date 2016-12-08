using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGOS_LESSON_INHERITATION
{
    class Carrot:Product
    {

        public float length;
        // :base-constructor
        // .base-polia
        public Carrot(int mId,float mPrice,float mLength):base(mId,mPrice)
        {
            
            length = mLength;
        }

        public new void PrintGeneralInfo()
        {
            base.PrintGeneralInfo();
            Console.WriteLine("id:{0} price:{1}$ length is {2}cm", this.id, this.Price,length);
        }

    }
}
