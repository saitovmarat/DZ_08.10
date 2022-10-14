using System;
using System.Collections.Generic;

namespace кр
{
    class Program
    {
        static void Task_6_1(char[] file)
        {
            List<char> soglasn = new List<char> { 'q', 'w', 'r', 't', 'p', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm' };
            List<char> glasn = new List<char> { 'e', 'y', 'u', 'i', 'o', 'a', };
            int cnt_glasn = 0;
            int cnt_soglasn = 0;
            for (int i = 0; i < file.Length; i++)
            {
                if (soglasn.Contains(file[i]))
                {
                    cnt_soglasn++;
                }
                else if (glasn.Contains(file[i]))
                {
                    cnt_glasn++;
                }
            }
            Console.WriteLine($"Количество гласных - { cnt_glasn}, количество согласных - {cnt_soglasn}");
        }
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
        static void SR_temp() //int[]
        {
            var dictionary = new Dictionary<string, int[]>();
            Random random = new Random();
            string[] months = new string[] { "Jan", "Feb", "Mar", "Apr", "May", "June", "July", "Aug", "Sep", "Oct", "Nov", "Dec" };
            for (int i = 0; i < months.Length; i++)
            {
                int[] temp = new int[30];
                for (int j = 0; j < 30; j++)
                {
                    temp[j] = random.Next(-30, 30);
                }
                dictionary.Add(months[i], temp);
            }
            foreach (var month in dictionary)
            {
                int sr_zn = 0;
                Console.WriteLine(month.Key);
                for (int i = 0; i < 30; i++)
                {
                    sr_zn += month.Value[i];
                    Console.Write($"{month.Value[i]}, ");
                }
                Console.WriteLine();
                Console.WriteLine($"Среднее значение температуры: {sr_zn}");
                Console.WriteLine();
            }
            /* Random random = new Random();
            int[] sr_temperature = new int[12];
            int[,] temperature = new int[12, 30];
            for (int i = 0; i < temperature.GetLength(0); i++)
            {
                int mas = 0;
                for (int j = 0; j < temperature.GetLength(1); j++)
                {
                    temperature[i, j] += random.Next(-30, 30);
                    mas += temperature[i, j];
                }
                sr_temperature[i] += mas / 30;
            }
            return sr_temperature;*/
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Task 6.1");
            char[] file = { 'a', 'v', 'v', 'q', 'y' };
            Task_6_1(file);


            Console.WriteLine("Task 6.2");
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
            Console.WriteLine("\nТретья матрица = первая матрица * вторая матрица:");
            int[,] third_matrix = Multiplication(first_matrix, second_matrix);
            Print(third_matrix);


            Console.WriteLine("Task 6.3");
            /*int[] sr_temp = SR_temp();
            Array.Sort(sr_temp);
            for (int i = 0; i < sr_temp.Length; i++)
            {
                Console.WriteLine(sr_temp[i]);
            }*/
            SR_temp();
        }
    }
}
