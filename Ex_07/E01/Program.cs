// E01 Написать программу, упорядочивания по убыванию элементов каждой строки двумерного массива.

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

void ArrangeRows(int[,] array)                                  // Метод сортировки массива по строкам.
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            int minPosition = j;            
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if (array[i, k] < array[i, minPosition])
                    minPosition = k;
            }
            int temp = array[i, j];
            array[i, j] = array[i, minPosition];
            array[i, minPosition] = temp;
        }
    }
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
Console.WriteLine("Отсортированный массив: ");
ArrangeRows(matrix);
PrintArray(matrix);
