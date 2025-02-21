using System;
using System.Security;
using System.Text;
using System.Globalization;

namespace Smiley
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string userInput; 
            
            userInput = Console.ReadLine();

            int Hexadecimal = System.Int32.Parse(userInput, NumberStyles.AllowHexSpecifier);


            System.Console.WriteLine( System.Char.ConvertFromUtf32(Hexadecimal)); 

           
            
            

            
            
        }
    }
}
