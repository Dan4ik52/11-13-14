using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Pract11()
        {

            Console.Write("Введите номер задачи: ");
            short numb = short.Parse(Console.ReadLine());
            switch (numb)
            {
                case 1:
                    Console.Write("Введите длину последовательности: ");
                    int n = int.Parse(Console.ReadLine());

                    int[] a = new int[n];

                    Console.WriteLine("Введите элементы последовательности:");
                    for (int k = 0; k < n; k++)
                    {
                        a[k] = int.Parse(Console.ReadLine());
                    }

                    int count = 0;

                    for (int k = 1; k < n - 1; k++)
                    {
                        if (a[k] < (a[k - 1] + a[k + 1]) / 2)
                        {
                            count++;
                        }
                    }

                    Console.WriteLine("Количество элементов, удовлетворяющих условию: " + count);
                    break;

                case 2:
                    Console.Write("Условие: 17.Все элементы с нечетными номерами увеличить на 1, с четными – уменьшить на 1;");
                    int [] numbers = { 1, 2, 3, 4, 5, 6, 7, 8,};

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        if (i % 2 == 0)
                        {
                            numbers[i] -= 1;
                        }
                        else
                        {
                            numbers[i] += 1;
                        }
                    }
                    Console.WriteLine("Изменённый массив:");
                    Console.WriteLine(string.Join(" ", numbers));
                    break;


                    case 3:
                    Console.Write("17.В массиве хранится информация о результатах 22 спортсменов, участвовавших в соревнованиях по бегу на 100 м. Определить результаты спортсменов, занявших первое и второе места.");
                    Random random = new Random();
                    double min = 9.6;
                    double max = 12.0;

                    double[] results = new double[22];

                    for (int i = 0; i < results.Length; i++)
                    {
                        results[i] = Math.Round(random.NextDouble() * (max - min) + min, 2);
                    }

                    Console.WriteLine("Результаты всех спортсменов:");
                    for (int i = 0; i < results.Length; i++)
                    {
                        Console.WriteLine($"Спортсмен {i + 1}: {results[i]} сек.");
                    }

                    Array.Sort(results);

                    Console.WriteLine("\nЛучшие результаты:");
                    Console.WriteLine("Первое место: " + results[0] + " сек.");
                    Console.WriteLine("Второе место: " + results[1] + " сек.");
                    break;
            } 
        }



        static void Pract13_14()
        {
            {
                Console.Write("Введите номер задачи: ");
                short zadacha = short.Parse(Console.ReadLine());
                switch (zadacha)
                {
                    case 1:
                        int[,] array = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 },
            { 1, 3, 2 }
        };

                        // Переменные для хранения индекса строки с минимальной суммой и самой суммы
                        int minRowIndex = 0;
                        int minSum = int.MaxValue;

                  
                        for (int i = 0; i < array.GetLength(0); i++)
                        {
                            int rowSum = 0;

                            // Считаем сумму элементов в строке
                            for (int j = 0; j < array.GetLength(1); j++)
                            {
                                rowSum += array[i, j];
                            }

                            // Если сумма этой строки меньше текущей минимальной суммы, обновляем
                            if (rowSum < minSum)
                            {
                                minSum = rowSum;
                                minRowIndex = i;
                            }
                        }

            
                        Console.WriteLine($"Строка с минимальной суммой элементов: {minRowIndex + 1}");
                        break;

                    case 2:
                      
                        int numberOfStores = 10;
                        int numberOfMonths = 12;

                       
                        Random random = new Random();

         
                        double[,] income = new double[numberOfStores, numberOfMonths];

                        // Заполнение массива случайными значениями (доход от 500 до 5000)
                        for (int i = 0; i < numberOfStores; i++)  // Проходим по магазинам
                        {
                            for (int j = 0; j < numberOfMonths; j++)  // Проходим по месяцам
                            {
                                income[i, j] = random.Next(500, 5001);  // Генерируем случайный доход от 500 до 5000
                            }
                        }

                  
                        double threshold = 50000;

                        // Переменная для подсчёта общего дохода
                        double totalIncome = 0;

                        // Проходим по всем элементам двумерного массива и суммируем их
                        for (int i = 0; i < numberOfStores; i++)  // Проходим по магазинам
                        {
                            for (int j = 0; j < numberOfMonths; j++)  // Проходим по месяцам
                            {
                                totalIncome += income[i, j];
                            }
                        }

                 
                        Console.WriteLine($"Общий доход фирмы за год: {totalIncome}");

                        if (totalIncome > threshold)
                        {
                            Console.WriteLine("Общий доход фирмы за год превышает заданное число.");
                        }
                        else
                        {
                            Console.WriteLine("Общий доход фирмы за год не превышает заданное число.");
                        }
                        break;

                    case 3:
                        int[,] a = {
            {1, 0, 3},
            {4, 5, 0},
            {0, 7, 8}
        };

                        int k = 99; // Число, на которое будем заменять нули

                        for (int i = 0; i < a.GetLength(0); i++)
                        {
                            bool foundZero = false;
                            for (int j = 0; j < a.GetLength(1); j++)
                            {
                                if (a[i, j] == 0 && !foundZero)
                                {
                                    a[i, j] = k;
                                    foundZero = true;
                                    break; // Выходим из внутреннего цикла, как только нашли первый нулевой элемент
                                }
                            }
                        }

                        // Вывод измененного массива
                        for (int i = 0; i < a.GetLength(0); i++)
                        {
                            for (int j = 0; j < a.GetLength(1); j++)
                            {
                                Console.Write(a[i, j] + " ");
                            }
                            Console.WriteLine();
                        }             
            break;


                        case 4:
                        int[,] arrаy = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

                        int limit = 5; // Число, с которым сравниваем элементы

                        int[] result = new int[arrаy.GetLength(0)];

                        for (int i = 0; i < arrаy.GetLength(0); i++)
                        {
                            int sum = 0;
                            for (int j = 0; j < arrаy.GetLength(1); j++)
                            {
                                if (arrаy[i, j] < limit)
                                {
                                    sum += arrаy[i, j];
                                }
                            }
                            result[i] = sum;
                        }

                        // Вывод результата
                        foreach (int num in result)
                        {
                            Console.Write(num + " ");
                        }
                        break;
                }

            }
        }
                static void Main(string[] args)
                {
                    Console.Write("Введите номер практической работы(11,13-14):");
                    short numb = short.Parse(Console.ReadLine());
                    switch (numb)
                    {
                        case 11: Pract11(); break;

                        case 13:
                            Pract13_14();
                            break;
                    }
                    Console.ReadKey();
                }
            }
        }