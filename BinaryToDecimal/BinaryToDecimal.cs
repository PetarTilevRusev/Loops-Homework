using System;
                /*Problem 13. Binary to Decimal Number
                
                    Using loops write a program that converts a binary integer number to its decimal form.
                    The input is entered as string. The output should be a variable of type long.
                    Do not use the built-in .NET functionality.
                
                                Examples:
                                binary 	decimal
                                0 	0
                                11 	3
                                1010101010101011 	43691
                                1110000110000101100101000000 	236476736
                */
class BinaryToDecimal
{
    static void Main()
    {
        Console.Write("Enter a binary integer number: ");
        string userBinary = Console.ReadLine();
        long result = 0;

        for (int i = 0; i < userBinary.Length; i++)
        {
            if (userBinary[userBinary.Length - i - 1] == '0')
            {
                continue;
            }
            result += (long)Math.Pow(2, i);
        }
        Console.WriteLine(result);
    }
}

