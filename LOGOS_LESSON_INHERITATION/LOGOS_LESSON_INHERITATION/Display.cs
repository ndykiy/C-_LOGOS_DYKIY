using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGOS_LESSON_INHERITATION
{
    class Display:Product
    {
        public string model;
        public int width;
        public int height;
        public new int id;


        public string Resolution
        {
            get
            {
                return width + "x" + height;
            }
        }

        public Display(string mModel,int mWidth,int mHeight,float mPrice):base(456748521,mPrice)
        {
            model = mModel;
            width = mWidth;
            height = mHeight;
        }


      
    }
}
