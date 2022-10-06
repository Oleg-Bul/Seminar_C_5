using System;
//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные,
// и замените эти элементы на их квадраты.

int rows=5;
int columns=5;

int[,] array = GetArray(rows, columns);
PrintArray(array);

for (int i = 1; i < rows; i++) 
{
    for (int j = 1; j < columns; j++)
    {
        if(i % 2 == 0 && j % 2 == 0){
            array[i,j] *= array[i,j];
        }
    }
}
System.Console.WriteLine("Готовый вариант");
PrintArray(array);



int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++) 
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(1,10);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]}\t"); // \t делает ровные столбцы
        }
        Console.WriteLine();
    }
}