using System;
                /*Problem 11. Random Numbers in Given Range
                
                    Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].
                
                Examples:
                n 	min 	max 	random numbers
                5 	0 	    1 	    1 0 0 1 1
                10 	10 	    15 	    12 14 12 15 10 12 14 13 13 11
                
                Note: The above output is just an example. Due to randomness, your program most probably will produce different results.*/
class RandomNumbersInGivenRange
{
    static void Main()
    {
        Console.Write("Max value: ");
        int max = int.Parse(Console.ReadLine());
        Console.Write("Min value: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("How much numbers you want to be shown: ");
        int numbers = int.Parse(Console.ReadLine());

        Random random = new Random();

        for (int i = 0; i < numbers; i++)
        {
            Console.Write("{0} ", random.Next(min, max));
        }
        Console.WriteLine();
    }
}

