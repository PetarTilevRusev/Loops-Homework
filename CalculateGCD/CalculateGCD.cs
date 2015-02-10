using System;
                /*Problem 17.* Calculate GCD
                
                    Write a program that calculates the greatest common divisor (GCD) of given two integers a and b.
                    Use the Euclidean algorithm (find it in Internet).
                
                        Examples:
                        a 	    b 	    GCD(a, b)
                        3 	    2 	    1
                        60 	    40 	    20
                        5 	    -15 	5
                */
class CalculateGCD
{
    static void Main()
    {
        Console.Write("a = ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b = ");
        int b = int.Parse(Console.ReadLine());
        int remainder;
        int multiplier;

        while (true)
        {
            multiplier = a / b;
            remainder = a - (b * multiplier);

            if (remainder == 0)
            {
                break;
            }

            a = b;
            b = remainder;
        }

        Console.WriteLine("GCD of a and b is: {0}", b);
        //Euclidean algorithm: https://www.youtube.com/watch?v=OLW4RZIA1KI (who doesent love vido explanations :))
    }
}

