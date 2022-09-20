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

            for (int row = 0; row < rows; row++)
            {
                string[] rowData = Console.ReadLine().Split(", ");

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = int.Parse(rowData[col]);
                }
            }
            int sum = 0;

            for (int row = 0; row < rows; row++)
            {


                for (int col = 0; col < cols; col++)
                {
                    sum += matrix[row, col];
                    //Console.Write($"{matrix[row,col]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"{matrix.GetLength(0)}");
            Console.WriteLine($"{matrix.GetLength(1)}");

            Console.WriteLine(sum);








        }
    }
}
