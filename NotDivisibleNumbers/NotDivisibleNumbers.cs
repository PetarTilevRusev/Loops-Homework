using System;
/*Problem 2. Numbers Not Divisible by 3 and 7

    Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n not divisible by 3 and 7, on a single line, separated by a space.

            Examples:
            n 	output
            3 	1 2
            10 	1 2 4 5 8 10*/
class NotDivisibleNumbers
{
    static void Main()
    {
        Console.Write("Please enter your number: ");
        string userImput = Console.ReadLine();
        int userNumber;

        if (int.TryParse(userImput, out userNumber))
        {
            for (int i = 1; i <= userNumber; i++)
            {
                if (i % 3 == 0 || i % 7 == 0)
                {
                    continue;
                }
                else
                {
                    Console.Write(i + " ");
                }
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid number!");
        }
    }
}

