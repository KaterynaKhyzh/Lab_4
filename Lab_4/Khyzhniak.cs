using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    internal partial class Khyzhniak_1
    {
        
        public static void Task1_10(ref int[] arr)
        {
            Console.WriteLine("\nЗнищити всі елементи між першим із мінімальних за значенням і останнім із максимальних за\r\nзначенням; самі перший з мінімальних та останній з максимальних лишити (не знищувати); врахувати,\r\nщо невідомо, який з них записано в масиві раніше.");
            int min = arr[0];
            int max = arr[0];
            int minIndex = 0;
            int maxIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                    minIndex = i;
                }
                else if (arr[i] > max)
                {
                    max = arr[i];
                    maxIndex = i;
                }
            }

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] == max)
                {
                    maxIndex = i;
                    break;
                }
            }

            int firstIndex = Math.Min(minIndex, maxIndex);
            int lastIndex = Math.Max(minIndex, maxIndex);


            int newLength = arr.Length - (lastIndex - firstIndex - 1);

            int[] newArr = new int[newLength];

            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if ((i > firstIndex) && (i < lastIndex))
                {
                    continue;
                }
                newArr[index] = arr[i];
                index++;
            }

            arr = newArr;

            Console.WriteLine("Результат:");
            PrintMass(arr);
        }

        public static void PrintMass(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }

    internal partial class Khyzhniak_2
    {
        public static void Task3_14(ref int[][] arr)
        {
            Console.WriteLine("\nДодати рядок перед рядком, що містить мінімальний елемент (якщо у різних місцях є кілька елементів\r\nз однаковим мінімальним значенням, то брати перший з них)");
            int minElement = arr[0][0];
            int minIndex = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] < minElement)
                    {
                        minElement = arr[i][j];
                        minIndex = i;
                    }
                }
            }
            Console.WriteLine("Мінімальний елемент:" + minElement);
            int[] newRow = new int[] {2,0,2,3};
            int[][] newArr = new int[arr.Length + 1][];
            for(int i = 0; i < newArr.Length; i++)
            {
                if(i < minIndex)
                {
                    newArr[i] = arr[i];
                }else if(i == minIndex)
                {
                    newArr[i] = newRow;
                }else
                {
                    newArr[i] = arr[i-1];
                }

            }

            arr = newArr;
            PrintMass(arr);
        }

        public static void PrintMass(int[][] arr)
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
    }
}
