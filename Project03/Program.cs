//Задача сумма чисел по диагонали
int rows=7;
int columns=5;
int len = rows < columns ? rows : columns;//тоже самое что if
int[,] array = GetArray(rows, columns);
PrintArray(array);
int sum = 0;
for (int i = 0; i < len; i++) 
{
    sum += array[i,i];
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
System.Console.WriteLine(sum + " Сумма чисел по диагонали");
//double = a GetRandomNumber(11,215)
// double GetRandomNumber(double minimum, double maximum)
// {
//     Random random = new Random();
//     return Math.Round(random.NextDouble() * (maximum - minimum) + minimum,2);
// }
// double GetRandomNumber(double minimum, double maximum)
// {
//     return Math.Round(new Random().NextDouble() * (maximum - minimum) + minimum,2);
// }
