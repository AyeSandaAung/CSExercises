using System;

namespace CSExercises
{
    public class Ex41
    {
        public static bool InString(string s1, string s2)
        {   
            int length = 0;
            if (s1.Length == s2.Length)
            {
                if (s2.ToUpper().CompareTo(s1.ToUpper()) == 0)
                    return true;
                else
                    return false;

            }
            if (s1.Length > s2.Length)
            {               
                for (int i = 0; i < s1.Length; i++)
                {
                    length = s1.Length - i; //to know the rest length of s2
                    if (length < s2.Length) return false;
                    else
                    {                        
                        if (s2.ToUpper().CompareTo(s1.Substring(i, s2.Length).ToUpper()) == 0)
                        {                           
                            return true;
                        }
                    }

                }
                return false;
            }
            else
            {
                return false;
            }                    
        }

        static void Main(string[] args)
        {
            Console.Write("Enter First String : ");
            string firstString = Console.ReadLine();

            Console.Write("Enter Second String : ");
            string secondString = Console.ReadLine();

            if (InString(firstString, secondString))
                Console.WriteLine("Correct");
            else
                Console.WriteLine("InCorrect");            
        }
    }
}
