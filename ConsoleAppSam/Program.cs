using System;

namespace ConsoleAppSam
{
    class Program
    {
        static void Main(string[] args)
        {
            bool looping = true;

            while (looping)
            {
                Console.Clear();
                Console.WriteLine("--- Menu ---");
                Console.WriteLine("1: Miles to Kilomiters");
                Console.WriteLine("2: Kilomiters to Miles");
                Console.WriteLine("0: Exit");

                char selectoin = Console.ReadKey(true).KeyChar;

                switch (selectoin)
                {
                    case '1':
                        double userMiles = AskUserForNumber("Miles");
                        Console.WriteLine($"{userMiles} Miles is {ConvertMilesToKilometersPerHour(userMiles)} Kilomiters");
                        break;

                    case '2':
                        double userKilometers = AskUserForNumber("Kilometers");
                        Console.WriteLine(userKilometers + " Kilometers is " + ConvertKilometersToMilesPerHour(userKilometers) + " Miles");
                        break;

                    case '0'://Exit
                        looping = false;
                        break;

                    default:
                        Console.WriteLine("Invalid selection.");
                        break;
                }

                Console.WriteLine("Press any key to continue.");
                Console.ReadKey(true);
            }//end of while loop

            

        }//end of main

        static double AskUserForNumber(string what)
        {
            double number = 0;

            Console.Write("Please enter " + what + ": ");
            string userInput = Console.ReadLine();

            double.TryParse(userInput, out number);

            return number;
        }

        static double ConvertMilesToKilometersPerHour(double miles)
        {
            double result = miles * 1.609344;
            return result;
        }

        static double ConvertKilometersToMilesPerHour(double kilometers)
        {
            double result = kilometers / 1.609344;
            return result;
        }

        static void PrintStarWarsQuote()
        {
            Console.WriteLine("I am your father");
        }

    }//end of program
}
