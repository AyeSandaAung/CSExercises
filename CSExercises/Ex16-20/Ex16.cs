using System;

namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your name : ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your gender , M for Male and F for Female : ");
            string gender = Console.ReadLine();

            if (gender == "M")
            {
                Console.WriteLine("Good Morning Mr." + name);
            }
            else if (gender == "F")
            {
                Console.WriteLine("Good Morning Ms." + name);
            }
            else
            {
                Console.WriteLine("Invalid Gender!");
            }
        }
    }
}