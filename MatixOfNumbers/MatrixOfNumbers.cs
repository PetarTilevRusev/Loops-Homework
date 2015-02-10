using System;
                /*Problem 9. Matrix of Numbers
                
                    Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops.
                
                Examples:
                
                n = 2   matrix      n = 3   matrix      n = 4   matrix
                        1 2                 1 2 3               1 2 3 4
                        2 3                 2 3 4               2 3 4 5
                                            3 4 5               3 4 5 6
                                                                4 5 6 7
                */
class MatrixOfNumbers
{
    static void Main()
    {
        Console.WriteLine("WARNING: 1 <= \"your number\" <= 20");
        Console.WriteLine("Let's make a matrix, shall we!");
        Console.Write("Enter a number (if you dare): ");
        int userNumber = int.Parse(Console.ReadLine());
        int bonusValue = 0; //I create a value to add +1 digit to every number in row 

        if(1 <= userNumber && userNumber <= 20)
        {
            for (int row = 0; row < userNumber; row++) //This loop is for the rows of the matrix
            {
                for (int col = 1; col <= userNumber; col++) //This loop is for the columns of the matrix
                {
                    Console.Write(col + bonusValue + " "); //Printing the numbers from 1 to userNumber on the same row using: (Console.Write())
                }

                Console.WriteLine(); //Adding new row after the col loop is over
                bonusValue++; 
            }
        }
        else
        {
            Console.WriteLine("I warned you right??? \nYou piece of shit!"); //Don't mind me, just messing around a bit.
        }
    }
}

