using methods;

namespace task29;
class Program
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
{
    static void Main(string[] args)
    {
        Methods m = new Methods();
        
        m.Print("Input numbers like \"1, 2, 3, 4\": ");
        string stringInt = Console.ReadLine();
        int[] array = stringInt.Split(", ").Select(x => int.Parse(x)).ToArray();
        m.Print($"[ {string.Join(", ", stringInt)} ]");
    }
}





