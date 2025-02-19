using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace VariousTypes
{



    public class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //INT variables
            int age = 21;
            uint range =  4294967295U;
            long negative = -99999930192;
            ulong positive = 1999394850128492304; 

            //Chars variables
            char recycle = '\u267B';
            char infinite = '\u221E';
            char exclamation = '\u203C';
            
            //Real Variables
            double pi = 3.14159265359;
            float shortPi = 3.1415f;
            decimal  exactPi = 3.141592m;   


            
            Console.WriteLine("Hello LP1! \n" + age);
            Console.WriteLine(range);
            Console.WriteLine(negative);
            Console.WriteLine(positive);
            Console.WriteLine(recycle);
            Console.WriteLine(infinite);
            Console.WriteLine(exclamation);
            Console.WriteLine(pi);
            Console.WriteLine(shortPi);
            Console.WriteLine(exactPi);

        }
    }
}
