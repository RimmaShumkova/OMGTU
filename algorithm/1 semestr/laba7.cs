Console.WriteLine("кол-во рядов: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("кол-во колонн: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, columns];
int[,] FillArray(int[,] arr)
{
    int rows = arr.GetLength(0);
    int cols = arr.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write($"Введите значение для элемента [{i},{j}]: ");
            arr[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
    return array;
}

PrintArray(FillArray(array));

int FindMinimumInRow(int[,] array, int row)
{
    int min = array[row, 0];

    for (int j = 1; j < array.GetLength(1); j++)
    {
        if (array[row, j] < min)
        {
            min = array[row, j];
        }
    }

    return min;
}



Console.WriteLine("Введите ряд: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Минимальный элемент в ряду: ");
Console.WriteLine(FindMinimumInRow(array, row-1));


int FindMaximumInArray(int[,] array)
{
    int max = array[0, 0];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] > max)
            {
                max = array[i, j];
            }
        }
    }

    return max;
}

int CountOccurrencesInColumn(int[,] array, int element, int column)
{
    int count = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (array[i, column] == element)
        {
            count++;
        }
    }

    return count;
}

for (int i = 0; i < array.GetLength(1); i++)
{
    Console.WriteLine($"Кол-во макс элементов в столбце {i}: ");
    Console.WriteLine(CountOccurrencesInColumn(array, FindMaximumInArray(array), i));
}

int[,] SwapRows(int[,] array)
{
    int[,] swappedArray = array;
    int rows = swappedArray.GetLength(0);
    int columns = swappedArray.GetLength(1);

    for (int i = 0; i < rows; i += 2)
    {
        for (int j = 0; j < columns; j++)
        {
            int temp = swappedArray[i, j];
            swappedArray[i, j] = swappedArray[i + 1, j];
            swappedArray[i + 1, j] = temp;
        }
    }

    return swappedArray;
}



Console.WriteLine("Перемешанный массив: ");
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0} ", array[i, j]);
        }

        Console.WriteLine();
    }
}

PrintArray(SwapRows(array));

