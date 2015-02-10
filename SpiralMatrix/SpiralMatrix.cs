using System;
                /*Problem 19.** Spiral Matrix
                
                    Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) 
                     and prints a matrix holding the numbers from 1 to n*n in the form of square spiral like in the examples below.
                
                        Examples:
                        
                        n = 2   matrix      n = 3   matrix      n = 4   matrix
                                1 2                 1 2 3               1  2  3  4
                                4 3                 8 9 4               12 13 14 5
                                                    7 6 5               11 16 15 6
                                                                        10 9  8  7
                        
                 */
class SpiralMatrix
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];

        FillMatrix(matrix, n);

        PrintMatrix(matrix, n);

    }
    private static void FillMatrix(int[,] matrix, int n)
    {
        int positionX = n / 2; //The starting position of our matrix
        int positionY = n % 2 == 0 ? (n / 2) - 1 : (n / 2);

        int direction = 0;    //The direction is right
        int stepsCount = 1;   //Perform 1 step in current direction
        int stepPosition = 0; //Number of steps performed
        int stepChange = 0;   //Steps count changes after 2 steps 

        for (int i = n * n; i >= 1; i--)
        {
            // Fill the current cell with the current value 
            matrix[positionX, positionY] = i;

            if (stepPosition < stepsCount) 
            { 
                stepPosition++; 
            } 
            else 
            { 
                stepPosition = 1; 
                if (stepChange == 1) 
                { 
                    stepsCount++; 
                } 

                stepChange = (stepChange + 1) % 2; 
                direction = (direction + 1) % 4; 
            } 

            switch (direction) 
            { 
                case 0:    
                    positionY++; 
                    break; 
                case 1:    
                    positionX--; 
                    break; 
                case 2:    
                    positionY--; 
                    break; 
                case 3:    
                    positionX++; 
                    break; 
            }
        }
    }
    private static void PrintMatrix(int[,] matrix, int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0,3}", matrix[i, j]);
            }
            Console.WriteLine();
        }
    }
    /* Help: Book: Fundamentals of Computer Programming with C#
     * Page 1071 - Chapter 26. Sample Programming Exam – Topic #3 */
}

