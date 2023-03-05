using static methods.Methods;

namespace task46;
class Program

// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1
{
    static void Main(string[] args)
    {
        int rows = ReadNumber("Input rows count: ");
        int columns = ReadNumber("Input columns count: ");

        int[,] array = new int[rows, columns];

        array = GetFilledRandomMatrix(array);
        PrintMatrix(array);
    }
}
