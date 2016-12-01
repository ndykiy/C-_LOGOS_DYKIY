using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGOS_LESSON_OOP
{
    class PC
    {
        public string sModel;
        public int nPrice;
        public string sCPU;
        public int nMemory;
        public bool bIsOn;

        //public PC()this:PC



        //необов'язкові параметри
        /*public PC(string sPCModel="unnamed",int nPCPrice=0,string sPCCPU="unknown",int nPCMemory=0,bool bPCIsOn=false)
        {
            sModel = sPCModel;
            nPrice = nPCPrice;
            sCPU = sPCCPU;
            nMemory = nPCMemory;
            bIsOn = bPCIsOn;
        }


        public void PrintPC()
        {
            Console.WriteLine("{0},{1},{2},{3},{4}",sModel, nPrice, sCPU, nMemory, bIsOn);
        }
        */

        //починаєм ланцюжок

            public PC(string sPCModel,int nPCMemory):this( sPCModel,  12000,  "radeon",nPCMemory,  true)
        {

        }

        public PC(string sPCModel , int nPCPrice , string sPCCPU , int nPCMemory , bool bPCIsOn )
        {
            sModel = sPCModel;
            nPrice = nPCPrice;
            sCPU = sPCCPU;
            nMemory = nPCMemory;
            bIsOn = bPCIsOn;
        }

        public void PrintPC()
        {
            Console.WriteLine("{0},{1},{2},{3},{4}", sModel, nPrice, sCPU, nMemory, bIsOn);
        }

    }
}
