// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

using static methods.Methods;

namespace task38;
class task38
{
    static void Main(string[] args)
    {
        int[] taskArray = RandomArray(5, 1 , 99);
        (int dif, int min, int max) = DifMaxMin(taskArray);
        PrintArray(taskArray);
        Print($"\nMax in array {max} - min array {min} = {dif}");
    }
}

