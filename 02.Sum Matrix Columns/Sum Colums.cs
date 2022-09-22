using System;
using System.Collections.Generic;
using System.Linq;

namespace exsercises
{
    internal class Program
    {
         static void Main(string[] args)
         {
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            int rows = int.Parse(input[0]);
            int cols = int.Parse(input[1]);
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
                {
                    string[] rowData = Console.ReadLine().Split(" ");
                    
                        for (int col = 0; col < cols; col++)
                        {
                            matrix[row, col] = int.Parse(rowData[col]);
                        }

                }


            Console.WriteLine();
            
                for (int col = 0; col < cols; col++)
                {
                    int sum = 0;

                        for (int row = 0; row < rows; row++)
                        {
                            sum += matrix[row, col];
                            if (row == matrix.GetLength(0) - 1)
                            {
                                Console.Write($"{matrix[row, col]}");
                            }
                            else
                            {
                                Console.Write($"{matrix[row, col]} + ");

                            }
                         
                        }
                    Console.WriteLine($" = {sum}");

                    Console.WriteLine();
                }

            









        }
    }
}
        