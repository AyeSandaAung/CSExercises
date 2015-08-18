using System;

namespace CSExercises
{
    public class Ex33
    {
        public static void Main(string[] args)
        {
            int[] numbers = new int[] { 86, 35, 41, 49, 89, 51, 11, 71, 50, 75, 25, 58, 40, 14, 44, 3, 63, 81, 93, 79 };
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                    if (numbers[j] > numbers[i])
                    {
                        //swap
                        int temp = numbers[j];
                        numbers[j] = numbers[i];
                        numbers[i] = temp;
                    }
            }

            for(int i=0; i < numbers.Length;i++)
            {
                Console.Write(numbers[i] + "\t");
            }
            Console.WriteLine();
        }
    }
}
