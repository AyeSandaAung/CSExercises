using System;

namespace CSExercises
{
    public class Ex29
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            bool result = false ;
            //first find factor number
            for (int i = 1; i <= num; i++)
            {
                i += i;
                if (i == num)
                {
                    Console.WriteLine("{0} is Perfect Number", num);
                    result = true ;
                    break;
                }
            }
            if(!result)
            {
                Console.WriteLine("{0} is Not Perfect Number", num);
            }
        }
    }
}
