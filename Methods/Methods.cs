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
        if (n == 0) return new[] { 0 };

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
        Print("\n");
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
    
    public static void PrintMatrixColor(int[,] matrix)
    {
        int max = GetMaxMatrixValue(matrix);
        Print("\n");
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > Math.Round((max * 91.05 / 100)))
                {
                    // Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Write(matrix[i, j] + "\t");
                }
                else if (matrix[i, j] <= Math.Round((max * 91.05 / 100)) &&
                        matrix[i, j] > Math.Round((max * 73.55 / 100)))
                {
                    // Console.BackgroundColor = ConsoleColor.DarkYellow;
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.Write(matrix[i, j] + "\t");
                }
                else if (matrix[i, j] <= Math.Round((max * 73.55 / 100)) &&
                         matrix[i, j] >= Math.Round((max * 53.05 / 100)))
                {
                    // Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(matrix[i, j] + "\t");
                }
                else if (matrix[i, j] < Math.Round((max * 53.05 / 100)) &&
                         matrix[i, j] >= Math.Round((max * 26.65 / 100)))
                {
                    // Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(matrix[i, j] + "\t");
                }
                
                else if (matrix[i, j] < Math.Round((max * 26.65 / 100)))
                {
                    // Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write(matrix[i, j] + "\t");
                }
                else
                {
                    // Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.Write(matrix[i, j] + "\t");
                }
            }
            Print("\n");
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
    // task57
    public static int GetMaxMatrixValue(int[,] matrix)
    {
        int max = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > max)
                {
                    max = matrix[i, j];
                }
            }
        }

        return max;
    }
    
    public static int GetMinMatrixValue(int[,] matrix)
    {
        int min = matrix[0,0];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] < min)
                {
                    min = matrix[i, j];
                }
            }
        }

        return min;
    }
    
    public static int[] GetMaxMatrixIndex(int[,] matrix)
    {
        int[] indexes = new int[2];
        int max = matrix[0,0];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > max)
                {
                    max = matrix[i, j];
                    indexes[0] = i;
                    indexes[1] = j;
                }
            }
        }

        return indexes;
    }
    
    public static int[] GetMinMatrixIndex(int[,] matrix)
    {
        int[] indexes = new int[2];
        int min = matrix[0,0];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] < min)
                {
                    min = matrix[i, j];
                    indexes[0] = i;
                    indexes[1] = j;
                }
            }
        }

        return indexes;
    }
    
    
    public static int[,] RemoveMinColumnAndRow(int[,] matrix)
    {
        int[] minMatrix = GetMinMatrixIndex(matrix);
        int[,] newMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
        
        for (int i = 0, q = 0; i < newMatrix.GetLength(0); i++, q++)
        {
            for (int j = 0, w = 0; j < newMatrix.GetLength(1); j++, w++)
            {
                if (q == minMatrix[0]){ q++; }
                if (w == minMatrix[1]){ w++; }
                newMatrix[i, j] = matrix[q, w];
            }
        }

        return newMatrix;
    }

    public static int[,] GetCountNumberInMatrix(int[,] matrix)
    {
        int max = GetMaxMatrixValue(matrix) + 1;
        // Print($"\n{max}\n");
        int[,] countMatrix = new int[2, max];

        //fill matrix
        countMatrix = GetFilledMatrix(0, 2, max);
        
        //fill matrix 0 -> max
        for (int i = 0; i < countMatrix.GetLength(1); i++)
        {
            countMatrix[0, i] = i;
        }
        // PrintMatrix(countMatrix);

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            // Print("???????");
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                countMatrix[1, matrix[i, j]] += 1;
                // Print("\n\n-----------\n");
                // PrintMatrix(countMatrix);
            }
        }

        return countMatrix;
    }

    public static int[] GetSortedArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++) {
            for (int j = 0; j < array.Length - 1; j++) {
                if (array[j] > array[j + 1]) {
                    (array[j + 1], array[j]) = (array[j], array[j + 1]);
                }
            }
        }
        return array;
    }

    public static int[,] GetSortedMatrix(int[,] matrix)
    {
        int[,] newMatrix = new int[matrix.GetLength(0), matrix.GetLength(1)];
        int[] sortedArray = new int[matrix.GetLength(0) * matrix.GetLength(1)];
        for (int i = 0, k = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++, k++)
            {
                sortedArray[k] = matrix[i, j];
            }
        }
        sortedArray = GetSortedArray(sortedArray);
        for (int i = 0, k = 0; i < newMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < newMatrix.GetLength(1); j++, k++)
            {
                newMatrix[i, j] = sortedArray[k];
            }
        }

        return newMatrix;
    }

    public static int GetSumMinRowMatrix(int[,] matrix)
    {
        int[] rowsSum = new int[matrix.GetLength(0)];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            int temp = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                temp += matrix[i, j];
            }
            rowsSum[i] = temp;
            // PrintArray(rowsSum);
        }
        PrintArray(rowsSum, "Sum rows:");

        int min = rowsSum[0];
        int minIndex = 0;
        for (int i = 0; i < rowsSum.Length; i++)
        {
            if (rowsSum[i] < min)
            {
                min = rowsSum[i];
                minIndex = i;
            }
        }

        return minIndex;
    }

    public static int[,] GetSumMatrix(int[,] matrix1, int[,] matrix2)
    {
        
        // if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1))
        // {
        //     return;
        // }
        int[,] sumMatrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                sumMatrix[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        return sumMatrix;
    }

    public static void PrintCube(int[,,] cube)
    {
        for (int i = 0; i < cube.GetLength(0); i++)
        {
            for (int j = 0; j < cube.GetLength(1); j++)
            {
                Print("[ ");
                for (int k = 0; k < cube.GetLength(2); k++)
                {
                    Print($"{cube[i, j, k]} ");
                    Print("");
                }
                Print("]\t");
            }
            Print("\n");
        }
    }

    public static int[,] GetSpiralMatrix(int rows, int columns)
    {
        int[,] matrix = new int[rows, columns];
        int tempWidth = columns;
        int tempHeight = rows;
        int temp = 0;
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
        
        
        for (int count = 0, row = 0, column = 0; count < rows * columns;)
        {
            //Left-Right
            // Print("\nLeft-Right\n");
            for (; column < tempWidth - temp; column++, count++)
            {
                // Print($"\n--{row} | {column}--\n");
                matrix[row, column] = count + 1;
                PrintMatrix(matrix);
                Wait(10);
            }

            column--;
            row++;
            // Print("\nUp-Down\n");
            
            //Up-Down
            for (; row < tempHeight - temp; row++,count++)
            {
                // Print($"\n--{row} | {column}--\n");
                matrix[row, column] = count + 1;
                PrintMatrix(matrix);
                Wait(10);
            }

            row--;
            column--;
            // Print("\nRIGHT-LEFT\n");
            //Right-Left
            for (; column >= temp; column--,count++)
            {
                // Print($"\n--{row} | {column}--\n");
                matrix[row, column] = count + 1;
                PrintMatrix(matrix);
                Wait(10);
            }

            temp++;
            row--;
            column++;
            // Print("\nDown-Up\n");
            //Down-Up
            for (; row > temp; row--, count++)
            {
                // Print($"\n--{row} | {column}--\n");
                matrix[row, column] = count + 1;
                PrintMatrix(matrix);
                Wait(10);
            }
        }

        return matrix;
    }

    public static int[,,] GetRandomCube(int rows, int columns, int lines, int leftBorder, int rightBorder)
    {
        int[,,] cube = new int[rows, columns, lines];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                for (int k = 0; k < lines; k++)
                {
                    cube[i, j, k] = Random.Shared.Next(leftBorder, rightBorder + 1);
                }
            }
        }

        return cube;
    }

    public static void PrintMatrixCountTask(int[,] matrix)
    {
        // number - 0
        // count  - 1
        
        // Count matrix[0, j]: matrix[1, j] 
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            if (matrix[1, i] > 0)
            {
                Print($"Count {matrix[0, i]}: {matrix[1, i]}\n");
            }
            
        }
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

    public static int[,] SwapMatrixLastFirst(int[,] matrix)
    {
        
        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            int temp = matrix[0, i];
            matrix[0, i] = matrix[matrix.GetLength(0) - 1, i];
            matrix[matrix.GetLength(0) - 1, i] = temp;
        }
        
        return matrix;
    }
    
    

    public static int[,] RotateMatrix(int[,] matrix)
    {
        int[,] newMatrix = new int[matrix.GetLength(1), matrix.GetLength(0)];
        
        for (int i = 0; i < newMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < newMatrix.GetLength(1); j++)
            {
                newMatrix[i, j] = matrix[j, i];
            }
        }

        return newMatrix;
    }

    
    

    public static void WorkFormater(String articul, String name, String brand, String price)
    {
        Console.BackgroundColor = ConsoleColor.Gray;
        Console.ForegroundColor = ConsoleColor.White;
        int priceint = Int32.Parse(price);
        Print($"   <offer sku=\"{articul}\">\n");
        Print($"      <model>{name}</model>\n");
        Print($"      <brand>{brand}</brand>\n");
            Print("      <availabilities>\n" +
        "        <availability available=\"yes\" storeId=\"PP1\" preOrder=\"16\"/>\n" +
        "        <availability available=\"yes\" storeId=\"PP2\" preOrder=\"10\"/>\n" +
        "        <availability available=\"yes\" storeId=\"PP3\" preOrder=\"14\"/>\n" +
        "        <availability available=\"yes\" storeId=\"PP4\" preOrder=\"14\"/>\n" +
        "        <availability available=\"yes\" storeId=\"PP5\" preOrder=\"14\"/>\n" +
        "        <availability available=\"yes\" storeId=\"PP6\" preOrder=\"14\"/>\n" +
        "        <availability available=\"yes\" storeId=\"PP7\" preOrder=\"14\"/>\n" +
        "        <availability available=\"yes\" storeId=\"PP8\" preOrder=\"14\"/>\n" +
        "        <availability available=\"yes\" storeId=\"PP9\" preOrder=\"14\"/>\n" +
        "        <availability available=\"yes\" storeId=\"PP10\" preOrder=\"14\"/>\n" +
        "        <availability available=\"yes\" storeId=\"PP11\" preOrder=\"14\"/>\n" +
        "        <availability available=\"yes\" storeId=\"PP12\" preOrder=\"16\"/>\n" +
        "        <availability available=\"yes\" storeId=\"PP13\" preOrder=\"14\"/>\n" +
        "        <availability available=\"yes\" storeId=\"PP37\" preOrder=\"16\"/>\n" +
        "        <availability available=\"yes\" storeId=\"PP15\" preOrder=\"16\"/>\n" +
        "        <availability available=\"yes\" storeId=\"PP16\" preOrder=\"16\"/>\n" +
        "        <availability available=\"yes\" storeId=\"PP17\" preOrder=\"16\"/>\n" +
        "        <availability available=\"yes\" storeId=\"PP18\" preOrder=\"16\"/>\n" +
        "        <availability available=\"yes\" storeId=\"PP19\" preOrder=\"16\"/>\n" +
        "        <availability available=\"yes\" storeId=\"PP20\" preOrder=\"16\"/>\n" +
        "        <availability available=\"yes\" storeId=\"PP21\" preOrder=\"16\"/>\n" +
        "        <availability available=\"yes\" storeId=\"PP22\" preOrder=\"16\"/>\n" +
        "        <availability available=\"yes\" storeId=\"PP23\" preOrder=\"16\"/>\n" +
        "        <availability available=\"yes\" storeId=\"PP24\" preOrder=\"16\"/>\n" +
        "        <availability available=\"yes\" storeId=\"PP25\" preOrder=\"16\"/>\n" +
        "        <availability available=\"yes\" storeId=\"PP26\" preOrder=\"16\"/>\n" +
        "        <availability available=\"yes\" storeId=\"PP27\" preOrder=\"16\"/>\n" +
        "        <availability available=\"yes\" storeId=\"PP28\" preOrder=\"16\"/>\n" +
        "        <availability available=\"yes\" storeId=\"PP29\" preOrder=\"16\"/>\n" +
        "        <availability available=\"yes\" storeId=\"PP30\" preOrder=\"16\"/>\n" +
        "        <availability available=\"yes\" storeId=\"PP31\" preOrder=\"16\"/>\n" +
        "        <availability available=\"yes\" storeId=\"PP32\" preOrder=\"16\"/>\n" +
        "        <availability available=\"yes\" storeId=\"PP33\" preOrder=\"16\"/>\n" +
        "        <availability available=\"yes\" storeId=\"PP34\" preOrder=\"16\"/>\n" +
        "        <availability available=\"yes\" storeId=\"PP35\" preOrder=\"16\"/>\n" +
        "        <availability available=\"yes\" storeId=\"PP36\" preOrder=\"16\"/>\n" +
        "        <availability available=\"yes\" storeId=\"PP38\" preOrder=\"16\"/>\n" +
        "        <availability available=\"yes\" storeId=\"PP39\" preOrder=\"16\"/>\n" +
        "     </availabilities>\n" +
        "     <cityprices>\n" +
        $"        <cityprice cityId=\"591010000\">{priceint}</cityprice>\n" +
        $"        <cityprice cityId=\"710000000\">{priceint + 30000}</cityprice>\n" +
        $"        <cityprice cityId=\"111010000\">{priceint + 30000}</cityprice>\n" +
        $"        <cityprice cityId=\"551010000\">{priceint + 30000}</cityprice>\n" +
        $"        <cityprice cityId=\"111810000\">{priceint + 30000}</cityprice>\n" +
        $"        <cityprice cityId=\"391010000\">{priceint + 30000}</cityprice>\n" +
        $"        <cityprice cityId=\"117020100\">{priceint + 30000}</cityprice>\n" +
        $"        <cityprice cityId=\"113220100\">{priceint + 30000}</cityprice>\n" +
        $"        <cityprice cityId=\"116651100\">{priceint + 30000}</cityprice>\n" +
        $"        <cityprice cityId=\"351010000\">{priceint + 40000}</cityprice>\n" +
        $"        <cityprice cityId=\"352410000\">{priceint + 40000}</cityprice>\n" +
        $"        <cityprice cityId=\"750000000\">{priceint + 50000}</cityprice>\n" +
        $"        <cityprice cityId=\"471010000\">{priceint + 50000}</cityprice>\n" +
        $"        <cityprice cityId=\"231010000\">{priceint + 50000}</cityprice>\n" +
        $"        <cityprice cityId=\"471810000\">{priceint + 50000}</cityprice>\n" +
        $"        <cityprice cityId=\"151010000\">{priceint + 50000}</cityprice>\n" +
        $"        <cityprice cityId=\"271010000\">{priceint + 50000}</cityprice>\n" +
        $"        <cityprice cityId=\"511010000\">{priceint + 50000}</cityprice>\n" +
        $"        <cityprice cityId=\"431010000\">{priceint + 50000}</cityprice>\n" +
        $"        <cityprice cityId=\"316621100\">{priceint + 50000}</cityprice>\n" +
        $"        <cityprice cityId=\"311010000\">{priceint + 50000}</cityprice>\n" +
        $"        <cityprice cityId=\"191010000\">{priceint + 50000}</cityprice>\n" +
        $"        <cityprice cityId=\"512610000\">{priceint + 50000}</cityprice>\n" +
        $"        <cityprice cityId=\"631010000\">{priceint + 50000}</cityprice>\n" +
        $"        <cityprice cityId=\"632810000\">{priceint + 50000}</cityprice>\n" +
        $"        <cityprice cityId=\"632210000\">{priceint + 50000}</cityprice>\n" +
        $"        <cityprice cityId=\"552210000\">{priceint + 50000}</cityprice>\n" +
        $"        <cityprice cityId=\"351610000\">{priceint + 50000}</cityprice>\n" +
        $"        <cityprice cityId=\"273620100\">{priceint + 70000}</cityprice>\n" +
        $"        <cityprice cityId=\"551610000\">{priceint + 70000}</cityprice>\n" +
        $"        <cityprice cityId=\"153220100\">{priceint + 70000}</cityprice>\n" +
        $"        <cityprice cityId=\"433220100\">{priceint + 70000}</cityprice>\n" +
        $"        <cityprice cityId=\"391610000\">{priceint + 70000}</cityprice>\n" +
        $"        <cityprice cityId=\"633420100\">{priceint + 70000}</cityprice>\n" +
        $"        <cityprice cityId=\"634030100\">{priceint + 70000}</cityprice>\n" +
        $"        <cityprice cityId=\"394420100\">{priceint + 70000}</cityprice>\n" +
        $"        <cityprice cityId=\"316220100\">{priceint + 70000}</cityprice>\n" +
        $"        <cityprice cityId=\"352210000\">{priceint + 70000}</cityprice>\n" +
        "     </cityprices>\n" +
        "   </offer>");
    }
    public static void CopyStream(Stream stream, string destPath)
    {
        using (var fileStream = new FileStream(destPath, FileMode.Create, FileAccess.Write))
        {
            stream.CopyTo(fileStream);
        }
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