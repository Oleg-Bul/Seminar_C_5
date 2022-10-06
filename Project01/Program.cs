//Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле:
// Aₘₙ = m+n. Выведите полученный массив на экран.


int matrX = ReadData("Ввведите размер M ");
int matrY = ReadData("Введите размер N ");
int[,] matrix = new int[matrX, matrY];
void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) 
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}


int ReadData(string msg)
{
    Console.Write(msg);
    int number = int.Parse(Console.ReadLine());
    return number;
}

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrX; i++)
    {
      for (int j = 0; j < matrY; j++)
        matrix [i,j] = i+j;
    }
}
FillArray(matrix);
PrintArray(matrix);