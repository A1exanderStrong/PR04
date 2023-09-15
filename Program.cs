using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

/*
            Вариант Б16
1. Дан целочисленный массив, состоящий из N элементов (N > 0). 
    Найти максимальный и минимальный элемент в массиве и вычислить их сумму.

2. В вещественном массиве хранятся сведения о количестве осадков, выпавших за каждый день месяца N 
    (в месяце должно быть 30 дней). Определить общее количество осадков, выпавших за каждую декаду этого месяца 
    (декада состоит из 10 дней). Предоставить возможность пользователю реализовать заполнение элементов массива 
    случайными (рандомными) числами.

3. Вводится строка-предложение. Длина строки может быть разной. 
    Подсчитать и вывести на экран количество содержащихся в строке знаков препинания.

4. Вводится строка, состоящая из цифр и символов английского алфавита. Длина строки может быть разной. 
    Вывести на экран произведение всех нечетных цифр этого числа.

5. Вводится строка, состоящая из слов, разделенных подчеркиваниями (одним или несколькими). 
    Длина строки может быть разной. Определить и вывести на экран количество слов, которые содержат ровно четыре буквы 'w'.
 */

namespace PR04
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region Задание 1
            int elementsCount = 0;

        task1_Input:
            Console.WriteLine("Введите количество элементов массива");
            try
            {
                elementsCount = Convert.ToInt32(Console.ReadLine());
            }
            catch (OverflowException)
            {
                Console.WriteLine("\nВведено слишком большое число");
                Console.WriteLine("\nНажмите любую клавишу для перезапуска задания...");
                Console.ReadKey();
                Console.WriteLine("\n\n\n");
                goto task1_Input;
            }
            catch (FormatException)
            {
                Console.WriteLine("\nНеверный формат ввода");
                Console.WriteLine("\nНажмите любую клавишу для перезапуска задания...");
                Console.ReadKey();
                Console.WriteLine("\n\n\n");
                goto task1_Input;
            }

            int[] array = new int[elementsCount];
        task1_Input_arr:
            Console.WriteLine("Выберите способ заполнения массива: \n1. Вручную \n2. Автоматически");
            switch (Console.ReadLine())
            {
                case "1":
                    for (int i = 0; elementsCount > i; i++)
                    {
                        Console.WriteLine("Введите элемент массива #{0}", i);

                        try
                        {
                            array[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        catch (OverflowException)
                        {
                            Console.WriteLine("\nВведено слишком большое число");
                            Console.WriteLine("\nНажмите любую клавишу для перезапуска задания...");
                            Console.ReadKey();
                            Console.WriteLine("\n\n\n");
                            goto task1_Input_arr;

                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("\nНеверный формат ввода");
                            Console.WriteLine("\nНажмите любую клавишу для перезапуска задания...");
                            Console.ReadKey();
                            Console.WriteLine("\n\n\n");
                            goto task1_Input_arr;
                        }

                    }
                    break;
                case "2":
                    Random randomNumber = new Random();
                    for (int i = 0; elementsCount > i; i++)
                    {
                        array[i] = randomNumber.Next();
                    }
                    break;
                default:
                    Console.WriteLine("Выбран некорректный вариант заполнения массива");
                    break;

            }

            int minNum = array.Min();
            int maxNum = array.Max();
            int arrSum = minNum + maxNum;

            Console.WriteLine("\nСумма максимального и минимального элементов массива = {0}", arrSum);
            Console.WriteLine("\nДля продолжения нажмите любую клавишу...");
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Задание 2
            double[] decade01 = new double[10];
            double[] decade02 = new double[10];
            double[] decade03 = new double[10];

        task2_Input_decade01:
            Console.WriteLine("Выберите способ заполнения первой декады месяца: \n1. Вручную \n2. Автоматически");
            switch (Console.ReadLine())
            {
                case "1":
                    for (int i = 0; 10 > i; i++)
                    {
                        Console.WriteLine("Введите элемент массива #{0}", i);

                        try
                        {
                            decade01[i] = Convert.ToDouble(Console.ReadLine());
                        }
                        catch (OverflowException)
                        {
                            Console.WriteLine("\nВведено слишком большое число");
                            Console.WriteLine("\nНажмите любую клавишу для перезапуска задания...");
                            Console.ReadKey();
                            Console.WriteLine("\n\n\n");
                            goto task2_Input_decade01;

                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("\nНеверный формат ввода");
                            Console.WriteLine("\nНажмите любую клавишу для перезапуска задания...");
                            Console.ReadKey();
                            Console.WriteLine("\n\n\n");
                            goto task2_Input_decade01;
                        }

                    }
                    break;
                case "2":
                    Random randomNumber = new Random();
                    for (int i = 0; 10 > i; i++)
                    {
                        decade01[i] = randomNumber.NextDouble() * 5.0;
                    }                                                   
                    break;                                              
                default:
                    Console.WriteLine("Выбран некорректный вариант заполнения массива");
                    break;
            }

        task2_Input_decade02:
            Console.WriteLine("Выберите способ заполнения второй декады месяца: \n1. Вручную \n2. Автоматически");
            switch (Console.ReadLine())
            {
                case "1":
                    for (int i = 0; 10 > i; i++)
                    {
                        Console.WriteLine("Введите элемент массива #{0}", i);

                        try
                        {
                            decade02[i] = Convert.ToDouble(Console.ReadLine());
                        }
                        catch (OverflowException)
                        {
                            Console.WriteLine("\nВведено слишком большое число");
                            Console.WriteLine("\nНажмите любую клавишу для перезапуска задания...");
                            Console.ReadKey();
                            Console.WriteLine("\n\n\n");
                            goto task2_Input_decade02;

                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("\nНеверный формат ввода");
                            Console.WriteLine("\nНажмите любую клавишу для перезапуска задания...");
                            Console.ReadKey();
                            Console.WriteLine("\n\n\n");
                            goto task2_Input_decade02;
                        }

                    }
                    break;
                case "2":
                    Random randomNumber = new Random();
                    for (int i = 0; 10 > i; i++)
                    {
                        decade02[i] = randomNumber.NextDouble() * 5.0;
                    }
                    break;
                default:
                    Console.WriteLine("Выбран некорректный вариант заполнения массива");
                    break;
            }

        task2_Input_decade03:
            Console.WriteLine("Выберите способ заполнения третьей декады месяца: \n1. Вручную \n2. Автоматически");
            switch (Console.ReadLine())
            {
                case "1":
                    for (int i = 0; 10 > i; i++)
                    {
                        Console.WriteLine("Введите элемент массива #{0}", i);

                        try
                        {
                            decade03[i] = Convert.ToDouble(Console.ReadLine());
                        }
                        catch (OverflowException)
                        {
                            Console.WriteLine("\nВведено слишком большое число");
                            Console.WriteLine("\nНажмите любую клавишу для перезапуска задания...");
                            Console.ReadKey();
                            Console.WriteLine("\n\n\n");
                            goto task2_Input_decade03;

                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("\nНеверный формат ввода");
                            Console.WriteLine("\nНажмите любую клавишу для перезапуска задания...");
                            Console.ReadKey();
                            Console.WriteLine("\n\n\n");
                            goto task2_Input_decade03;
                        }

                    }
                    break;
                case "2":
                    Random randomNumber = new Random();
                    for (int i = 0; 10 > i; i++)
                    {
                        decade03[i] = randomNumber.NextDouble() * 5.0;
                    }
                    break;
                default:
                    Console.WriteLine("Выбран некорректный вариант заполнения массива");
                    break;
            }

            Console.WriteLine("Количество осадков выпавших за первую декаду месяца: {0} мм", Math.Round(decade01.Sum(), 3));
            Console.WriteLine("Количество осадков выпавших за вторую декаду месяца: {0} мм", Math.Round(decade02.Sum(), 3));
            Console.WriteLine("Количество осадков выпавших за третью декаду месяца: {0} мм", Math.Round(decade03.Sum(), 3));

            Console.WriteLine("\nДля продолжения нажмите любую клавишу...");
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Задание 3

            string string_task3;
            Console.WriteLine("Введите предложение...");
            string_task3 = Console.ReadLine();

            char[] chars_task3 = string_task3.ToCharArray();
            char[] punctuation_chars = { ',', '!', ':', ';', '.', '?', '-'};
            int counter = 0;
            for (int c = 0; c < chars_task3.Length; c++) 
            {
                for (int i = 0; i < punctuation_chars.Length; i++) 
                {
                    if (punctuation_chars[i] == chars_task3[c]) counter++;
                }
            }
            Console.WriteLine("Количество знаков препинания в строке = {0}", counter);
            Console.WriteLine("\nДля продолжения нажмите любую клавишу...");
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Задание 4
            string string_task4;
            Console.WriteLine("Введите предложение...");

            string_task4 = Console.ReadLine();

            char[] chars_task4 = string_task4.ToCharArray();
            char[] oddNums = {'1', '3', '5', '7', '9'};
            int oddComp = 1; int counter02 = 0;

            for (int c = 0;c < chars_task4.Length; c++)
            { 
                for (int i = 0;i < oddNums.Length;i++) 
                {
                    if (oddNums[i] == chars_task4[c]) { oddComp *= Int32.Parse(oddNums[i].ToString()); counter02++; }
                }
            }

            if (counter02 == 0) oddComp = 0;
            Console.WriteLine("Произведение всех нечётных цифр в предложении = {0}", oddComp);
            Console.WriteLine("\nДля продолжения нажмите любую клавишу...");
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region Задание 5
            string string_task5;
            Console.WriteLine("Введите предложение...");
            string_task5 = Console.ReadLine();

            char[] chars_task5 = string_task5.ToCharArray();
            int counter03 = 0;

            for (int i = 3; i<chars_task5.Length; i++)
            {
                if (chars_task5[i] == 'w' && chars_task5[i-1] == 'w' && chars_task5[i-2] == 'w' && chars_task5[i-3] == 'w')
                {
                    counter03++;
                }
            }

            Console.WriteLine(counter03);
            Console.WriteLine("\nДля продолжения нажмите любую клавишу...");
            Console.ReadKey();
            Console.Clear();
            #endregion
        }
    }
}
