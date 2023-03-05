using static methods.Methods;

namespace task42;
class Program
// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10
{
    static void Main(string[] args)
    {
        String DecToDual(int number)
        {
            string result = "";
            for (int i = 0; 1 <= number; i++, number /= 2)
            {
                result = Convert.ToString(number % 2) + result;
            }
            return result;
        }

        String test = DecToDual(56);
        Print($"\n\n\n{test}");
    }
}
