// Задача 52. Задайте двухмерный массив из целых чисел. Найдите среднее арифьетическое элементов в каждом столбце. апример задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
using static System.Console;
using System.Linq;
Clear();
WriteLine("Hello, World!");
Write("Введите количество строк в матрице: ");
int a = int.Parse(ReadLine());
Write("Введите количество столбцов в матрице: ");
int b = int.Parse(ReadLine());
Write("Введите минимальное значение которое может принимать матрица: ");
int c = int.Parse(ReadLine());
Write("Введите максимальное значение которое может принимать матрица: ");
int d = int.Parse(ReadLine());
int[,]array1= GetTabl (a, b, c, d);
PrintMatrixArray(array1);
WriteLine();
for (int i=0; i<array1.GetLength(1); i++)
    {
        double sum = 0;
        for(int j=0; j<array1.GetLength(0); j++)
        {
        sum += array1[j,i];
        }
        double average = sum / (array1.GetLength(0));
        WriteLine($"Среднее арифметическое столбца № {i+1} {average}");
    } 

// Метод заполнения двухмерного массива случайными числами
int [,] GetTabl (int rows, int columns, int minVaiue, int maxValue)
{
    int [,] resuit = new int [rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            resuit[i,j] = new Random().Next(minVaiue, maxValue+1);
        }
    }
    return resuit;
}
// Метод печати двухмерного массива
void PrintMatrixArray(int [,] inArray)
{
    for (int i = 0; i<inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray [i,j]} ");
        }
        WriteLine();
    }
}

// Метод нахождения среднего арифметического в столбце и записи их в строку
// void ArethmeticMeanColumn(int[,] arr)
// {
//     for (int i=0; i<arr.GetLength(1); i++)
//     {
//         double sum = 0;
//         for(int j=0; j<arr.GetLength(0); j++)
//         {
//         sum += arr[i.j];
//         }
//         double average = Math.Round(sum / (arr.GetLength(0)+1));
//         WriteLine($"Среднее арифметическое столбца № {i+1} {average}")
//     } 
// }