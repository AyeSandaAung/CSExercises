using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please Enter x1 value : ");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Enter y1 value : ");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Enter x2 value : ");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please Enter y2 value : ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            //Distance = square root of [(x2-x1)*(x2-x1) + (y2-y1)*(y2-y1)];
            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            Console.WriteLine("SquareRoot of the Distance is {0:0.000}",distance);
        }
    }
}
