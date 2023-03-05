using static methods.Methods;

namespace task47;
class Program

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
{
    static void Main(string[] args)
    {
        int rows = ReadNumber("Input rows count: ");
        int columns = ReadNumber("Input columns count: ");

        int[,] array = new int[rows, columns];
        
        array = GetFilledRandomMatrix(array, -10, 10);
        Print("----NORAML----\n");
        PrintMatrix(array);
    }
}
