using System;
using System.Linq;
                /*Problem 3. Min, Max, Sum and Average of N Numbers
                                
                    Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
                    The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
                    The output is like in the examples below.
                                
                input 	output
                3       min = 1
                2       max = 5
                5       sum = 8
                1       avg = 2.67
                    
                Example 2:
                input 	output
                2       min = -1
                -1      max = 4
                4       sum = 3
                        avg = 1.50
                */
class MinMaxSumAverage
{
    static void Main()
    {
        double[] userNumbers = new double[4];
        int count = 0; // This value counts the number of array.
        Console.WriteLine("Please enter four numbers below!");
        for (int i = 1; i <= 4; i++)
        {
            Console.Write("Number {0}: ", i);
            userNumbers[count] = int.Parse(Console.ReadLine());
            count++; //Here I increase the array number to hold the next value
        }

        double max = userNumbers.Max(); // To take tha max and min value from array I use Sysyem.Linq
        double min = userNumbers.Min();
        double sum = userNumbers[0] + userNumbers[1] + userNumbers[2] + userNumbers[3]; //I assume that the examples given to os are wrong. Example 1: 3 + 2 + 5 + 1 != 8 and Example 2: 2 + (-1) + 4 != 3
        double average = sum / 4.00;
        Console.WriteLine("min = {0}\nmax = {1}\nsum = {2}\navg = {3}", userNumbers.Min(), userNumbers.Max(), sum, average);
    }
}
