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

int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int index1 = Prompt("Введите первую позицию элемента ");
int index2 = Prompt("Введите вторую позицию элемента ");

(int, int) FindElementArray(int[,] array)
{
    if (index1 >= array.GetLength(0) || index1 <= 0 || index2 >= array.GetLength(1) || 

index2 <= 0)
        Console.Write($"Элемент с позициями {index1} и {index2} не существует");
    else
    {
        Console.Write($"Элемент {array[index1, index2]} с позициями ({index1} и {index2})");
    }

    return (index1, index2);
}

int[,] arr = GenerateArray(3, 4);
PrintArray(arr);
FindElementArray(arr);
