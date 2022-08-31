// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двухмерном массиве, и возвращает значение этого элемента или же 
// указание, что такого элемента нет
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
Write("Введите номер строки для поиска элемента: ");
int f = int.Parse(ReadLine());
Write("Введите номер колонки для поиска элемента: ");
int k = int.Parse(ReadLine());
PozisitionNamber(array1, f, k);
WriteLine();
Write("Введите число которое хотите найти в массиве: ");
int n = int.Parse(ReadLine());
NamberPositionPrint(array1, n);
WriteLine();

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

// Метод поиска элемента по заданной позиции
void PozisitionNamber(int[,] arr, int indexRow, int indexColumn)
{
    if (indexRow>arr.GetLength(0) | indexColumn>arr.GetLength(1))
    {
        WriteLine($"Позиции - строка № {indexRow}, колонка № {indexColumn} в массиве нет");
    }
    else
    {
        WriteLine($"На запрашиваемой позиции находится число {arr[indexRow-1,indexColumn-1]}");
    }
}

// Метод поиска позиции по заданному числу
void NamberPositionPrint(int[,] coll, int namb)
{
    for(int i=0; i<coll.GetLength(0); i++)
    {
        for(int j=0; j<coll.GetLength(1); j++)
        {
            if (coll[i,j]==namb)
            {
                WriteLine($"Число {namb} в строке № {i+1}, колонке {j+1}");
            }
        }
    }
}
