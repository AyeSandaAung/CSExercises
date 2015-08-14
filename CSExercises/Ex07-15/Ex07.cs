using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    public class Ex07
    {
        public static void Main(string[] args)
        {          
            Console.WriteLine("Please enter your salary : ");
            double salary = Convert.ToDouble(Console.ReadLine());

            double housingAllowance = salary * 0.1; //10%
           // Console.WriteLine("hallow   :   "+housingAllowance );

            double transportAllowance = salary * 0.03;  //3%
           // Console.WriteLine("transAllow   :  "+ transportAllowance);

            Console.WriteLine("The total income is : {0:c}", salary+housingAllowance+transportAllowance);

        }
    }
}
