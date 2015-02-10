using System;
                    /*Problem 1. Numbers from 1 to N
                    
                        Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space.
                    
                                Examples:
                                n 	output
                                3 	1 2 3
                                5 	1 2 3 4 5*/
class NumbersFromOneToN
{
    static void Main()
    {
        start:
        Console.Write("Your number: ");
        string userImput = Console.ReadLine();
        int userNumber;

        if (int.TryParse(userImput, out userNumber))
        {
            for (int i = 1; i <= userNumber; i++)
            {
                Console.Write(i + " ");
                
            }
        Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Please enter a valid number!");
            goto start; //I know this is a bad practice, but I want to try it!
        }
    }
}

