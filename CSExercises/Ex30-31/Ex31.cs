using System;

namespace CSExercises
{
    public class Ex31
    {
        public static void Main(string[] args)
        {
            int j;
            int perfectNumber=0;
            for (int i = 1; i <= 1000; i++)   //if result show start from 720 , pls check the condition with 100;
            {
                for (j = 1; j < i; j++)
                {
                    if(i%j == 0)                 // 6 is perfect number because the sum of his factorial number (6,5,4,3,2,1) got 6. eg . 6=1+2+3
                    {
                        perfectNumber += j;                        
                    }                   
                }
                if (perfectNumber == i)
                {
                    Console.WriteLine("{0} is perfect Number ", i);                   
                }
                perfectNumber = 0;
            }
        }
    }
}
