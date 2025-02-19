using System;
using System.Text;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;


            string messageToWorld = "Hello world! \u2735";
            string soHappy = "I love this \n It isn't lovely \rIt is so ";
            string pointer = "\u27A0 \t \uFD3Elp1\uFD3F";


            Console.WriteLine(messageToWorld);
            Console.WriteLine(soHappy);
            Console.WriteLine(pointer);

           
        }
    }
}
