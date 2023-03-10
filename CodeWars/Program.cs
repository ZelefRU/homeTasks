using static methods.Methods;

namespace CodeWars;
class Program
///////CODE WARS ///////////////
// "1999" --> "20th"
// "2011" --> "21st"
// "2154" --> "22nd"
// "2259" --> "23rd"
// "1124" --> "12th"
// "2000" --> "20th"
{
    public static string WhatCentury(string year)
    {
      double numberCeiling = Math.Ceiling(double.Parse(year) / 100);
      Print($"{numberCeiling}\n");
      string ends = "";
      if (numberCeiling > 20 && numberCeiling % 10 == 1) {
          ends = "st";
      }
      else if (numberCeiling > 20 && numberCeiling % 10 == 2) {
          ends = "nd";
      }
      else if (numberCeiling > 20 && numberCeiling % 10 == 3) {
          ends = "rd";
      }
      else {
          ends = "th";
      }
      return $"{numberCeiling}{ends}";
    }

    static void Main(string[] args)
    {
        int ReadNumber(string messageToUser) 
        {
            Console.WriteLine(messageToUser);
            int value = Convert.ToInt32(Console.ReadLine());
            return value;
        }

        int[,] GetRandomMatrix(int rows, int columns, int leftBorder = 0, int rightBorder = 10) 
        {
            int[,] matrix = new int[rows, columns]; 

            for (int i = 0; i < matrix.GetLength(0); i++) 
            {
                for (int j = 0; j < matrix.GetLength(1); j++) 
                {
                    matrix[i, j] = Random.Shared.Next(leftBorder, rightBorder + 1); // обращаемся к нашему элементу по i и j создаем 
                    //рандомные значения, задав диапазон
                }
            }
            return matrix;
        }

        void MatrixSquare(int[,] matrix, int row, int column) // снова создаем метод который будет определять нечетность элементов по индексу и строке
        {
            // for (int i = 0; i < matrix.GetLength(0); i++)
            // {
            //     for (int j = 0; j < matrix.GetLength(1); j++)
            //         if (i >= matrix.GetLength(0) || j >= matrix.GetLength(0)) // проверка условия
            //         {
            //             Console.WriteLine("Такого элемента в матрице нет");
            //         }
            //         else
            //         {
            //             Console.WriteLine($"значение элемента равно {matrix[i,j]}");
            //         }
            // }
            if (row >= matrix.GetLength(0) || column >= matrix.GetLength(0)) // проверка условия
            {
                Console.WriteLine("Такого элемента в матрице нет");
            }
            else
            {
                Console.WriteLine($"значение элемента равно {matrix[row, column]}");
            }
        }

        void PrintMatrix(int[,] matrix) // метод PrintMatrix печатающий нашу матрицу на экран
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " "); // выводим матрицу на экран
                }
                Console.WriteLine(); // после обработки сроки по вышеуказанному циклу и до перехода к следующей выводим обработанную строку
            }
        }

        int rowsCount = ReadNumber("Введите колличество строк:");
        int columnsCount = ReadNumber("Введите колличество столбцов:");
        int userRow = ReadNumber("Введите индекс строки нужного элемента");
        int userColumn = ReadNumber("Введите индекс стобца нужного элемента");

        int[,] myMatrix = GetRandomMatrix(rowsCount, columnsCount); 

        PrintMatrix(myMatrix); // вызываем метод по распечатке и распечатываем получившуюся матрицу
        Console.WriteLine(); // делаем строчку чтоб выведенные матрицы не сливались

        MatrixSquare(myMatrix, userRow, userColumn); // вызываем метод по поиску нашего элемента в матрице
    }
}




// public class Kata
// {
//   public static string WhatCentury(string year)
//   {
//     double numberCeiling = Math.Ceiling(double.Parse(year) / 100);
//     string ends = "";
//     if (numberCeiling % 10 == 1) {
//         ends = "st";
//     }
//     else if (numberCeiling % 10 == 2) {
//         ends = "nd";
//     }
//     else if (numberCeiling % 10 == 3) {
//         ends = "rd";
//     }
//     else {
//         ends = "th";
//     }
//     return $"{numberCeiling}{ends}";
//   }
// }

// static string WhatCentury(string year)
//   {
//     double numberCeiling = Math.Ceiling(double.Parse(year) / 100);
//     string end = numberCeiling % 10 == 1 ? "st":
//         numberCeiling % 10 == 2 ? "nd":
//         numberCeiling % 10 == 3 ? "rd":
//         "th";
//     return $"{numberCeiling}{end}";
//   }


// static string WhatsCentury(string year)
//   {
//     double numberCeiling = Math.Ceiling(double.Parse(year) / 100);
//     string end = numberCeiling % 10 == 1 ? "st":
//         numberCeiling % 10 == 2 ? "nd":
//         numberCeiling % 10 == 3 ? "rd":
//         "th";
//     return $"{numberCeiling}{end}";
//   }

// // Print("Input: ");
// // string myYear = WhatCentury(Console.ReadLine());
// // Print($"{myYear}");

// Print("Input: ");
// double inputData = double.Parse(Console.ReadLine());
// double a = inputData / 100;
// double aCeiling = Math.Ceiling(a);
// double one = aCeiling % 10;
// Console.WriteLine(a);
// Print($"{aCeiling} \n {one}");