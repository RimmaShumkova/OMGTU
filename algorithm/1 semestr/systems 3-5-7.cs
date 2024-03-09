using System;
internal class Program
{
    public static void Main()
    {
        int count = Convert.ToInt32 (Console.ReadLine());
        int result = 0;
        for (int i = 0; i < count; i++)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            if (N < 0) { N = Math.Abs(N); }

            int s3 = N % 3; int s5 = N % 5; int s7 = N % 7;

            Console.WriteLine("Последняя цифра числа " + N + ":" + '\n' + "В 3-ой системе = " + s3 + '\n' + "В 5-ой системе = " + s5 + '\n' + "В 7-ой системе = " + s7);
            if (s3 == s5 && s5 == s7) {result++;}
        }
        Console.WriteLine("Количество элементов: " + result);
    }
}
