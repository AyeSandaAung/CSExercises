using System;

namespace CSExercises
{
    public class Ex39
    {
        public static double Factorial(double n)
        {
            double result = n;             
            //string str = "";
            for (double i = 1; i <= result; i++)
            {   
                //str += i + "*";
                Console.Write(i);
                if(i!=result)
                    Console.Write("*");
                else
                    Console.Write("=");
                n *= n - i;
            }
            //Console.Write(str);
            return n;
        }

        static double ReceiveInput(string prompt)
        {
            Console.Write(prompt);
            double num = Convert.ToDouble(Console.ReadLine());
            return num;
        }
        static void Main(string[] args)
        {
            double num = ReceiveInput("Enter a number : ");
            double returnNumber = Factorial(num);
            Console.WriteLine(returnNumber);
        }
    }
}
