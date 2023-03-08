using System.ComponentModel.DataAnnotations;
using static methods.Methods;

namespace task57;
class Program

// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.
{
    static void Main(string[] args)
    {
        int[,] matrix = GetRandomMatrix(3, 3, 0, 100);
        PrintMatrix(matrix);

        // int maxMatrix = GetMaxMatrixValue(matrix);
        // Print($"{maxMatrix}");
        
        Print("\n");
        matrix = GetCountNumberInMatrix(matrix);
        // PrintMatrix(matrix);
        PrintMatrixCountTask(matrix);
    }

}
