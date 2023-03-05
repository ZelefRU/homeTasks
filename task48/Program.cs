using static methods.Methods;

namespace task48;
class Program
// Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5
{
    static void Main(string[] args)
    {

        int[,] someArray = GetFebonacciMatrix(4, 4);
        PrintMatrix(someArray);
        
    }
}
