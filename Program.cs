using System;
using System.Collections.Generic;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of rows: ");
            int numRows;
            while (!int.TryParse(Console.ReadLine(), out numRows) || numRows < 0)
            {
                Console.WriteLine("Invalid input. Please enter a non-negative integer.");
                Console.Write("Enter the number of rows: ");
            }

            if (numRows == 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                List<List<int>> triangle = new List<List<int>>();

                // Initialize the first two rows of the triangle
                triangle.Add(new List<int>() { 1 });
                triangle.Add(new List<int>() { 1, 1 });

                for (int i = 2; i <= numRows; i++)
                {
                    List<int> row = new List<int>();
                    row.Add(1);

                    // Calculate the values of the current row
                    for (int j = 1; j < i; j++)
                    {
                        row.Add(triangle[i - 1][j - 1] + triangle[i - 1][j]);
                    }

                    row.Add(1);
                    triangle.Add(row);
                }

                // Print the triangle
                foreach (List<int> row in triangle)
                {
                    foreach (int value in row)
                    {
                        Console.Write(value + " ");
                    }
                    Console.WriteLine();
                }
            }

            Console.ReadLine();
        }
    }
}
