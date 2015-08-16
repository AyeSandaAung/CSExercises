using System;

namespace CSExercises
{
    public class Ex15
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Enter 3digit integer : ");
            int a = Convert.ToInt32(Console.ReadLine());
            //int[] x = new int[3];
            int x = 0,y = 0,z = 0;
            if (a.ToString().Length == 3)
            {
                for (int i = 0; i < 3; i++)
                {
                    //x[i] = Convert.ToInt32(a.ToString().TrimStart());
                    switch(i)
                    {
                        case 0: x = Convert.ToInt32(a.ToString().Substring(i,1)); break;
                        case 1: y = Convert.ToInt32(a.ToString().Substring(i,1)); break;
                        case 2: z = Convert.ToInt32(a.ToString().Substring(i,1)); break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid 3 digit number.");
            }
            x = Convert.ToInt32(Math.Pow(x, 3));
            y = Convert.ToInt32(Math.Pow(y, 3));
            z = Convert.ToInt32(Math.Pow(z, 3));
            Console.WriteLine("The result of 3digit number is {0}", x+y+z);
        }
    }
}