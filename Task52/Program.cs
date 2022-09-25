int[,] GenerateArray(int GetLength1, int GetLength2)
{
    int[,] array = new int[3, 4];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
    return (array);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}


double AverageElementColumnsArray(int[,] array)
{
    double average = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        double average1 = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum = array[i, j] + sum;
            average1 = Math.Round((sum / array.GetLength(0)), 2);
        }
        average = average1;
        Console.Write($" {average};");
    }

    return average;
}

int[,] arr = GenerateArray(3, 4);
PrintArray(arr);
Console.Write($"Среднее арифметическое каждого столбца: ");
AverageElementColumnsArray(arr);
