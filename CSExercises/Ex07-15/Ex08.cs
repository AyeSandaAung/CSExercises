using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a temperature : ");
            int temperature = Convert.ToInt32(Console.ReadLine());

            // F=1.8C + 32;           

            Console.WriteLine("The Temperature in Fahrenheit is : {0}", (1.8 * temperature) + 32);
        }
    }
}
