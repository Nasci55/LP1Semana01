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
            int age = 21;
            uint range =  4294967295U;
            long negative = -99999930192;
            ulong positive = 1999394850128492304; 


            char recycle = '\u267B';
            char infinite = '\u221E';
            char exclamation = '\u203C';
            
            
            Console.WriteLine("Hello LP1! \n" + age);
            Console.WriteLine(range);
            Console.WriteLine(negative);
            Console.WriteLine(positive);
            Console.WriteLine(recycle);
            Console.WriteLine(infinite);
            Console.WriteLine(exclamation);

        }
    }
}
