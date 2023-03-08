using static methods.Methods;

namespace task55;
class Program

// Задача 55: Задайте двумерный массив. Напишите
// программу, которая заменяет строки на столбцы. В
// случае, если это невозможно, программа должна
// вывести сообщение для пользователя.

{
    static void Main(string[] args)
    {
        int[,] matrix = GetRandomMatrix(5, 9, 0, 10);
        PrintMatrixColor(matrix);
        Print("\n\n\n");
        matrix = RotateMatrix(matrix);
        PrintMatrixColor(matrix);

    }
}
