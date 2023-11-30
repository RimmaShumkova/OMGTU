using System;
using System.Linq;
public class Program
{
    public static void Main()
    {
        Console.Write("Количество мышей: ");
        int mice = Convert.ToInt32(Console.ReadLine());

        Console.Write("Шаг: ");
        int shag = Convert.ToInt32(Console.ReadLine());

        int counter = 0, count = 0;
        int[] array = new int[mice];

        while (counter < mice - 1) for (int i = 0; i < mice; i++)
            {
                if (array[i] != '-') count++;
                if (count == shag && array[i] != '-')
                {
                    array[i] = '-';
                    counter++;
                    count = 0;
                }
            }
        if (array.Contains(0)) Console.WriteLine("Нужно начать с " + (Array.IndexOf(array, 0) + 1));
    }
}
