using System;
namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            //int a = num1;

            Console.WriteLine("Enter Second Number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = num1 * num2;

            while (num1 != num2)
            {
                if (num1 > num2)
                {
                    num1 = num1 - num2;
                }
                else if (num2 > num1)
                {
                    num2 = num2 - num1;
                }
            }
            Console.WriteLine("HCF : " + num1);
            Console.WriteLine("LCM : " + num3 / num1);
        }
    }
}
