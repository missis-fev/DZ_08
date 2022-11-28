//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7


int[,] CreateArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = random.Next(0, 10);
        }
    }
    return array;
}
void PrintArray(int[,] input)
{
    for (var i = 0; i < input.GetLength(0); i++)
    {
        for (var j = 0; j < input.GetLength(1); j++)
        {
            Console.Write(input[i, j]);
            if (j != input.GetLength(1) - 1)
                Console.Write(" ");
            if (input[i, j] < 10) Console.Write(" ");
        }
        Console.WriteLine();
    }
}

int[] strArray(int[,] input)
{
    int[] array = new int[input.GetLength(0)];
    for (var i = 0; i < input.GetLength(0); i++)
        for (var j = 0; j < input.GetLength(1); j++)
        {
            array[i] += input[i, j];
        }
    return array;
}

void findMin(int[] input)
{
    var minSum = input[0];
    var n = 1;
    for (int i = 0; i < input.GetLength(0); i++)
    {
        if (input[i] < minSum)
        {
            minSum = input[i];
            n = i+1;
        }
    }
    Console.WriteLine($"Строка с минимальной суммой: {n} ");
    Console.WriteLine($"Минимальная сумма: {minSum} ");
    
}

var array = CreateArray(4, 4);
PrintArray(array);
Console.WriteLine();
findMin(strArray(array));