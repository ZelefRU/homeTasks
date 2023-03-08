using static methods.Methods;

namespace task56;
class Program

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
{
    static void Main(string[] args)
    {
        int[,] matrix = GetRandomMatrix(4, 5, 0, 10);
        PrintMatrix(matrix);
        Print("--------\n");
        int minIndex = GetSumMinRowMatrix(matrix);
        Print($"\nRow with min sum: №{minIndex + 1}");
    }
}
