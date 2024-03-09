using System;
public class Program
{
    public static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] mas = new int[n];
        for (int i = 0; i < n; i++)
        {
            mas[i] = Convert.ToInt32(Console.ReadLine());
        }
        // задача 1
        int minpos = 623846, count1 = 0;
        foreach (int i in mas)
        {
            if (i == 0) count1 += 1;
            else if (count1 != 0)
            {
                if (count1 < minpos)
                {
                    minpos = count1;
                    count1 = 0;
                }
            }
        }
        if (count1 != 0)
        {
            if (count1 < minpos) minpos = count1;
        }
        if (minpos == 623846) Console.WriteLine("1)Нет нулей в последовательности");
        else Console.WriteLine("1)" + minpos);
        // задача 2
        int maxpos1 = 0, count2 = 0;
        foreach(int i in mas)
        {
            if (i > 0)
            {
                count2 += 1;
                if (count2 > maxpos1)
                    maxpos1 = count2;
            }
            else count2 = 0;
        }
        Console.WriteLine("2)" + maxpos1);
        // задача 3
        int maxpos2 = 0, count3 = 1;
        for (int i = 0; i < n - 1; i++)
        {
            if (mas[i] < mas[i + 1])
            {
                count3 += 1;
                if (count3 > maxpos2) maxpos2 = count3;
            }
            else count3 = 1;
        }
        Console.WriteLine("3)" + maxpos2);
        // задача 4
        bool flag = true;
        foreach(int i in mas)
        {
            if (i <= 0 | i % 2 != 0 | i % 10 != 6) flag = false;
        }
        if (flag) Console.WriteLine("4)Все элементы");
        else Console.WriteLine("4)Не все элементы");
    }
}
