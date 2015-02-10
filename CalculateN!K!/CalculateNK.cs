using System;
                /*Problem 6. Calculate N! / K!
                
                    Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
                    Use only one loop.
                
                 Examples:
                 n  	k 	    n! / k!
                 5  	2 	    60
                 6  	5 	    6
                 8  	3 	    6720
               */
class CalculateNK
{
    static void Main()
    {
        Console.WriteLine("WARNING: 1 < k < n < 100 ");
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("k = ");
        int k = int.Parse(Console.ReadLine());

        decimal nFactorial = 1; //I create a nFactorial variable
        decimal kFactorial = 1; //I create a kFactorial variable
        if (1 < k && k < n && n < 100) //Here I check the n adn k values
        {
            while (n > 0)
            {
                nFactorial *= n; //Multiply the nFactorial with n in a loop, until n > 0;
                kFactorial *= k; //Same with kFactorial

                if (k > 1) //Here I make another check of k, if k reach 1, stop k--;. Because k is smaller then n and the value of k becomes negative.
                {
                    k--; 
                }
                
                n--;
            }

            decimal result = nFactorial / kFactorial; //Calculating the result!
            Console.WriteLine("n! / k! = {0}", result); //Printing
        }
        else
        {
            Console.WriteLine("Invalid n and k values!\nPlease try again!");
        }
    }
}

