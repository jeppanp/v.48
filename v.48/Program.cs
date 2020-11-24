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
            double CurrentResult=0;
            

            Console.WriteLine("Welcome to National Security Bank");
            IsPinCorrect();
            do
            {
                int choice = Menu();
                switch (choice)
                {
                    case 1:
                        accountHistory.Add(Deposit());
                        break;
                    case 2:
                        accountHistory.Add(Withdraw());
                        Console.WriteLine("Current balance is {0} ", Balance(accountHistory));
                        
                        break;

                    case 3:
                        Console.WriteLine("Current balance is {0} ", Balance(accountHistory));
                        break;

                    case 4:

                        CurrentResult = Balance(accountHistory);
                        double intresst =CollectIntresst(CurrentResult);
                        accountHistory.Clear();
                        accountHistory.Add(intresst);
                        Console.WriteLine(intresst);
                        break;

                    case 5:
                        Console.WriteLine("bye");
                        keepGoing = false;
                        break;
                }


            } while (keepGoing);


        }

         static double CollectIntresst(double accountHistory)
        {
           

            Console.WriteLine("How many years do you wanna skip?");
            Success = int.TryParse(Console.ReadLine(), out int years);

            for (int i = 0; i < years; i++)
            {
                if (accountHistory <= 1000)
                {
                    accountHistory += accountHistory;
                }
                else if (accountHistory >= 1001 && accountHistory <= 5000)
                {
                    accountHistory *= 3;
                }

                else if (accountHistory >= 5001 && accountHistory <= 10000)
                {
                    accountHistory *= 4;
                }

                else if (accountHistory >= 10001)
                {
                    accountHistory *= 5;
                }

            }
            return accountHistory;
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
            Console.WriteLine("5. End");
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
