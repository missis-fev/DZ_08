//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

int[,] createArray1()
{
    int[,] input = new int[2,2];
    for (int i = 0; i < 2; i++)
    for (int j = 0; j < 2; j++)
    {
        Console.Write($"Введите число поз. {i},{j} = ");
        input[i,j] = int.Parse(Console.ReadLine()!);
        
    }
       return input;
}

int[,] createArray2()
{
    int[,] input = new int[2,2];
    for (int n = 0; n < 2; n++)
    for (int m = 0; m < 2; m++)
    {
        Console.Write($"Введите число поз. {n},{m} = ");
        input[n,m] = int.Parse(Console.ReadLine()!);
        
    }
        return input;
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

void MultiplyMatrix(int[,] matrix1, int[,] matrix2, int[,] result)
{
  for (int i = 0; i < result.GetLength(0); i++)
  {
    for (int j = 0; j < result.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < matrix1.GetLength(1); k++)
      {
        sum += matrix1[i,k] * matrix2[k,j];
      }
      result[i,j] = sum;
    }
  }
}

Console.WriteLine("Первая матрица:");
int[,] matrix1 = createArray1();
PrintArray(matrix1);
Console.WriteLine();
Console.WriteLine("Вторая матрица");
int[,] matrix2 = createArray2();
PrintArray(matrix2);
int[,] result = new int[2, 2];
MultiplyMatrix(matrix1, matrix2, result);
Console.WriteLine("Произведение матриц:");
PrintArray(result);



