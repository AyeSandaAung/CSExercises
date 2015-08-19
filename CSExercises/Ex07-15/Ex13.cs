using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex13
    {
        public static void Main(string[] args)
        {

            Console.Write("Please enter the distance travel km : ");
            double x = Convert.ToDouble(Console.ReadLine());
            double totalFare = 2.40 + x * 0.4;
            Console.WriteLine("The total fare is : {0:0.00}", Math.Ceiling(totalFare));
        }
    }
}
