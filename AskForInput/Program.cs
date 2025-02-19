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

            float userInputInt = int.Parse(userInput);     
            
            
            Console.WriteLine("Please insert a real number: ");
            string secondUserInput = Console.ReadLine();

            float secondUserInputFloat = float.Parse(secondUserInput);

            Console.WriteLine($"{userInputInt + secondUserInputFloat}");


        }
    }
}
