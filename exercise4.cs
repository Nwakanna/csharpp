using System;

namespace Coding.Exercise
{
    public class Exercise
    {
        public static int CalculateSumOfNumbersBetween(int firstNumber, int lastNumber)
        {
            //your code goes here
            int currentNum = firstNumber;
            int sum = 0;
            
            while(currentNum <= lastNumber){
                sum += currentNum;
                currentNum++;
            }
            return sum;
        }
    }
}
