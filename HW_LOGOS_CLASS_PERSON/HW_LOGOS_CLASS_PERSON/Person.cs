using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_LOGOS_CLASS_PERSON
{
    class Person
    {
        public string sName;
        public string sSurname;
        public float fHeight;
        public float fWeight;
        public int nAge;
        public string sGender;
        public bool bIsAlive;


        public Person() { }

        public Person(string name) : this(name,"undefined",189.5f,87.5f,37,"male",true)
        {

        }

        public Person(string surname="adriana",int age=25):this("unknown",surname,189.5f,87.5f,age,"female",false)
        {

        }

        

        public Person (string sName,string sSurname,float fHeight,float fWeight, int nAge,string sGender, bool bIsAlive)
        {
            this.sName = sName;
            this.sSurname = sSurname;
            this.fHeight = fHeight;
            this.fWeight = fWeight;
            this.nAge = nAge;
            this.sGender = sGender;
            this.bIsAlive = bIsAlive;

        }

         public void Print()
        {
            Console.WriteLine(sName, sSurname, fHeight, fWeight, nAge, sGender, bIsAlive);
        }

    }
}
