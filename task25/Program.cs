using methods;

namespace task25;
class Program
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
{
    static void Main(string[] args)
    {
        Methods m = new Methods();
        m.Print("Input A number: ");
        int numberA = int.Parse(Console.ReadLine());
        m.Print("Input B number: ");
        int numberB = int.Parse(Console.ReadLine());
        int result = 1;
        for (int i = 1; i < numberB + 1; i++) {
            result = numberA * result;
        }
        m.Print($"{result}");
        
    }
}


