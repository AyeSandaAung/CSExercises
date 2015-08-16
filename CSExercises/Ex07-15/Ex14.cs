using System;

namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("To dertermine Area of triangle,Please Enter 1st length : ");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please Enter 2nd length : ");
                double b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Please Enter 3rd length : ");
                double c = Convert.ToDouble(Console.ReadLine());

                //Area = square root of [s(s-a)*(s-b)*(s-c)] where s = (a+b+c)/2;
                double s = (a + b + c) / 2.0;
                double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                Console.WriteLine("Area of the Triangle is {0}", area);
            }
            catch
            {
                Console.WriteLine("Area of the Triangle is {0}", 0);
            }
        }
    }
}