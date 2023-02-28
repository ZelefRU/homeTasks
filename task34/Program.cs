using methods;
namespace task34;
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
class task34
{
    static void Main(string[] args)
    {
        Methods m = new Methods();

        int[] randomArray = m.RandomArray(4, 100, 999);
        m.Print($"Out array: [{string.Join(", ", randomArray)}]");
        int evenCount = m.EvenNumber(randomArray);
        m.Print($"\nEven count: {evenCount}");
    }
}