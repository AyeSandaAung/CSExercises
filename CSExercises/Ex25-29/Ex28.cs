using System;

namespace CSExercises
{
    public class Ex28
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            bool result = true ;
           
            for (int i = 2; i < num; i++)
            {
                if ( num % i == 0)
                {
                    Console.WriteLine("{0} is not Prime",num);
                    result = false;
                    break;
                }                           
            }
            if(result)
                Console.WriteLine("{0} is Prime", num);
        }
    }
}
