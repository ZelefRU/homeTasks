namespace methods;

public static class Methods
{
    private static void Main()
    {
    }

    public static void Print(string printMessage)
    {
        Console.Write(printMessage);
    }

    public static void Wait(int waitTime)
    {
        Thread.Sleep(waitTime);
    }

    public static (int, int, int) DifMaxMin(int[] array)
    {
        var max = array[0];
        var min = array[0];
        for (var i = 0; i < array.Length; i++)
            if (array[i] < min)
                min = array[i];
            else if (array[i] > max) max = array[i];
        return (max - min, min, max);
    }

    public static int DifMaxMinShort(int[] array)
    {
        var max = array[0];
        var min = array[0];
        for (var i = 0; i < array.Length; i++)
            if (array[i] < min)
                min = array[i];
            else if (array[i] > max) max = array[i];
        return max - min;
    }

    public static void PrintArray(int[] array, string message = "\nOur array: ")
    {
        Print($"{message} [{string.Join(", ", array)}]");
    }

    public static int ReadNumber(string messageToUser)
    {
        Print(messageToUser);
        return int.Parse(Console.ReadLine() ?? string.Empty);
    }

    public static int[] IntToArray(int n)
    {
        if (n == 0) return new int[1] { 0 };

        var digits = new List<int>();

        for (; n != 0; n /= 10)
            digits.Add(n % 10);

        var array = digits.ToArray();
        Array.Reverse(array);
        return array;
    }

    public static int[] RandomArray(int lenght, int leftRange, int rightRange)
    {
        var array = new int[lenght];
        for (var i = 0; i < lenght; i++) array[i] = Random.Shared.Next(leftRange, rightRange + 1);
        return array;
    }

    public static (int, int) SumPlusMinusNum(int[] array)
    {
        var sumPlus = 0;
        var sumMinus = 0;

        for (var i = 0; i < array.Length; i++)
            if (array[i] > 0)
                sumPlus += array[i];
            else if (array[i] < 0) sumMinus += array[i];
        // else Print("\nCatch 0 or error");
        return (sumPlus, sumMinus);
    }
    public static int EvenNumber(int[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                Print($"\n{array[i]} - even");
                count++;
            }
        }

