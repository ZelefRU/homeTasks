using static methods.Methods;
namespace task69;
class Program
// Задача 69: Напишите программу, которая на вход принимает два
// числа A и B, и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8
{
    static void Main(string[] args)
    {
        int sqrt = RecursionSqrtNumbers(3, 5);
        Print($"\n{sqrt}");
    }
}
