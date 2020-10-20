using System;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int matrixSize;
            Console.WriteLine("Sample Input (please enter a whole number as the size of a square matrix)");
            while (!int.TryParse(Console.ReadLine()?.Trim(), out matrixSize))
            {
                Console.WriteLine("Please enter a valid whole number");
            }

            int[,] matrix = new int[matrixSize, matrixSize];
            // input matrix values
            for (int i = 0; i < matrixSize; i++) // rows
            {
                for (int j = 0; j < matrixSize; j++) // columns
                {
                    int input;
                    Console.Write($"Enter value for matrix position ({i},{j}): ");
                    while (!int.TryParse(Console.ReadLine()?.Trim(), out input))
                    {
                        Console.Write($"Enter correct value for matrix position ({i},{j}): ");
                    }
                    matrix[i, j] = input;
                }
            }

            DisplayMatrix(matrixSize, matrix);

            CalculateAbsDiffAndDisplayIt(matrixSize, matrix);
        }


        private static void DisplayMatrix(int matrixSize, int[,] matrix)
        {
            Console.WriteLine();
            Console.WriteLine($"Your {matrixSize}X{matrixSize} square matrix");
            Console.WriteLine("--------------------");

            for (int i = 0; i < matrixSize; i++)
            {
                var result = "";
                for (int j = 0; j < matrixSize; j++)
                {
                    result += $"{matrix[i, j]} ";
                }

                Console.WriteLine(result);
            }
        }

        private static void CalculateAbsDiffAndDisplayIt(int matrixSize, int[,] matrix)
        {
            Console.WriteLine("Press 'ENTER' to calculate the Absolute difference between the sums of the matrix diagonals");
            Console.ReadLine();
            Console.WriteLine("Output (Absolute difference between the sums of the matrix diagonals)");

            int topLeftToBottomRightDiagonalSum = 0, topRightToBottomLeftDiagonalSum = 0, columnCount = 0;

            for (int rowCount = 0; rowCount < matrixSize; rowCount++)
            {
                topLeftToBottomRightDiagonalSum += matrix[rowCount, columnCount];
                topRightToBottomLeftDiagonalSum += matrix[rowCount, matrixSize - 1 - columnCount];
                columnCount++;
            }

            Console.WriteLine($"Top left to bottom right diagonal sum: {topLeftToBottomRightDiagonalSum}");
            Console.WriteLine($"Top right to bottom left diagonal sum: {topRightToBottomLeftDiagonalSum}");
            Console.WriteLine($"The sums' absolute difference: {Math.Abs(topLeftToBottomRightDiagonalSum - topRightToBottomLeftDiagonalSum)}");
        }
    }
}
