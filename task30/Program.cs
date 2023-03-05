using static methods.Methods;

namespace task30;
class Program
//Задача 30: Напишите программу, которая выводит массив из 8
//элементов, заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]
{
    static void Main(string[] args)
    {
        int[] taskArray = new int[8];
        for (int i = 0; i < taskArray.Length; i++) {
            taskArray[i] = Random.Shared.Next(0,2);
            // Print(i == taskArray.Length -1 ? $"{taskArray[i]}":
            //     $"{taskArray[i]}, ");
        }
        Print($"[ {string.Join(", ", taskArray)} ]");
    }
}



