using System;
using System.Collections;
using System.Collections.Generic;


namespace Черновик1
{
    class Program
    {
        static void Print(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write("{0} ", a[i, j]);
                }
                Console.WriteLine();
            }
        }
        static int[,] Multiplication(int[,] a, int[,] b)
        {
            if (a.GetLength(1) != b.GetLength(0))
            {
                throw new Exception("Матрицы нельзя перемножить");
            }
            int[,] r = new int[a.GetLength(0), b.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    for (int k = 0; k < b.GetLength(0); k++)
                    {
                        r[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            return r;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность первой матрицы: ");
            int[,] first_matrix = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < first_matrix.GetLength(0); i++)
            {
                for (int j = 0; j < first_matrix.GetLength(1); j++)
                {
                    Console.Write("first_matrix[{0},{1}] = ", i, j);
                    first_matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Введите размерность второй матрицы: ");
            int[,] second_matrix = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < second_matrix.GetLength(0); i++)
            {
                for (int j = 0; j < second_matrix.GetLength(1); j++)
                {
                    Console.Write("second_matrix[{0},{1}] = ", i, j);
                    second_matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("\nПервая матрица:");
            Print(first_matrix);
            Console.WriteLine("\nВторая матрица:");
            Print(second_matrix);
            Console.WriteLine("\nТретья матрица  = первая матрица * вторая матрица:");
            int[,] third_matrix = Multiplication(first_matrix, second_matrix);
            Print(third_matrix);
        }
    }
}
