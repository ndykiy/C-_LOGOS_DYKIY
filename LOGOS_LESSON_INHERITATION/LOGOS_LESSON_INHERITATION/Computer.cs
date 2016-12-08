using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGOS_LESSON_INHERITATION
{
    sealed class Computer:Product
    {
        public string name;
        public string proc;
        public bool touchscreen;


        public Display display;

        public Computer(string mName,string mProc,bool mTouchScreen,int mPrice):base(23145,mPrice)
        {
            name = mName;
            proc = mProc;
            touchscreen = mTouchScreen;
            display = new Display(mName, 0, 0, mPrice * 0.25f);
        }


        public override string ToString()
        {
            return "Name " + name + "\nproc " + proc + "\ntouchscreen " + touchscreen + "\nprice "  + Price;
        }

    }
}
