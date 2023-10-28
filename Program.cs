using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1:");
            int[] arr = new int[15];          // Создание массива
            Random r = new Random();
            for(int i=0; i<arr.Length; i++)
            {
                arr[i] = r.Next(-3, 4);       // Рандомное заполние массива
            }
            foreach (int item in arr)
            {
                Console.Write(item + "\t");   // Вывод массива
            }
            Console.WriteLine();
            int ch = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    ch++;                     // Подсчёт количества нулей в массиве
                }
            }
            for (int j = 0; j < ch; j++)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    if (arr[i] == 0)         // Перемещение нулей в конец массива
                    {
                        int num = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = num;                        
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    arr[i] = -1;              // Замена нулей на -1
                }
            }
            foreach (int item in arr)
            {
                Console.Write(item + "\t");  // Вывод конечного массива
            }
            Console.WriteLine();

            Console.WriteLine("Task 2:");
            int[] mass = new int[15];               // Создание массива
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = r.Next(-10, 11);          // Рандомное заполнение массива
            }
            foreach (int item in mass)
            {
                Console.Write(item + "\t");
            }
            Console.WriteLine();
            ch = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                if (mass[i] < 0)                   // Подсчёт отрицательных элементов
                {
                    ch++;
                }
            }
            for (int j = 0; j < ch; j++)
            {
                for (int i = mass.Length - 1; i > 0; i--)
                {
                    if (mass[i] < 0)              // Перемещение отрицательных элементов 
                    {                             // в начало массива
                        int num = mass[i];
                        mass[i] = mass[i - 1];
                        mass[i - 1] = num;
                    }
                }
            }
            foreach (int item in mass)
            {
                Console.Write(item + "\t");       // Вывод конечного массива
            }
            Console.WriteLine();

            Console.WriteLine("Task 3:");
            int[] array = new int[50];              // Создание массива
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(-50, 50);         // Рандомное заполнение массива
            }
            foreach (int item in array)
            {
                Console.Write(item + "\t");         // Вывод массива
            }
            Console.WriteLine();
            Console.Write("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            ch = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    ch++;               // Подсчёт количества вхождений заданного числа в массив
                }
            }
            Console.WriteLine($"Number {number} is array: {ch}");
            Console.WriteLine();

            Console.WriteLine("Task 4:");
            // Ввести количество строк
            Console.Write("Enter m: ");     
            int m = Convert.ToInt32(Console.ReadLine());
            // Ввести количество столбцов
            Console.Write("Enter n: ");     
            int n = Convert.ToInt32(Console.ReadLine());
            // Создание двумерного зубчатого массива
            int[][] matrix = new int[m][];  
            for(int i = 0; i < m; i++)
            {
                matrix[i] = new int[n];
            }
            // Рандомное заполнение массива
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    matrix[i][j] = r.Next(0, 50);  
                }
            }
            // Вывод массива
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + "\t");
                }
                Console.WriteLine();
            }
            // Ввести номера столбцов, которые нужно поменять местами
            Console.Write("Enter in 1 column: ");
            int col_1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter in 2 column: ");
            int col_2 = Convert.ToInt32(Console.ReadLine());
            // Меняем местами столбцы массива
            for(int i = 0; i < matrix.Length; i++)
            {
                int num = matrix[i][col_1];
                matrix[i][col_1] = matrix[i][col_2];
                matrix[i][col_2] = num;
            }
            // Вывод массива
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write(matrix[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
