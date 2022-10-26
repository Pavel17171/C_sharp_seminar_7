// E03 В прямоугольной матрице найти строку с наименьшей суммой элементов.

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

void RowMinSum(int[,] array)                             // Метод замены строк на столбцы.
{
    int minSum = 0;
    int indexRow = 0;
    for (int j = 0; j < array.GetLength(1); j++)         // Находим сумму элементов первой строки
        minSum += array[0, j];
    for (int i = 1; i < array.GetLength(0); i++)         // Находим сумму элементов остальных строк и сравниваем
    {
        int sumRow = 0;
        for (int j = 0; j < array.GetLength(1); j++)
            sumRow += array[i, j];
        if (minSum > sumRow)
        {    
            minSum = sumRow;
            indexRow = i;
        }
    }
    for (int j = 0; j < array.GetLength(1); j++)        // Выводим строку с минимальной суммой элементов на экран
        Console.Write($"{array[indexRow, j]} ");
    
}

Console.WriteLine("Задаем размер двумерного массива");
Console.Write("Введите количество строк: ");
int row = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столбцов: ");
int column = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine();

int[,] matrix = new int[row, column];

Console.WriteLine("Исходный массив: ");
FillArray(matrix);
PrintArray(matrix);

Console.WriteLine();
Console.WriteLine("Строка с минимальной суммай элементов: ");
RowMinSum(matrix);