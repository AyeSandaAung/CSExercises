using System;

namespace CSExercises
{
    public class Ex42
    {
        public static int FindWord(string s1, string s2)
        {
            int index = 0;
            if (s1.Length == s2.Length)
            {
                if (s2.ToUpper().CompareTo(s1.ToUpper()) == 0)
                    return index = 0;
                else
                    return index = -1;
            }

            int length = 0;
            if (s1.Length > s2.Length)
            {
                for (int i = 0; i < s1.Length; i++)
                {
                    length = s1.Length - i; //to know the rest length of s2
                    if (length < s2.Length) 
                        return index = -1;
                    else
                    {
                        if (s2.ToUpper().CompareTo(s1.Substring(i, s2.Length).ToUpper()) == 0)
                        {
                            return index = 0;
                        }
                    }

                }
               // index = -1;
            }
            else
            {
                return index = -1;
            }
            return index;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter First String : ");
            string firstString = Console.ReadLine();

            Console.Write("Enter Second String : ");
            string secondString = Console.ReadLine();

            int index = FindWord(firstString, secondString);
            if(index == 0)
                Console.WriteLine(("start position of the find word " + index));
            else
                Console.WriteLine(index);
        }
    }
}
