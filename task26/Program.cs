using methods;

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
        Methods m = new Methods();
        
        int inputData = Math.Abs(m.ReadNumber("Input number: ")), count = 1;
        for (; inputData >= 10; count++) {inputData /= 10;}
        m.Print($"Numbers count: {count}");
    }
}



