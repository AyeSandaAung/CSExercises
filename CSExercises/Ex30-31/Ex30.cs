using System;

namespace CSExercises
{
    public class Ex30
    {
        public static void Main(string[] args)
        {
            int j;
            for (int i = 1; i <= 1000; i++)
            {
                for (j = 2; j < i; j++)    
                {
                    if (i % j == 0)
                    {
                        // Console.WriteLine("{0} is not prime number ", i);
                        Console.WriteLine(i);
                        break;
                    }
                }
                if (i == j)     // only prime number is only divisible by one and itself.   eg 19/19 ,2/2,13/13
                {
                    Console.WriteLine("{0} is prime Number ", i);
                }
            }
        }
    }
}
