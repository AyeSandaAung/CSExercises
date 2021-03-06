using System;

namespace CSExercises
{
    public class Ex34
    {
        public static void Main(string[] args)
        {
            int[,] markArray = new int[12, 4] { { 56, 84, 68, 29 }, { 94, 73, 31, 89 }, { 41, 63, 36, 90 }, { 99, 9, 18, 17 },
                                                     { 62, 3, 65, 75 }, { 40, 96, 53, 23 }, { 81, 15, 27, 30 }, { 21, 70, 100, 22 },
                                                    { 88, 50, 13, 12 }, { 48, 54, 52, 78 }, { 64, 71, 67, 25 }, { 16, 93, 46, 72 } };

            int i = 0, j = 0, totaleach = 0, studentcount = 1;
            double firstAverage = 0, secondAverage = 0, thirdAverage = 0, fourthAverage = 0, totalAll = 0; 
            for ( i = 0; i < markArray.GetLength(0); i++)
            {
                for( j=0; j <  markArray.GetLength(1);j++)
                {
                    totaleach += markArray[i, j];
                    totalAll += markArray[i, j];                      
                }               
                Console.WriteLine("Total mark for student No.{0} : {1} ", studentcount++, totaleach);
                totaleach = 0;

                firstAverage += markArray[i, 0];
                secondAverage += markArray[i, 1];
                thirdAverage += markArray[i, 2];
                fourthAverage += markArray[i, 3]; 
            }
            Console.WriteLine();
            Console.WriteLine("Average Marks for first subject : {0}", firstAverage / 12);
            Console.WriteLine("Average Marks for second subject  : {0}", secondAverage / 12);
            Console.WriteLine("Average Marks for third subject  : {0}", thirdAverage / 12);
            Console.WriteLine("Average Marks for fourth subject  : {0}", fourthAverage / 12);
            
            Console.WriteLine("Overtall average of marks for the whole class : {0} ", totalAll / 12);
        }
    }
}
