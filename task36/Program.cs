// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


using methods;

namespace task36;
class task36
{
    static void Main(string[] args)
    {
        Methods m = new Methods();
        
        int[] numbersArray = m.RandomArray(5, 1, 10);
        m.PrintArray(numbersArray, "Our array: ");
        int sumNumbers = m.SumUneven(numbersArray);
        m.Print($"\nOur sum: {sumNumbers}");
    }
}