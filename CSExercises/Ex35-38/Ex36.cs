using System;

namespace CSExercises
{
    public class Ex36
    {
        public static void Main(string[] args)
        {
            string input, separateString1=string.Empty, separateString2 = string.Empty;
            int startNo = 0;
            Console.WriteLine("Enter a string : ");
            input = Console.ReadLine();

            input.Trim(new char[] { '"','!','@','#','$','%','^','&','*','(',')','.',',' });
            if (input.Length % 2 == 0)
            {
                startNo = input.Length / 2;
                separateString1 = input.Substring(startNo);                
                separateString2 = input.Substring(0, startNo - 1);
            }
            else
            {
                startNo = input.Length / 2;
                Console.WriteLine(startNo);
            }
                        
            ////if(separateString1.ToUpper() == separateString2.ToUpper())            
            //if (separateString1.ToUpper().CompareTo(separateString2.ToUpper())            
            //    Console.WriteLine(" Palindrome ");
            
            //else
            //    Console.WriteLine(" Not Palindrome ");
            
        }
    }
}
