 using System;

namespace CSExercises
{
    public class Ex37
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a string : ");
            string input = Console.ReadLine();
            string upperString, lowerString, result="";
            string[] inputArray  = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < inputArray.Length; i++)
            {
                upperString = inputArray[i].Substring(0,1).ToUpper();
                lowerString = inputArray[i].Substring(1, inputArray[i].Length-1);
                result += upperString+lowerString+" ";
            }
            Console.WriteLine(result);
        }
    }
}