        return count;
    }
    
    public static int SumUneven (int[] array) {
        int sum = 0;
        for(int i = 1; i < array.Length; i += 2) {
            sum += array[i];
        }
        return sum;
    }
    
    public static int[,] GetRandomMatrix(int rows, int columns, int leftBorder = 0, int rightBorder = 10)
    {

        int[,] matrix = new int[rows, columns];

        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = Random.Shared.Next(leftBorder, rightBorder + 1);
            }
        }

        return matrix;
    }

    public static void PrintMatrix(int[,] matrix)
    {
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
    
    public static void PrintMatrix(double[,] matrix)
    {
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(Math.Round(matrix[i, j], 2) + " ");
            }
        }
        Console.WriteLine();
    }
    
    public static void PrintMatrixXO(int[,] matrix)
    {
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] == 1)
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.White;
                    Print("X ");
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else if (matrix[i, j] == 2)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.White;
                    Print("O ");
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.ForegroundColor = ConsoleColor.White;
                    Print("▉ ");
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            Console.WriteLine();
        }
    }

    
    public static void PrintMatrix(int[][] matrix)
    {
        for(int i = 0; i < matrix.Length; i++)
        {
            for(int j = 0; j < matrix[0].Length; j++)
            {
                Console.Write(matrix[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
    
    public static int[,] GetFebonacciMatrix(int rows, int columns, int leftBorder = 0, int rightBorder = 10)
    {
        int[,] matrix = new int[rows, columns];
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++, matrix[i, j] = i + j);
        }
        return matrix;
    }

    public static int[,] GetFilledMatrix(int number, int rows = 3, int columns = 3)
    {
        int[,] matrix = new int[rows,columns];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                matrix[i, j] = number;
            }
        }

        return matrix;
    }
    
    public static int[,] GetFilledRandomMatrix(int[,] matrix)
    {

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = Random.Shared.Next(0, 100);
            }
        }

        return matrix;
    }
    public static int[,] GetFilledRandomMatrix(int[,] matrix, int min, int max)
    {

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = Random.Shared.Next(min, max + 1);
            }
        }

        return matrix;
    }
    
    public static double[,] GetFilledRandomMatrix(double[,] matrix, int min, int max)
    {

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = Random.Shared.NextDouble()* max - min;
            }
        }

        return matrix;
    }
    
    public static int[,] GetDoubleUnevenIndexes(int[,] matrix)
    {

        for (int i = 1; i < matrix.GetLength(0); i += 2)
        {
            for (int j = 1; j < matrix.GetLength(1); j += 2)
            {
                matrix[i, j] *= matrix[i, j];
            }
        }

        return matrix;
    }

    public static int[] GetMatrixIndexes(int number, int rows, int columns)
    {
        int[] array = new int[2];
        int rowIndex = 0;
        int columnIndex = number > 1 ? (number - 1)  % columns:0;
        for (int i = 0; number > rows; i++, rowIndex++)
        {
            number -= rows;

        }

        array[0] = rowIndex;
        array[1] = Math.Abs(columnIndex);
        return array;
    }

    public static int GetDiagonalSum(int[,] matrix)
    {
        int sum = 0;

        for (int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1); i++)
        {
            sum += matrix[i, i];
        }

        return sum;
    }
    public static int GetDiagonalMatrixSimilarCountLeftRight(int number, int[,] matrix)
    {
        int count = 0;

        for (int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1); i++)
        {
            if (matrix[i, i] == number)
            {
                count++;
                
            }
        }

        return count;
    }
    public static int GetDiagonalMatrixSimilarCountRightLeft(int number, int[,] matrix)
    {
        int count = 0;
        
        for (int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1); i++)
        {
            if (matrix[i, matrix.GetLength(1) -1 - i] == number)
            {
                count++;
            }
        }

        return count;
    }

    public static int GetVerticalMatrixSimilarCount(int number, int column, int[,] matrix)
    {
        int count = 0;

        for (int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1); i++)
        {
            if (matrix[i, column] == number)
            {
                count++;
            }
        }

        return count;
    }
    public static int GetHorizontalMatrixSimilarCount(int number, int row, int[,] matrix)
    {
        int count = 0;

        for (int i = 0; i < matrix.GetLength(0) && i < matrix.GetLength(1); i++)
        {
            if (matrix[row, i] == number)
            {
                count++;
            }
        }

        return count;
    }
    
    public static float Factorial(int number)
    {
        float i, x = 1;
        for (i = 1; i <= number; i++)
        {
            x *= i;
        }
        return x;
    }
    
    public static int[][] PasTri(int n) {
        int[][] result = new int[n][];
        result [0] = new int[] { 1 };
        for (int i = 1; i < n; i++) {
            result [i] = new int[i + 1];
            int left = 0;
            for (int j = 0; j < i; j++) {                                       
                result [i][j] = result [i - 1] [j] + left;
                left = result [i - 1] [j];
            }
            result [i] [i] = left;
        }
        return result;
    }

    public static double MatrixColumnsAverage(int[,] matrix, int column)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            sum += matrix[i, column];
        }

        return sum / matrix.GetLength(0);
    }
    
    
}
// public class M {
//     public void Print(string printMessage) { Console.Write(printMessage); }
//     public void PrintS(string printMessage) { Console.Write(printMessage); }
//     public void PrintN(int printNumber) { Console.Write(printNumber); }
//     public void PrintSL(string printMessage) { Console.WriteLine(printMessage); }
//     public void PrintNL(int printNumber) { Console.WriteLine(printNumber); }
//     public void Wait(int waitTime) { System.Threading.Thread.Sleep(waitTime); }
//     public void PrintArray (int[] array, string message) {
//         new M().Print($"{message} [{string.Join(", ", array)}]");
//         // return message + string.Join(", ", array);
//         // return Print($"{message} [{string.Join(",", array)}]");
//     }

// public int[] RandomArray (int lenght, int leftRange, int rightRange) {
//
//     int[] array = new int[lenght];
//     for (int i = 0; i < lenght; i++) {
//         array[i] = Random.Shared.Next(leftRange, rightRange + 1);
//     }
//     return array;
// }
//
// public int EvenNumber (int[] array) {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++) {
//         if (array[i] % 2 == 0) {
//             count++;
//         }
//         i++;
//     }
//     return count;
// }