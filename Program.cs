using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace dz1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер из дз:");
            int task=int.Parse(Console.ReadLine());
            switch (task)
            {
                case 1:
                    task1();
                    break;
                case 2:
                    task2();
                    break;
                case 3:
                    task3();
                    break;
                case 4:
                    task4();
                    break;
                case 5:
                    task5();
                    break;
                case 6:
                    task6();
                    break;


            }
        }
        static void task1()
        {
            int[] a = new int[5];
            float[,] b = new float[3, 4];
            Random random = new Random();
            Console.WriteLine("одномерный массив:");
            for (int i = 0; i < 5; i++)
            {
                string s = Console.ReadLine();
                int num = int.Parse(s);
                a[i] = num;
            }
            Console.WriteLine(string.Join(",", a));
            Console.WriteLine("двумерный массив:");
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; i < 3; i++)
                {
                    b[i, j] = random.Next(1, 10);
                }
            }
            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine(b[i, j] + " ");

                }
                Console.WriteLine();
            }
        }
        static void task2()
        {
            
            Random random = new Random();
            int[,] array = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; i < 5; i++)
                {
                    array[i, j] = random.Next(-100, 100);

                }
            }
            int min = array[0,0];
            int max=0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (min > array[i, j])
                    {
                        array[i, j] = min;
                    }
                    if (max < array[i, j])
                    {
                        array[i, j] = max;
                    }
                    Console.WriteLine(array[i, j] + ",");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Min:");
            Console.WriteLine(string.Join(", ", min));
            Console.WriteLine("Max:");
            Console.WriteLine(string.Join(", ", max));
            
        }
        static void task3()
        {
            Random random = new Random();
            int[,] array = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; i < 5; i++)
                {
                    array[i, j] = random.Next(5, 10);

                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine(array[i, j] + ",");
                }
                Console.WriteLine();
            }
            Console.WriteLine("умножение на число:");
            Console.WriteLine("введите число:");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for(int i = 0; i < 5 ; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    array[i, j] *= num;
                    Console.WriteLine(string.Join(",",array[i, j]));
                }
                Console.WriteLine();
            }
        }
        static int[,] MultiplyMatrixByNumber(int[,] matrix, int number)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix[i, j] * number;
                }
            }
            return result;
        }
        static int[,] AddMatrices(int[,] matrix1, int[,] matrix2)
        {
            int rows = matrix1.GetLength(0);
            int cols = matrix1.GetLength(1);

            int[,] result = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            return result;
        }
        static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
        {
            int rows1 = matrix1.GetLength(0);
            int cols1 = matrix1.GetLength(1);
            int cols2 = matrix2.GetLength(1);

            int[,] result = new int[rows1, cols2];

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    int sum = 0;
                    for (int k = 0; k < cols1; k++)
                    {
                        sum += matrix1[i, k] * matrix2[k, j];
                    }
                    result[i, j] = sum;
                }
            }

            return result;
        }
        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void task4()
        {
            int[,] matrix1 = { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] matrix2 = { { 7, 8, 9 }, { 10, 11, 12 } };
            Console.WriteLine("\nумножение первой матрицы на 3:");
            int[,] result1 = MultiplyMatrixByNumber(matrix1, 3);
            PrintMatrix(result1);

            Console.WriteLine("\nMatrix 1 + Matrix 2:");
            int[,] result2 = AddMatrices(matrix1, matrix2);
            PrintMatrix(result2);

            Console.WriteLine("\nMatrix 1 * Matrix 2:");
            int[,] result3 = MultiplyMatrices(matrix1, matrix2);
            PrintMatrix(result3);
        }
        static void task5()
        {
            Console.WriteLine("Введите выражение:");
            string str=Console.ReadLine();
            int result = 0;
            int sign = 1;

            foreach (char c in str)
            {
                if (c == '+')
                {
                    sign = 1;
                }
                else if (c == '-')
                {
                    sign = -1;
                }
                else
                {
                    int number = c - '0';
                    result += sign * number;
                }
            }
        }
        
        static void task6()
        {
            Console.WriteLine("Введите текст:");
            string input = Console.ReadLine();

            string result = ChangeFirst(input);

            Console.WriteLine($"Результат: {result}");

        }
        static string ChangeFirst(string text)
        {
            char[] chars = text.ToCharArray();

            bool capitalize = true;
            for (int i = 0; i < chars.Length; i++)
            {
                if (capitalize && char.IsLetter(chars[i]))
                {
                    chars[i] = char.ToUpper(chars[i]);
                    capitalize = false;
                }

                if (chars[i] == '.' || chars[i] == '!' || chars[i] == '?')
                {
                    capitalize = true;
                }
            }

            return new string(chars);
        }
    }
}
