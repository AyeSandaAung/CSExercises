
using System;

namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter student marks : ");
            int mark = Convert.ToInt32(Console.ReadLine());

            if (mark < 0 || mark > 100)
            {
                Console.WriteLine("***error mark***");
            }
            else if (mark >= 80 && mark <= 100)
            {
                Console.WriteLine("A");
            }
            else if (mark >= 60 && mark <= 79)
            {
                Console.WriteLine("B");
            }
            else if (mark >= 40 && mark <= 59)
            {
                Console.WriteLine("C");
            }
            else if (mark >= 0 && mark <= 40)
            {
                Console.WriteLine("F");
            }

        }
    }
}