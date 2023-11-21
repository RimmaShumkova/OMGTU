int n = Convert.ToInt32(Console.ReadLine());
int summ = 0;
int delta1 = 1000;
int delta2 = 1000;

for (int i = 0; i < n; i++)
{
    int first = Convert.ToInt32(Console.ReadLine());
    int second = Convert.ToInt32(Console.ReadLine());
    int maxl = Math.Max(first, second);
    int temp = Math.Abs(first - second);
    if (temp % 3 == 1 && (temp < delta1))
    {
        delta1 = temp;
    }
    else if ((temp + delta2) % 3 == 1 && (temp + delta2) < delta1)
    {
        delta1 = temp + delta2;
    }
    if (temp % 3 == 2 && temp < delta2)
    {
        delta2 = temp;
    }
    else if ((temp + delta1) % 3 == 2 && (temp + delta1) < delta2)
    {
        delta2 = temp + delta1;
    }

    summ += maxl;
}

if (summ % 3 == 0)
{
    Console.WriteLine(summ);
}

else if (delta1 < 1000 && (summ - delta1) % 3 == 0)
{
    Console.WriteLine(summ - delta1);
}

else if (delta2 < 1000 && (summ - delta2) % 3 == 0)
{
    Console.WriteLine(summ - delta2);
}

else
{
    Console.WriteLine("No");
}
Console.ReadLine();
