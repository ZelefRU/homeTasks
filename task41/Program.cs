using static methods.Methods;

namespace task41;
class Program
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
// задача от преподавателя)
// Пользователь вводит с клавиатуры неопределенное количество чисел (while (true)). Посчитайте, сколько чисел больше 0
// ввёл пользователь. Ввод чисел останавливается при помощи ввода слова "stop"
{
    static void Main(string[] args)
    {
        int count = 0;
        Print("Ready to start? Print y or stop: ");
        while (Console.ReadLine().ToLower().Equals("stop") == false)
        {
            Print("Input number: ");
            if (Convert.ToInt32(Console.ReadLine()) > 0)
            {
                count++;
            }
            Print("For another number input y or stop for end: ");
        }
        Print($"Numbers > 0: {count}");
        // if (Console.ReadLine().ToLower().Equals("stop"))
        // {
        //     m.Print($"Numbers > 0: {count}");
        // }
        // else
        // {
        //     if (Convert.ToInt32(Console.ReadLine()) > 0)
        //     {
        //         count++;
        //     }
        //     m.Print("Input another number or \"Stop\" for end: ");
        // }
    }
}
