using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal partial class Drobidko_1
    {
        public static void Task1_5(ref int[] arr)
        {
            Console.Write("Скільки елементів потрібно знищити: ");
            int t = int.Parse(Console.ReadLine());

            Console.Write("З якого індексу почать? ");
            int k = int.Parse(Console.ReadLine());

            if (k >= 0)
                RemoveAt(ref arr, k, t);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            static void RemoveAt(ref int[] array, int k, int t)
            {
                int elements;

                if (t + k < array.Length)
                    elements = array.Length - t;
                else
                    elements = k;

                int[] changed = new int[elements];

                for (int i = 0; i < k; i++)
                    changed[i] = array[i];

                for (int i = t + k, j = k; i < array.Length; i++, j++)
                    changed[j] = array[i];

                array = changed;
            }
        }
    }
    internal partial class Drobidko_2
    {
        public static void Task3_11(ref int[][] arr)
        {

            int count = 0;

            for (int i = 0, k = 0; i < arr.Length; i++)
            {
                if (i % 2 == 0)
                    count++;
            }

            int[][] array = new int[arr.Length + count][];

            for (int i = 0, k = 0; i < arr.Length; i++, k++)
            {
                array[k] = arr[i];

                if (i % 2 == 0)
                {
                    k++;
                    array[k] = new int[arr[i].Length];
                }
            }

            arr = array;
        }


    }

}
