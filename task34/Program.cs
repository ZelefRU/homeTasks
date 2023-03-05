using static methods.Methods;

namespace task34;
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
class task34
{
    static void Main(string[] args)
    {
        int[] randomArray = RandomArray(4, 100, 999);
        Print($"Out array: [{string.Join(", ", randomArray)}]");
        int evenCount = EvenNumber(randomArray);
        Print($"\nEven count: {evenCount}");
    }
}