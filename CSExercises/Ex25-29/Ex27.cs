using System;

namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("X\t\tY");
            //y=2(x*x) - 4x +3   ------ Formula from exercise 9
            int j=0;
            for (int i = -5; i < 6; i++)
            {                
                j = 2 * (i * i) - (4 * i) + 3;
                Console.WriteLine("{0:0.0}\t\t{1:0.0}", i, j);               
            }

            for (int i = -5; i < 6; i++)
            {                
                j = 2 * (i * i) - (4 * i) + 3;
                //Console.WriteLine("{0:0.0}\t\t{1:0.0}", i, j);
                for (int x = 1; x <= j; x++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
        }
    }
}
