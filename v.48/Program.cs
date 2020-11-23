using System;
using System.Collections.Generic;

namespace v._48
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;
            
            Console.WriteLine("Welcome to National Security Bank");
            Console.WriteLine("Enter yout pincode: ");
            string userAnswer = Console.ReadLine();
            while(keepGoing)
            IsPinCorrect(userAnswer);





          
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
