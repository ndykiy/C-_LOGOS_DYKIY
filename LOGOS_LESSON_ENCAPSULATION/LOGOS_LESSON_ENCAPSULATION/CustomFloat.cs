using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGOS_LESSON_ENCAPSULATION
{
    class CustomFloat
    {
        public int FirstPart;
        public float SecondPart;
        public float Full;

        const float p = 3.14159f;
        public readonly float numOfNumbers = p;

        public CustomFloat(float num)
        {
            numOfNumbers = num;
        }

      /*  public CustomFloat(int part1,float part2)
        {
            FirstPart = part1;
            SecondPart = part2;

            float full = (float)(part1 + part2);
            part1 = (int)(full - part2);
            part2 = (float)full - (float)part1;
        }

        public CustomFloat(float full)
        {
            Full = full;

            full = (float)FirstPart + SecondPart;
        }
        */
        public int firstPart
        {
            set
            {
                firstPart = value;
            }
        }

        public float secondPart
        {
            set
            {
                if (Math.Abs(value) < 1f)
                {
                    secondPart = value;
                }
                else secondPart = 0f;
            }
        }

        public void Print()
        {
            Console.WriteLine(FirstPart + SecondPart);
        }

    }
}
