using static methods.Methods;

namespace task27;
class Program
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
{
    static void Main(string[] args)
    {
        Print("Input number: ");

        int userNumber = int.Parse(Console.ReadLine());
        int[] arr = IntToArray(userNumber);
        int result = 0;
        for (int i = 0; i < arr.Length; i++) {
            result += arr[i];
        }
        Print($"[ {string.Join(", ", arr)} ]");
        Print($"\n {result}");
    }
}



