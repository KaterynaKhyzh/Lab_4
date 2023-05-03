using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal partial class Andriychenko_1
    {
        public static int[] Block1(ref int[] array)
        {
            Console.WriteLine("\nБлок 1 - 7 варiант: \n");
            int evenIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    array[evenIndex] = array[i];
                    evenIndex++;
                }
            }
            Array.Resize(ref array, evenIndex);
            PrintArray(array);
            return array;
        }
        static void PrintArray(int[] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.Write(matrix[i] + "\t");
            }
            Console.WriteLine();
        }
    }
    internal partial class Andriychenko_2
    {
        public static int[][] Block3(ref int[][] arr)
        {

            int maxRowIndex = 0;
            int maxVal = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] > maxVal)
                    {
                        maxVal = arr[i][j];
                        maxRowIndex = i;
                    }
                }
            }

            int[] newRow = new int[arr[maxRowIndex].Length];
            for (int i = 0; i < newRow.Length; i++)
            {
                newRow[i] = 0;
            }

            int[][] newArr = new int[arr.Length + 1][];
            for (int i = newArr.Length; i > maxRowIndex + 1; i--)
            {
                newArr[i] = newArr[i - 1];
            }
            newArr[maxRowIndex + 1] = newRow;

            Console.WriteLine("Зубчастий масив з доданим рядком:");
            return newArr;
        }
    }
}
