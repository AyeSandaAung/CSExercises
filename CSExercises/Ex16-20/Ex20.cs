using System;

namespace CSExercises
{
    public class Ex20
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Product\tPrice");
            Console.WriteLine("TV\t$900");
            Console.WriteLine("DVD\t$500");
            Console.WriteLine("MP3\t$700");

            Console.WriteLine("Enter quantity for TV : ");
            double tv = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter quantity for DVD : ");
            double dvd = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter quantity for MP3 : ");
            double mp3 = Convert.ToDouble(Console.ReadLine());
            double amount = (tv * 900) + (dvd * 500) + (mp3 * 700);
            double discountAmount = 0;
            if (amount > 5000 && amount < 10000)
            {
                discountAmount = ((tv * 900) + (dvd * 500)) * 0.9;
            }
            else if (amount > 10000)
            {
                discountAmount = ((tv * 900) + (dvd * 500)) * 0.85;
            }
            else if (amount < 5000)
            {
                discountAmount = (tv * 900) + (dvd * 500);
            }

            Console.WriteLine("Total Price for this order is : {0}", discountAmount + (mp3 * 700));
        }
    }
}