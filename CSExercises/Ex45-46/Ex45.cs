using System;

namespace CSExercises
{
    public class Ex45
    {
        //public static void Main(string[] args)
        //{
        //    double amount = 0;
        //    string[] amtArray= new string[2];
            
        //    do
        //    {
        //        Console.WriteLine("Pls Enter an Amount between 5cents(0.5) and 3dollar 50cents(3.50) : ");
        //        string amount1 = Console.ReadLine();
              
        //        amount = Convert.ToDouble(amount1);
        //        if (amount < 3.50)
        //        {
        //            amtArray = amount1.ToString().Split('.');
        //        }
                
        //    } while (amount > 3.50);           

        //    if(amount >= 1)
        //    {                
        //        for (int i = 0; i < Convert.ToInt32(amtArray[0]); i++)
        //        {
        //            Console.WriteLine("100c");
        //        }                
        //    }

        //    amount = Convert.ToDouble(amtArray[1]);
        //    if (amount == 05)
        //    {
        //        Console.WriteLine("5c");
        //    }
        //    for (int i = 0; i < amount; i++)
        //    {
        //        if(amount >= 50 )
        //        {
        //            Console.WriteLine("50c");                        
        //            amount = amount - 50;                    
        //        }
        //        else if (amount >= 20)
        //        {
        //            Console.WriteLine("20c");
        //            amount = amount - 20;
        //        }
        //        else if (amount >= 10)
        //        {                    
        //            Console.WriteLine("10c");
        //            amount = amount - 10;                   
        //        }
        //        else if (amount >= 5)
        //        {
        //            Console.WriteLine("5c");
        //            amount = amount - 5;                   
        //        }
        //    }            
        //}

        public static void Main(string[] args)
        {
            double amount = 0;
           
            do
            {
                Console.WriteLine("Pls Enter an Amount between 5cents(0.5) and 3dollar 50cents(3.50) : ");
                amount = Convert.ToDouble(Console.ReadLine());
                
            } while (amount > 3.50);

            amount = amount * 100;
            for (int i = 0; i < amount; i++)
            {

                if (amount >= 100)
                {
                    Console.WriteLine("100c");
                    amount = amount - 100;
                }
                else if (amount >= 50)
                {
                    Console.WriteLine("50c");
                    amount = amount - 50;
                }
                else if (amount >= 20)
                {
                    Console.WriteLine("20c");
                    amount = amount - 20;
                }
                else if (amount >= 10)
                {
                    Console.WriteLine("10c");
                    amount = amount - 10;
                }
                else if (amount >= 5)
                {
                    Console.WriteLine("5c");
                    amount = amount - 5;
                }
            }
        }
    }
}
