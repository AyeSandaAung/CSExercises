using System;

namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = num;

            //increment counter
            for(int i=1; i<temp; i++ )
            {                
                num *= (temp - i);                
            }
            Console.WriteLine("factorial result : " + num);

            //decrement counter
            for(int j=temp; j >= 2; j--)
            {
                num *= (j - 1);  
            }
            Console.WriteLine("factorial result : " + num);

        }
    }
}
