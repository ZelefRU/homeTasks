using static methods.Methods;

namespace task33;
class Program
// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да
{
    static void Main(string[] args)
    {
        int[] newArray = RandomArray(20, -9, 9);
        Print($"[{string.Join(", ", newArray)}]");
        Print("Input number: ");
        int userNmber = int.Parse(Console.ReadLine());
        int count = 0;
        for (int i = 0; i < newArray.Length; i++) {
            if (newArray[i] == userNmber) {
                count++;
            }
        }
        if (count == 0) {
            Print("no");
        }
        else{
            Print($"In this array {count} number");
        }
    }
}




