using static methods.Methods;

namespace task60;
class Program
// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно
// выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)
{
    static void Main(string[] args)
    {
        int[,,] cube = GetRandomCube(5, 5, 5, 0, 10);
        PrintCube(cube);
    }
}
