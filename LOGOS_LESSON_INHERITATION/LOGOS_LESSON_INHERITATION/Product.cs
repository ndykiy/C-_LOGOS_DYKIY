using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGOS_LESSON_INHERITATION
{
    class Product
    {
        public readonly int id;
        protected float price;

        public float Price
        {
            get
            {
                return price;
            }
            set
            {
                price = (int)value+1f - 0.01f;
            }
        } 

        public Product(int mId, float mPrice=10.99f)
        {
            id = mId;
            Price = mPrice;
        }

        public void PrintGeneralInfo()
        {
            Console.WriteLine("id:{0} price:{1}$",id,price);
        }
    }
}
