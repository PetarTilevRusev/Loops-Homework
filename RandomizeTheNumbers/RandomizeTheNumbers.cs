using System;
                /*Problem 12.* Randomize the Numbers 1…N
                
                    Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.
                
                Examples:
                n 	randomized numbers 1…n
                3 	2 1 3
                10 	3 4 8 2 6 7 9 1 10 5
                
                Note: The above output is just an example. Due to randomness, your program most probably will produce different results. You might need to use arrays.*/
class RandomizeTheNumbers
{
    static void Main()
    {
        Console.Write("Your number: ");
        int userNumber = int.Parse(Console.ReadLine());

        Random random = new Random(); //Random variable to shiffle the numbers
        int[] numbers = new int[userNumber]; //Array to hold the values
        int count = 1; 

        for (int i = 0; i < userNumber; i++)
        {
            numbers[i] = count; //Here I asign number [0] = 1, number [1] = 2 ... number[n] = userNumber
            int position = random.Next(userNumber); //Generate random number
            Console.WriteLine(numbers[position]); //Printing
            count++;

            //I can't figure out how to print the numbers, without repeating them!
        }
    }
}

