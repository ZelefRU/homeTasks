using static methods.Methods;

namespace task49;
class Program

// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// (в примере подсчет индексов начинается с 1 , как в математике)
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть
// вот так:
// 1 4 7 2
// 5 81 2 9
// 8 4 2 4
{
    static void Main(string[] args)
    {
        int rows = ReadNumber("Input rows count: ");
        int columns = ReadNumber("Input columns count: ");

        int[,] array = new int[rows, columns];
        
        array = GetRandomMatrix(array, 1, 9);
        Print("----NORAML----\n");
        PrintMatrix(array);

        array = GetDoubleUnevenIndexes(array);
        Print("----NEW----\n");
        PrintMatrix(array);
    }
}
