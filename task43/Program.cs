using static methods.Methods;

namespace task43;
class Program

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
{
    static void Main(string[] args)
    {
        Print("First line: y = k1 * x + b1,\nSecond line: y = k2* x + b2\n\n");
        int b1 = ReadNumber("Input b1: ");
        int k1 = ReadNumber("Input k1: ");
        int b2 = ReadNumber("Input b2: ");
        int k2 = ReadNumber("Input k2: ");

        if (k1 == k2 || b1 == b2)
        {
            Print("Error");
        }
        
        if((b2-b1)%(k1-k2) == 0)
        {
            int x = (b2-b1)/(k1-k2);
            int y = k1 * x + b1;
            Print($"b1:{b1} k1:{k1} b2:{b2} k2:{k2} -> {x}:{k1 * x + b1}");
        } 
        else 
        {
            double x = (double)(b2-b1)/(k1-k2);
            double y = (double)(k1 * x + b1);
            Print($"b1:{b1} k1:{k1} b2:{b2} k2:{k2} -> {x}:{y}");
        }
    }
}


