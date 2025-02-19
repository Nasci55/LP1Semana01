using System;
using System.Text;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
            double xx = 1.23456;
            int ii = 19;

            Console.OutputEncoding = Encoding.UTF8;

            //New String variables
            string messageToWorld = "Hello world! \u2735";
            string soHappy = "I love this \n It isn't lovely \rIt is so ";
            string pointer = "\u27A0 \t \uFD3Elp1\uFD3F";


            Console.WriteLine(messageToWorld);
            Console.WriteLine(soHappy);
            Console.WriteLine(pointer);

            //New concatenation variables

            string name = "Goncalo";
            string welcome = "Hello";

            Console.WriteLine(welcome + " " + name);
            Console.WriteLine($"{welcome} {name}, how are you?");



            //Changing the format of double and int variables

            Console.WriteLine($"{xx:f2}");
            Console.WriteLine($"{xx:p1}");
            Console.WriteLine($"0x{ii:x}");
            Console.WriteLine($"{ii:c}");
        }
    }
}
