using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace exsercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = numbers[0];
            int cols = numbers[1];

            int[,] matrix = new int[rows, cols];


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                string[] data = Console.ReadLine().Split(", ");
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = int.Parse(data[j]);
                }
            }
            int maxsum = 0;
            int matrixrow = 2;
            int matrixcol = 2;
            int startrow = 0;
            int startcol = 0;
            for (int i = 0; i < matrix.GetLength(0)-matrixrow+1; i++)
            {
                for(int j = 0; j <matrix.GetLength(1) - matrixcol+1; j++)
                {
                    int sum = 0;
                    //sum += matrix[i, j];
                    //sum += matrix[i + 1, j];
                    //sum += matrix[i , j+1];
                    //sum += matrix[i + 1, j+1];
                    for(int k=0; k< matrixrow; k++)
                    {
                        for(int l=0; l< matrixcol; l++)
                        {
                            sum += matrix[i+l,k+j];
                        }
                    }
                    if (sum> maxsum)
                    {
                        startrow = i;
                        startcol = j;
                        maxsum = sum;
                    }

                }


                //Console.WriteLine();
            }
            for (int k = 0; k < matrixrow; k++)
            {
                for (int l = 0; l < matrixcol; l++)
                {
                    Console.Write($"{matrix[startrow+k,startcol+l]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(maxsum);
        }
    }
}
