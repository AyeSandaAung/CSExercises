using System;

namespace CSExercises
{
    public class Ex44
    {
        public static string Substitute(string s, char c1, char c2)
        {
            string[] strArray = new string[s.Length];
            string result = null;
            for (int i = 0; i < s.Length;i++)
            {
                strArray[i] = s.Substring(i, 1);
                if (c1.ToString().ToUpper() == strArray[i].ToString().ToUpper())
                {
                    strArray[i] = Convert.ToString(c2);
                }
                result += strArray[i];
            }
            return result;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a String : ");
            string str = Console.ReadLine();
            Console.Write("Enter a find character : ");
            char char1 = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter a replace character : ");
            char char2 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(Substitute(str, char1, char2));            
        }
    }
}
