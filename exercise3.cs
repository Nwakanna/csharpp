using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static int AbsoluteOfSum(/*define parameters here*/int a, int b)
        {
            //your code goes here
         var sum = a + b;
         if (sum >= 0)
         {
             return sum;
         }
         else
         {
             return -sum;
         }
        }
    }
}
