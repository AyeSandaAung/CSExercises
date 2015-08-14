using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex02
    {
        public static void Main(string[] args)
        {
            Console.Write("Please Enter an interger : ");
            int number = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("The square of the number is : {0}", number * number);

        }
    }
}
