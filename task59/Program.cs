using static methods.Methods;
namespace task59;
class Program
// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим
// следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7
{
    static void Main(string[] args)
    {
        int[,] matrix = GetRandomMatrix(4, 4, 0, 10);
        PrintMatrix(matrix);
        Print("\n");
        // int[] minIndex = GetMinMatrixIndex(matrix);
        // PrintArray(minIndex);
        // int minValue = GetMinMatrixValue(matrix);
        // Print($"{minValue}\n");

        matrix = RemoveMinColumnAndRow(matrix);
        PrintMatrix(matrix);
    }
}
