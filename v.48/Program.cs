using System;
using System.Collections.Generic;

namespace v._48
{
    class Program
    {
        static bool Success;
        static void Main(string[] args)
        {
            List<double> accountHistory = new List<double>();
            bool keepGoing = true;

            Console.WriteLine("Welcome to National Security Bank");
            IsPinCorrect();
            do
            {
                int choice = Menu();
                switch(choice)
                {
                    case 1:
                        accountHistory.Add(Deposit());
                        break;
                    case 2:
                        accountHistory.Add(Withdraw());
                        break;

                    case 3:

                        Console.WriteLine(Balance(accountHistory)); 
                        break;

                        //case 4:
                        //    CollectInteresst();
                        //    break;

                }
              

            } while (keepGoing);


        }

        static double Withdraw()
        {
            Console.WriteLine("How much do you wanna withdraw");
            Success = double.TryParse(Console.ReadLine(), out double result);
            double sum = (0 - result);
            return sum;



        }

        static double Balance(List<double> accountHistory)
        {
            double balance = 0;
            foreach (double element in accountHistory)
            {
                balance += element;
            }
            return balance;
        }

        static double Deposit()
        {
            Console.WriteLine("How much do you wanna deposit?");
            Success = double.TryParse(Console.ReadLine(), out double result);
            return result;
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

        static void IsPinCorrect()
        {
            int invaildPin = 0;
            bool keepGoing = true;
            while (keepGoing)
            {
                
                Console.WriteLine("Enter yout pincode: ");
                string userAnswer = Console.ReadLine();

                bool success = Int32.TryParse(userAnswer, out int pin);

                if (success && userAnswer.Length == 4 || success && userAnswer.Length == 6)
                {
                    Console.WriteLine("Valid pin, Welcome human");
                    keepGoing = false;
                }
                else if (invaildPin == 2)
                {
                    Console.WriteLine("Your account is blocked. Entered wrong pin 3 times. Please contact your bank.");
                    keepGoing = false;
                }
                else if (success! || userAnswer.Length != 4 || userAnswer.Length != 6)
                { 
                    Console.WriteLine("Invalid pin");
                    invaildPin++;
                }





            }
        }
    }
}
