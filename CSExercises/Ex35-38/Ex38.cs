using System;

namespace CSExercises
{
    public class Ex38
    {
        public static void Main(string[] args)
        {
            int i = 0, j = 0, temp=0;
            string str;
            
            string[] nameArray = new string[] { "John", "Venkat", "Mary", "Victor", "Betty" };
            int[] markArray = new int[] { 63, 29, 75, 82, 55 };

            for (i = 0; i < markArray.Length-1; i++)
            {
                for(j=i+1; j < markArray.Length; j++)
                {
                    if (markArray[j] > markArray[i])
                    {
                        temp = markArray[i];
                        markArray[i] = markArray[j];
                        markArray[j] = temp;

                        str = nameArray[i];
                        nameArray[i] = nameArray[j];
                        nameArray[j] = str;                       
                    }  
                }
            }

            for (i = 0; i < nameArray.Length; i++)
            {
                Console.WriteLine(nameArray[i] + "\t" + markArray[i]);
            }
            Console.WriteLine();
                for (i = 0; i < nameArray.Length; i++)
                {
                    for (j = 0; j < nameArray.Length; j++)
                    {
                        if (nameArray[j].ToUpper().CompareTo(nameArray[i].ToUpper()) == 1)  //equal=0 , less than=-1 , greaterthan = 1
                        {
                            temp = markArray[i];
                            markArray[i] = markArray[j];
                            markArray[j] = temp;

                            str = nameArray[i];
                            nameArray[i] = nameArray[j];
                            nameArray[j] = str;
                        }
                    }
                }

                for (i = 0; i < nameArray.Length; i++)
                {
                    Console.WriteLine(nameArray[i] + "\t" + markArray[i]);
                }

                Console.WriteLine();
        }
    }
}
