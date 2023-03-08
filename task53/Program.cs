using static methods.Methods;

namespace task53;
class Program

// Задача 53: Задайте двумерный массив. Напишите
// программу, которая поменяет местами первую и
// последнюю строку массива.
{
    static void Main(string[] args)
    {
        int[,] matrix = GetRandomMatrix(5, 5, 0, 10);
        PrintMatrix(matrix);
        Print("\n\n");
        
        matrix = SwapMatrixLastFirst(matrix);
        PrintMatrix(matrix);
    }
}
