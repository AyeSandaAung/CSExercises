using System;

namespace CSExercises
{
    public class Ex26
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("NO\t\tINVERSE\t\tSQUARE ROOT\t\tSQUARE");
            for (double i = 1; i < 11; i++)
            {
               // Console.WriteLine(i+"\t\t"+(1/i).ToString("N3")+"\t\t"+Math.Sqrt(i)+"\t\t"+Math.Pow(i,2));
                Console.WriteLine("{0:0}\t\t{1:0.0##}\t\t{2:0.0##}\t\t\t{3:0.0}",i,1/i,Math.Sqrt(i),Math.Pow(i,2));
            }
        }
    }
}
