using System;

namespace CSExercises
{
    public class Ex29
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            bool result = false; int perfectNum = 0;
            //first find factor number
            for (int i = 1; i <num; i++)
            {
                if (num % i == 0)
                {
                    perfectNum += i;
                    if (perfectNum == num)
                    {
                        Console.WriteLine("{0} is Perfect Number", perfectNum);
                        result = true;
                        break;
                    }                              
                }
            }            
            if(!result)
            {
                Console.WriteLine("{0} is Not Perfect Number", num);
            }
        }
    }
}
