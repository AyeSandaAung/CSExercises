using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex05
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter double number : ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The square root of the number is : {0:#.000}", Math.Sqrt(x));
        }
    }
}
