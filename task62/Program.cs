using static methods.Methods;
namespace task62;
class Program
//
// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1  2  3  4
// 12 13 14 5
// 11 16 15 6
// 10 9  8  7

//00 01 02 03
//13 23 33
//32 31 30
//20 10
//11 12
//22 21

//1  2  3  4  5
//16 17 18 19 6
//15 24 25 20 7
//14 23 22 21 8
//13 12 11 10 9

//00 01 02 03 04
//14 24 34 44
//43 42 41 40
//30 20 10
//11 12 13
//23 33
//32 31
//21 22

{
    static void Main(string[] args)
    {
        int[,] spiralMatrix = GetSpiralMatrix(25, 25);
        PrintMatrixColor(spiralMatrix);
        


    }
}
