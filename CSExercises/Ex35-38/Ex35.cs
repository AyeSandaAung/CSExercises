using System;

namespace CSExercises
{
    public class Ex35
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a phrase : ");
            string phrase = Console.ReadLine();

            int count = 0, countA = 0, countE=0, countI = 0, countO = 0, countU = 0;
            for (int i = 0; i < phrase.Length; i++)
            {
                string checkVowel= phrase.Substring(i, 1);
                
                switch (checkVowel.ToLower())
                {
                    case "a": count++; countA++; break;
                    case "e": count++; countE++; break;
                    case "i": count++; countI++; break;
                    case "o": count++; countO++; break;
                    case "u": count++; countU++; break;
                }
            }
            Console.WriteLine("Total numbers of vowels : " + count);
            Console.WriteLine("Numbers of a : " + countA);
            Console.WriteLine("Numbers of e : " + countE);
            Console.WriteLine("Numbers of i : " + countI);
            Console.WriteLine("Numbers of o : " + countO);
            Console.WriteLine("Numbers of u : " + countU);
        }
    }
}
