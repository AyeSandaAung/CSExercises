using System;

namespace CSExercises
{
    public class Ex43
    {
        //public static string Hex(int i)
        //{
        //    string result;            
        //    decimal modulus = i % 16;
        //    if (i - modulus == 0)
        //    {
        //        result = Convert.ToString(ToChar(i));
        //        return result;
        //    }
        //    else
        //    {
        //        result = ((i - modulus) / 16)%16 + Convert.ToString(ToChar(i));
        //    }

        //    return result;
        //}
        //public static char ToChar(int j)
        //{
        //    char[] tochar = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };                      
        //    return tochar[j];
        //}

        //public static void Main(string[] args)
        //{
        //    //for (int i = 1; i < 100; i++)
        //    //{
        //    //    int myInt = i;
        //    //    string myHex = myInt.ToString("X");  // gives you hex
        //    //    //int myNewInt = Convert.ToInt32(myHex, 16);  // back to int again.
        //    //    Console.WriteLine(myHex+"\t");
        //    //}

        //    for (int i = 1; i < 100; i++)
        //    {
        //        string hexaDecimal = Hex(i);
        //        Console.Write(hexaDecimal+"\t");
        //    }
        //}

        public static string Hex(int i)
        {
            string result;
            int modResult = i % 16;            

            int divResult = (i / 16)%16;

            if (divResult == 0)
            {
                result = Convert.ToString(modResult);   //1,2,3,4,5,6,7,8,9, 
                switch (result)
                {
                    case "10": result = "A"; break;
                    case "11": result = "B"; break;
                    case "12": result = "C"; break;
                    case "13": result = "D"; break;
                    case "14": result = "E"; break;
                    case "15": result = "F"; break;
                }
                
            }
            else
            {
                switch(modResult)
                {
                    case 10: result = divResult + "A"; break;
                    case 11: result = divResult + "B"; break;
                    case 12: result = divResult + "C"; break;
                    case 13: result = divResult + "D"; break;
                    case 14: result = divResult + "E"; break;
                    case 15: result = divResult + "F"; break;
                    default: result = divResult + "" + modResult; break;
                }
                
            }  
            return result;
        }      
        public static void Main(string[] args)
        {
            //for (int i = 1; i < 100; i++)
            //{
            //    int myInt = i;
            //    string myHex = myInt.ToString("X");  // gives you hex
            //    //int myNewInt = Convert.ToInt32(myHex, 16);  // back to int again.
            //    Console.WriteLine(myHex + "\t");
            //}

            for (int i = 1; i < 100; i++)
            {
                string hexaDecimal = Hex(i);
                Console.WriteLine(hexaDecimal + "\t");
            }
        }
    }
}
