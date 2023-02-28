namespace methods;

public class Methods
{
    private static void Main()
    {
    }

    public void Print(string printMessage)
    {
        Console.Write(printMessage);
    }

    public void Wait(int waitTime)
    {
        Thread.Sleep(waitTime);
    }

    public (int, int, int) DifMaxMin(int[] array)
    {
        var max = array[0];
        var min = array[0];
        for (var i = 0; i < array.Length; i++)
            if (array[i] < min)
                min = array[i];
            else if (array[i] > max) max = array[i];
        return (max - min, min, max);
    }

    public int DifMaxMinShort(int[] array)
    {
        var max = array[0];
        var min = array[0];
        for (var i = 0; i < array.Length; i++)
            if (array[i] < min)
                min = array[i];
            else if (array[i] > max) max = array[i];
        return max - min;
    }

    public void PrintArray(int[] array, string message = "\nOur array: ")
    {
        Print($"{message} [{string.Join(", ", array)}]");
    }

    public int ReadNumber(string messageToUser)
    {
        Print(messageToUser);
        return int.Parse(Console.ReadLine() ?? string.Empty);
    }

    public int[] IntToArray(int n)
    {
        if (n == 0) return new int[1] { 0 };

        var digits = new List<int>();

        for (; n != 0; n /= 10)
            digits.Add(n % 10);

        var array = digits.ToArray();
        Array.Reverse(array);
        return array;
    }

    public int[] RandomArray(int lenght, int leftRange, int rightRange)
    {
        var array = new int[lenght];
        for (var i = 0; i < lenght; i++) array[i] = Random.Shared.Next(leftRange, rightRange + 1);
        return array;
    }

    public (int, int) SumPlusMinusNum(int[] array)
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
    public int EvenNumber(int[] array)
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
    
    public int SumUneven (int[] array) {
        int sum = 0;
        for(int i = 1; i < array.Length; i += 2) {
            sum += array[i];
        }
        return sum;
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