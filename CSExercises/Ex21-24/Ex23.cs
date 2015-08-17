using System;

namespace CSExercises
{
    public class Ex23
    {
        public static void Main(string[] args)
        {
            Random r = new Random();
            int num = r.Next(0, 9);
            int guessnum;
            Console.WriteLine("Enter your guess number : ");
            guessnum = Convert.ToInt32(Console.ReadLine());

            int count = 1;
            while (num != guessnum)
            {
                count++;
                Console.WriteLine("Try again! ");
                guessnum = Convert.ToInt32(Console.ReadLine());
            }
            switch (count)
            {
                case 1: Console.WriteLine("You are a Wizard!"); break;
                case 2: Console.WriteLine("You are a good guess!"); break;
                case 3: Console.WriteLine("You are lousy!"); break;
            }
            Console.WriteLine("You make {0} attempts.", count);
        }
    }
}
