using System;
using System.Numerics;
                /*Problem 7. Calculate N! / (K! * (N-K)!)
                
                    In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) 
                     is calculated by the following formula: "formula" For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
                       Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.
                
                            Examples:
                            n 	k 	n! / (k! * (n-k)!)
                            3 	2 	3
                            4 	2 	6
                            10 	6 	210
                            52 	5 	2598960
                 */
class CalculateNumberOfCombinations
{
    static void Main()
    {
        Console.WriteLine("WARNING: 1 < k < n < 100");

        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());

        int m = n - k;

        decimal nFactorial = 1;
        decimal kFactorial = 1;
        decimal nkFactorial = 1;
        //It's like the previous calculation in Problem 6. but with one variable more.
        if (1 < k && k < n && n < 100)
        {
            while (n > 0)
            {
                nFactorial *= n; 
                kFactorial *= k;

                if (k > 1)
                {
                    k--;
                }

                n--;
            }
            while (m > 0)
	        {
	            nkFactorial *= m;
                m--;
	        }

            decimal result = nFactorial / (kFactorial * nkFactorial);
            Console.WriteLine("n! / k! = {0}", result);
        }
        else
        {
            Console.WriteLine("Invalid n and k values!\nPlease try again!");
        }
    }
}

