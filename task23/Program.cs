using static methods.Methods;

namespace task23;
class Program
// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
{
    static void Main(string[] args)
    {
        Print("Input number from 1: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if ( number < 1 ) {
            Print("\nError. Ur num less than 1");
        }
        else {
            for (int i = 1; i < number + 1; i++) {
                Console.WriteLine(i * i * i);
            }
        }
    }
}




