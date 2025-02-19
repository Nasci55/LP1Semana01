using System;
using System.Runtime.InteropServices;

namespace AskForInput
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Please insert an integer number: ");
            string userInput = Console.ReadLine();

            int userInputInt = Convert.ToInt16(userInput);
            
            
            Console.WriteLine("Please insert a real number: ");
            string secondUserInput = Console.ReadLine();

            float secondUserInputFloat = Convert.ToSingle(secondUserInput);


        }
    }
}
