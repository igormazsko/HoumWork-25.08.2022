// Задача 47. Задайте двумерный массив размером m*n, заполненный случайными вещественными числами
using static System.Console;
using System.Linq;
Clear();

Write("Введите количество строк в матрице m= ");
int m = int.Parse(ReadLine());
Write("Введите количество столбцов в матрице n= ");
int n = int.Parse(ReadLine());
double[,]matrix= new double [m, n];
FillMassRandomNambers(matrix);
PrintMatrixArray(matrix);
WriteLine();


// Метод заполнения двухмерного массива случайными вещественными числами
void FillMassRandomNambers (double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().NextDouble()*100;
        }
    }
}

// Метод печати двухмерного массива заполненного вещественными значениями
void PrintMatrixArray(double [,] inArray)
{
    for (int i = 0; i<inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{Math.Round(inArray [i,j],2)} ");
        }
        WriteLine();
    }
}