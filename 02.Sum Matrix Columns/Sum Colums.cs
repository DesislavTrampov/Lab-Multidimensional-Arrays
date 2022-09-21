            int cols = int.Parse(input[1]);
            int[,] matrix = new int[rows, cols];

            for( int row =0; row < rows; row++)
            for (int row = 0; row < rows; row++)
            {
                string[] rowData = Console.ReadLine().Split(" ");
                string[] rowData = Console.ReadLine().Split(", ");

                for(int col = 0; col<cols; col++)
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = int.Parse(rowData[col]);
                }
            }
            
            int sum = 0;

            for (int col = 0; col < matrix.GetLength(1); col++)
            for (int row = 0; row < rows; row++)
            {
                int sum = 0;

                for (int row = 0; row< matrix.GetLength(0); row++)

                for (int col = 0; col < cols; col++)
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
                    //Console.Write($"{matrix[row,col]} ");
                }
                Console.WriteLine($" = {sum}");

                Console.WriteLine();
            }
            
            Console.WriteLine($"{matrix.GetLength(0)}");
            Console.WriteLine($"{matrix.GetLength(1)}");

         