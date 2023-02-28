// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

using methods;

namespace task38;
class task38
{
    static void Main(string[] args)
    {
        Methods m = new Methods();
        int[] taskArray = m.RandomArray(5, 1 , 99);
        (int dif, int min, int max) = m.DifMaxMin(taskArray);
        m.PrintArray(taskArray);
        m.Print($"\nMax in array {max} - min array {min} = {dif}");
    }
}

