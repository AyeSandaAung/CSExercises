using System;
namespace CSExercises
{
    public class Ex46
    {
        public static void Main(string[] args)
        {
            int[, , , , , , , , ,] tenDimensionalArr = new int[0, 1, 2, 3, 4, 5, 6, 7, 8, 9];

            //for(int i=0; i=)

            for (int i = 0; i < 10; i++)
            {
                Random r = new Random();
                int random = r.Next(0, 9);
                Console.WriteLine(random);
            }
        }
    }
}


