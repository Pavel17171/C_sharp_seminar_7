// E02 Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).

void PrintArray(int[,] array)                                   // Печать массива.
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console. Write($"{array[i, j]} ");
    Console.WriteLine();
    }
    
}

void FillArray(int[,] array)                                    // Заполнение массива.
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        } 
    }
}

void ReplaceRowColumn(int[,] array)                             // Метод замены строк на столбцы.
{
    if (array.GetLength(0) == array.GetLength(1))
    {
        int temp;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = i; j < array.GetLength(1); j++)
            {
                temp = array[i , j];
                array[i, j] = array[j, i];
                array[j, i] = temp;
            }
        }
    }
    else
    {
        Console.WriteLine("Ошибка: матрица не квадратная!");
    }
}

Console.WriteLine("Задаем размер двумерного массива");
Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов: ");
int column = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();

int[,] matrix = new int[row, column];

if (row == column)
{
    Console.WriteLine("Исходный массив: ");
    FillArray(matrix);
    PrintArray(matrix);

    Console.WriteLine();
    Console.WriteLine("Измененный массив: ");
    ReplaceRowColumn(matrix);
    PrintArray(matrix);
}
else
{
    ReplaceRowColumn(matrix);
}