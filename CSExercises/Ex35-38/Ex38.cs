using System;

namespace CSExercises
{
    public class Ex38
    {
        public static void Main(string[] args)
        {
            int i=0, j=0;
            string temp;
            string[] nameArray = new string[] { "John", "Venkat", "Mary", "Victor", "Betty" };
            int[] markArray = new int[] { 63, 29, 75, 82, 55 };

            for (i = 0; i < markArray.Length-1; i++)
            {
                for(j=i+1; j < markArray.Length; j++)
                {
                    if (markArray[j] > markArray[i])
                    {
                        //temp = i;
                        markArray[i] = markArray[j];
                    }
                }
            }

                for (i = 0; i < nameArray.Length; i++)
                {
                    for (j = 0; j < markArray.Length; j++)
                    {

                    }
                }
        }
    }
}
