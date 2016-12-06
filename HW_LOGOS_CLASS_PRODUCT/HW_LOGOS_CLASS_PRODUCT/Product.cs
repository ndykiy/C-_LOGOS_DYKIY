using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_LOGOS_CLASS_PRODUCT
{
    class Product
    {
       public string name;
       public int price;
       public string category;
       
        public Product(string sName="unknown",int nprice=0,string scategory="undefined")
       {
           name = sName;
           price = nprice;
           category = scategory;
       }

        public void Print()
        {
                Console.WriteLine("{0} {1} {2}",name, price, category);
            
        }

    }
}
