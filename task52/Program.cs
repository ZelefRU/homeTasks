using static methods.Methods;

namespace task52;
class Program
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
{
    static void Main(string[] args)
    {
        
        int[,] array = new int[5,5];
        array = GetRandomMatrix(5, 5);
        Print("----ARRAY----\n");
        PrintMatrix(array);

        for (int i = 0; i < array.GetLength(1); i++)
        {
            Print($"{i} column average: {MatrixColumnsAverage(array, i)}\n");
        }
        
    }
}
