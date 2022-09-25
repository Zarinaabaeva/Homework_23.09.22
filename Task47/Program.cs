double [,] GenerateArray(int rows, int columns)
{
    double [,] array = new double [3,4];

    for (int  i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = Math.Round(new Random().NextDouble() * (20 + 20) - 20, 1);
        }
    }
    return array;
}


void PrintArray(double [,] myArray)
{
     for (int  i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            Console.Write($"{myArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

PrintArray(GenerateArray(3,4));
