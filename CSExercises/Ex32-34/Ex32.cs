using System;

namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        {
            string[] salesmonths = new string[12] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            int count = 0;
            //double maxSales = 0, minSales = 0, totalAmount = 0;
            double totalAmount = 0;
            double[] saleAmount = new double[12];
            do
            {
                Console.Write("Enter sales for month {0} : ", salesmonths[count]);
                saleAmount[count] = Convert.ToInt32(Console.ReadLine());
                count++;

            } while (count != saleAmount.Length);

            //for (int i = 0; i < saleAmount.Length; i++)
            //{
            //    totalAmount += saleAmount[i];
            //    for (int j = 1; j < saleAmount.Length; j++)
            //        if (saleAmount[i] > saleAmount[j])
            //        {
            //            //maxSales = saleAmount[i];
            //            saleAmount[i] = saleAmount[i];
            //        }
            //        else if (saleAmount[i] < saleAmount[j])
            //        {
            //            //minSales = saleAmount[i];
            //            saleAmount[i] = saleAmount[i];
            //        }
            //}

            //for (int i = 0; i < saleAmount.Length-1; i++)
            //{
            //    totalAmount += saleAmount[i];
            //    for (int j = i+1; j < saleAmount.Length; j++)
            //        if (saleAmount[j] < saleAmount[i])
            //        {
            //            //swap
            //            double temp = saleAmount[j];
            //            saleAmount[j] = saleAmount[i];
            //            saleAmount[i] = temp;
            //        }
            //}
            //Console.WriteLine("Maximum Sales : {0}", saleAmount[11]);
            //Console.WriteLine("Minimum Sales : {0}", saleAmount[0]);

            //int i = 0, j = 0;
            //for (i = 0; i < saleAmount.Length - 1; i++)
            //{
            //    totalAmount += saleAmount[i];
            //    for (j = i + 1; j < saleAmount.Length; j++)
            //        if (saleAmount[j] < saleAmount[i])
            //        {
                        
            //        }                   
            //}

            //Console.WriteLine("Maximum Sales : {0}", i);
            //Console.WriteLine("Minimum Sales : {0}", j);
            Console.WriteLine("Average Sales : {0}", totalAmount / 12);
            
        }
    }
}
