using System;

namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("X\t\tY");
            //y=2(x*x) - 4x +3   ------ Formula from exercise 9
            for (int i = -5; i < 6; i++)
            {
                //double j = ( 2*(Math.Pow(i,2)) - ((4*i) + 3));
                int j = 2 * (i * i) - (4 * i) + 3;
                Console.WriteLine("{0:0.0}\t\t{1:0.0}", i, j);

                for (int x = 1; x <= j; x++)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
            }
        }
    }
}
