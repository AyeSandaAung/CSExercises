using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex03
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter double number : ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The square of the number is : {0}", Math.Pow(x,x));

        }
    }
}
