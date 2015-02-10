using System;
                /*Problem 10. Odd and Even Product
                
                    You are given n integers (given in a single line, separated by a space).
                    Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
                    Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
                
                                Examples:
                                numbers 	        result
                                2 1 1 6 3 	        yes
                                product = 6 	    
                                	
                                3 10 4 6 5 1 	    yes
                                product = 60 	    
                                	
                                4 3 2 5 2 	        no
                                odd_product = 16 	
                                even_product = 15 	
                 */
class Program
{
    static void Main()
    {
        Console.WriteLine("Now enter your numbers below!");
        Console.WriteLine("But first, how many number you want to enter?");
        Console.Write("Answer: ");
        int userAnswer = int.Parse(Console.ReadLine());

        int[] userValues = new int[userAnswer];
        int count = 1;
        int oddNumbers = 1;
        int evenNumbers = 1;

        for (int i = 0; i < userAnswer; i++)
        {
            Console.Write("Number {0} = ", count);
            userValues[i] = int.Parse(Console.ReadLine());
            count++;
        }
        for (int i = 0; i < userValues.Length; i++)
        {
            if (userValues[i] % 2 == 0)
            {
                evenNumbers += userValues[i];
            }
            else 
            {
                oddNumbers += userValues[i];
            }
        }

        bool check = evenNumbers == oddNumbers;
        Console.WriteLine("Product of odd numbers: {0} \nProduct of even numbers: {1}", oddNumbers, evenNumbers);
        Console.WriteLine("Are they equal: {0}", check);
        //I miss something here so please help after you check it. I don't have much time to lose on the tasks.
    }
}

