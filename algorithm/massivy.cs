using System;
using System.ComponentModel;
using System.Linq;

internal class Program
{
    public static int[] SameNumbers(int[] numbers)
    {
        int[] result = new int[0];
        Array.Sort(numbers);
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] == numbers[i - 1]) { result = result.Append(numbers[i]).ToArray(); }
        }
        return result;
    }
    public static void Main()
    {
        Console.Write("Подмассивы: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[][] stairsArray = new int[n][];
        int[] array = new int [0];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Количество элементов подмассива: ");
            int count = Convert.ToInt32(Console.ReadLine());
            stairsArray[i] = new int[count];
            Console.WriteLine("Элементы: ");
            for(int j = 0; j < count; j++)
            {
                stairsArray[i][j] = Convert.ToInt32(Console.ReadLine());
                array = array.Append(stairsArray[i][j]).ToArray();
            }
        }
        Console.WriteLine();

        for(int i = 0; i < n; i++)
        {
            Array.Sort(stairsArray[i]);
            for(int j = 0;j < stairsArray[i].Length; j++)
            {
                Console.Write(stairsArray[i][j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Исходный одномерный массив: " + "{0}", String.Join(" ", array));
        Console.WriteLine();
        Array.Sort(array);
        int[] union = array.Distinct().ToArray();
        Console.WriteLine("Массив - объединение: " + "{0}", String.Join(" ", union));

        int[] arr = new int [0];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < stairsArray[i].Length; j++)
            {
                arr = union.Where(x => !stairsArray[i].Contains(x)).ToArray();
            }
            Console.WriteLine("Массив - дополнение " + (i+1) + ": " + "{0}", String.Join(" ", arr));

        }

        for (int i = 0; i < n-1; i++){ array = SameNumbers(array); }
        int[] cross = array;
        Console.WriteLine("Массив - пересечение: " + "{0}", String.Join(" ", cross));
    }
}
