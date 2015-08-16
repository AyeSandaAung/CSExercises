using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex11
    {
        public static void Main(string[] args)
        {
            Console.Write("Please enter the distance travel km : ");
            double x = Convert.ToDouble(Console.ReadLine());
            double totalFare;
            double additionFare;

            if (x > 2.40)
            {
                additionFare = Math.Abs(x - 2.40) * 0.4;
                totalFare = 2.40 + (x * additionFare);
            }
            else
                totalFare = 2.40 + x;

                Console.WriteLine("The total fare is : {0}", totalFare);
        }
    }
}
