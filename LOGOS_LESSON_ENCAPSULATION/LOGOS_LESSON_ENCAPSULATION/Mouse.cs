using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGOS_LESSON_ENCAPSULATION
{
    class Mouse
    {
        public int numOfKeys;
        private int dpi;
        public string model;
        


        public Mouse(string mModel="",int mNumOfKeys=2,int mDPI=800)
        {
            model = mModel;
            numOfKeys = mNumOfKeys;
            //dpi = mDPI;
            SetDpi(mDPI);
        }

        public int GetDpi()

        {
            return dpi;
        }

        public void SetDpi(int dpi)
        {
            this.dpi = dpi-(dpi%400);

        }

        public void Print()
        {
            Console.WriteLine("Mouse: {0} {1} {2}", model, numOfKeys, dpi);
        }

    }
}
