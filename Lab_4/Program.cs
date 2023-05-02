using System;
using System.Formats.Tar;
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab_4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int blockNumber;
            do
            {
                Console.WriteLine("Оберіть номер блоку (1 або 3) для виконання.\n(Якщо бажаєте закінчити виконання, натисніть 0)");
                blockNumber = int.Parse(Console.ReadLine());
                switch (blockNumber)
                {
                    case 0:
                        Console.WriteLine("Завершення виконання...");
                        break;
                    case 1:
                        Block1();
                        break;
                    case 3:
                        Block3();
                        break;
                    default:
                        Console.WriteLine("Введено неіснуючий номер блоку, повторіть спробу або натисність 0 для виходу з програми.");
                        break;
                }

            } while (blockNumber != 0);

        }

        public static void Block1()
        {
            Console.WriteLine("Введіть прізвище студента варіант якого бажаєте виконати.\n(Для завершення виконання варіанту натисніть 0)");
            string surname = Console.ReadLine().ToLower();
            Console.WriteLine("Введіть кількість елементів масиву:");
            int numOfElements = int.Parse(Console.ReadLine());
            int[] arr = new int[numOfElements];
            CreateArr1(numOfElements, arr);
            do
            {
                switch (surname)
                {
                    case "хижняк":
                        Khyzhniak_1.Task1_10(ref arr);
                        Console.WriteLine("\nПоточний масив:");
                        OutputArray_1(arr);
                        break;
                    case "дроб?дько":
                        Console.WriteLine("\nПоточний масив:");
                        OutputArray_1(arr);
                        break;
                    case "андр?йченко":
                        Console.WriteLine("\nПоточний масив:");
                        OutputArray_1(arr);
                        break;
                    default:
                        Console.WriteLine("Студента з таким прізвищем не має, спробуйте ще раз.");
                        break;
                }
                Console.WriteLine("\nВведіть прізвище студента варіант якого бажаєте виконати.\n(Для завершення виконання варіанту натисніть 0)");
                surname = Console.ReadLine().ToLower();
                if (surname == "хижняк" || surname == "дроб?дько" || surname == "андр?йченко")
                {
                    Console.WriteLine("Бажаєте створити новий масив?\nтак;\nні.");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "так")
                    {
                        Console.WriteLine("Введіть кількість елементів масиву:");
                        numOfElements = int.Parse(Console.ReadLine());
                        arr = new int[numOfElements];
                        CreateArr1(numOfElements, arr);
                    }

                }
            } while (surname != "0");
        }

        public static int[] CreateArr1(int numOfElements, int[] arr)
        {
            int numOfFilling;

            Console.WriteLine("Оберіть спосіб заповнення масиву:\n1 - вручну;\n2 - рандомом.");
            numOfFilling = int.Parse(Console.ReadLine());
            switch (numOfFilling)
            {
                case 1:
                    FillSeparetaly_1(numOfElements, ref arr);
                    break;
                case 2:
                    FillRandomly_1(numOfElements, ref arr);
                    break;
                default:
                    Console.WriteLine("Обраного способу не існує, спробуйте ще раз.");
                    break;
            }
            return arr;
        }
        public static int[] FillSeparetaly_1(int numOfElement, ref int[] arr)
        {
            Console.WriteLine("Вводьте масив:");
            string[] line = Console.ReadLine().Trim().Split();

            for (int i = 0; i < numOfElement; i++)
            {
                arr[i] = int.Parse(line[i]);
            }
            
            return arr;
        }

        public static int[] FillRandomly_1(int numOfElement, ref int[] arr)
        {
            Random random = new();
            for (int i = 0; i < numOfElement; i++)
            {
                arr[i] = random.Next(-101, 101);
            }
            Console.WriteLine("Початковий масив:");
            PrintMass_1(arr);

            return arr;
        }

        public static void PrintMass_1(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        public static void OutputArray_1(int[] arr)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("Масив не містить жодного елементу.");
            }
            else
            {
                PrintMass_1(arr);
            }
        }

        public static void Block3()
        {
            
            Console.WriteLine("Введіть кількість рядків масиву:");
            int numOfRows = int.Parse(Console.ReadLine());
            int[][] arr = new int[numOfRows][];
            CreateArr2(numOfRows, arr);
            Console.WriteLine("Введіть прізвище студента варіант якого бажаєте виконати.\n(Для завершення виконання варіанту натисніть 0)");
            string surname = Console.ReadLine().ToLower();
            do
            {
                switch (surname)
                {
                    case "хижняк":
                        Khyzhniak_2.Task3_14(ref arr);
                        Console.WriteLine("\nПоточний масив:");
                        OutputArray_2(arr);
                        break;
                    case "дроб?дько":
                        Console.WriteLine("\nПоточний масив:");
                        OutputArray_2(arr);
                        break;
                    case "андр?йченко":
                        Console.WriteLine("\nПоточний масив:");
                        OutputArray_2(arr);
                        break;
                    default:
                        Console.WriteLine("\tСтудента з таким прізвищем не існує, спробуйте ще раз.");
                        break;
                }
                Console.WriteLine("\nВведіть прізвище студента варіант якого бажаєте виконати.\n(Для завершення виконання варіанту натисніть 0)");
                surname = Console.ReadLine().ToLower();
                if (surname == "хижняк" || surname == "дроб?дько" || surname == "андр?йченко")
                {
                    Console.WriteLine("Бажаєте створити новий масив?\nтак;\nні.");
                    string answer = Console.ReadLine().ToLower();
                    if (answer == "так")
                    {
                        Console.WriteLine("Введіть кількість рядків масиву:");
                        numOfRows = int.Parse(Console.ReadLine());
                        arr = new int[numOfRows][];
                        CreateArr2(numOfRows, arr);
                    }

                }
            } while (surname != "0");
        }
        public static int[][] CreateArr2(int numOfRows, int[][] arr)
        {
            int numOfFilling;

            Console.WriteLine("Оберіть спосіб заповнення масиву:\n1 - вручну;\n2 - рандомом.");
            numOfFilling = int.Parse(Console.ReadLine());
            switch (numOfFilling)
            {
                case 1:
                    FillSeparetaly_2(numOfRows, ref arr);
                    break;
                case 2:
                    FillRandomly_2(numOfRows, ref arr);
                    break;
                default:
                    Console.WriteLine("Обраного способу не існує, спробуйте ще раз.");
                    break;
            }
            return arr;
        }
        public static int[][] FillSeparetaly_2(int numOfRows, ref int[][] arr)
        {
            Console.WriteLine("Вводьте масив:");
            for (int i = 0; i < numOfRows; i++)
            {
                string[] rowOfArray = Console.ReadLine().Trim().Split();
                arr[i] = new int[rowOfArray.Length];
                for (int j = 0; j < rowOfArray.Length; j++)
                {
                    arr[i][j] = Convert.ToInt32(rowOfArray[j]);
                }
            }
            return arr;
        }
        public static int[][] FillRandomly_2(int numOfRows, ref int[][] arr)
        {
            Random rd = new Random();

            for (int i = 0; i < numOfRows; i++)
            {
                Console.Write($"Введіть кількість елементів у рядку {i}: ");
                int cols = int.Parse(Console.ReadLine());

                arr[i] = new int[cols];

                for (int j = 0; j < cols; j++)
                {
                    arr[i][j] = rd.Next(-101, 101);
                }
            }

            Console.WriteLine("Початковий масив:");
            PrintMass_2(arr);
            return arr;
        }

        public static void PrintMass_2(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public static void OutputArray_2(int[][] arr)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("Масив не містить жодного елементу.");
            }
            else
            {
                PrintMass_2(arr);
            }
        }
    }
}