using System;
namespace CSExercises
{
    public class Ex21
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Enter an integer number : ");
            bool isCondition = true;
            while (isCondition)
            {
                Console.WriteLine("Enter an integer number : ");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num == 88)
                {
                    Console.WriteLine("Lucky you...");
                    isCondition = false;
                }
            }
        }
    }
}
