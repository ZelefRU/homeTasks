using static methods.Methods;

namespace task26;
class Program
// Задача 26:
// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

// 456 -> 3
// 78 -> 2
// 89126 -> 5
{
    static void Main(string[] args)
    {
        int inputData = Math.Abs(ReadNumber("Input number: ")), count = 1;
        for (; inputData >= 10; count++) {inputData /= 10;}
        Print($"Numbers count: {count}");
    }
}



