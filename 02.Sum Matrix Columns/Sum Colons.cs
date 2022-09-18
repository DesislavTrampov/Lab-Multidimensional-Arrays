using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

namespace programs
{
    internal class Program
    {


        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(", ");

            int rows = int.Parse(input[0]);
            int cols = int.Parse(input[1]);
            int[,] matrix = new int[rows, cols];

            for( int row =0; row < rows; row++)
            {
                string[] rowData = Console.ReadLine().Split(" ");

                for(int col = 0; col<cols; col++)
                {
                    matrix[row, col] = int.Parse(rowData[col]);
                }
            }
            

            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int sum = 0;

                for (int row = 0; row< matrix.GetLength(0); row++)
                {
                    sum += matrix[row, col];
                    if(row == matrix.GetLength(0)-1)
                    {
                        Console.Write($"{matrix[row, col]}");
                    }
                    else
                    {
                        Console.Write($"{matrix[row, col]} + ");

                    }
                }
                Console.WriteLine($" = {sum}");

            }
            




        }
    }
}
