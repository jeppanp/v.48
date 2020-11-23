using System;
using System.Collections.Generic;

namespace v._48
{
    class Program
    {
        static bool Success; 
        static void Main(string[] args)
        {
            bool keepGoing = true;
            
            Console.WriteLine("Welcome to National Security Bank");
            Console.WriteLine("Enter yout pincode: ");
            string userAnswer = Console.ReadLine();
            while(keepGoing)
            IsPinCorrect(userAnswer);

            while(keepGoing)
            {
                Menu();

            }
        }

         static int Menu()
        {
            Console.WriteLine("What do you wanna do?");
            Console.WriteLine("1. Deposit money");
            Console.WriteLine("2. Whitdraw money");
            Console.WriteLine("3. Check Balance");
            Console.WriteLine("4. Collect intresst");
            Success = Int32.TryParse(Console.ReadLine(), out int choice);
            return choice;
        }

        static void IsPinCorrect(string a)
        {
           
                 bool sucess = Int32.TryParse(a, out int pin);
            
                if (sucess && a.Length == 4 || a.Length == 6)
                    Console.WriteLine("Valid pin, Welcome human");
                else
                    Console.WriteLine("Invalid pin");
            
        }
    }
}
