using System;

namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your name : ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your gender , M for Male and F for Female : ");
            string gender = Console.ReadLine();

            Console.WriteLine("Enter your age : ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age < 200 && age >= 40)
            {
                if (gender.Length > 1)
                    Console.WriteLine("Invalid Gender!");
                else if (gender == "M")
                    Console.WriteLine("Good Morning Uncle " + name);
                else if (gender == "F")
                    Console.WriteLine("Good Morning Aunty " + name);
                else
                    Console.WriteLine("Invalid Gender");
            }
            else if (age >= 1 && age < 40)
            {
                if (gender.Length > 1)
                    Console.WriteLine("Invalid Gender!");
                else if (gender == "M")
                    Console.WriteLine("Good Morning Mr." + name);
                else if (gender == "F")
                    Console.WriteLine("Good Morning Ms." + name);
                else
                    Console.WriteLine("Invalid Gender");
            }
            else
            {
                Console.WriteLine("Invalid Age!");
            }
        }
    }
}