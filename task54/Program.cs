using static methods.Methods;
namespace task54;
class Program
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8
{
    static void Main(string[] args)
    {
        int[,] matrix = GetRandomMatrix(4, 4, 0, 10);
        PrintMatrix(matrix);
        Print("---SORTED---\n");
        matrix = GetSortedMatrix(matrix);
        PrintMatrix(matrix);
    }
}
