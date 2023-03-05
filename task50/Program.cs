using static methods.Methods;

namespace task50;
class Program

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет
{
    static void Main(string[] args)
    {

        int[,] array = new int[5,5];
        array = GetRandomMatrix(5, 5);
        Print("----ARRAY----\n");
        PrintMatrix(array);
        
        int rows = ReadNumber("Input row index: ");
        int columns = ReadNumber("Input column index: ");
        
        if (rows > array.GetLength(0) -1 || columns > array.GetLength(1) - 1)
        {
            Print("\n\nOut of index error.");
        }
        else
        {
            Print($"\nYour number: {array[rows,columns]}");
        }
    }
}
