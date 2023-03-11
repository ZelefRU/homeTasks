using static methods.Methods;

namespace task67;
class Program
// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9
{
    static void Main(string[] args)
    {
        int sum = RecursionSumNumbers(45);
        Print($"{sum}");
    }
}
