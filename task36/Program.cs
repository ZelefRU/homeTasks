// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


using static methods.Methods;

namespace task36;
class task36
{
    static void Main(string[] args)
    {
        
        int[] numbersArray = RandomArray(5, 1, 10);
        PrintArray(numbersArray, "Our array: ");
        int sumNumbers = SumUneven(numbersArray);
        Print($"\nOur sum: {sumNumbers}");
    }
}