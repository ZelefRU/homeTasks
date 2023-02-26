
public class M {
    public void Print(string printMessage) { Console.Write(printMessage); }
    public void PrintS(string printMessage) { Console.Write(printMessage); }
    public void PrintN(int printNumber) { Console.Write(printNumber); }
    public void PrintSL(string printMessage) { Console.WriteLine(printMessage); }
    public void PrintNL(int printNumber) { Console.WriteLine(printNumber); }
    public void Wait(int waitTime) { System.Threading.Thread.Sleep(waitTime); }
    public void PrintArray (int[] array, string message) {
        new M().Print($"{message} [{string.Join(", ", array)}]");
        // return message + string.Join(", ", array);
        // return Print($"{message} [{string.Join(",", array)}]");
    }
    
    public int[] RandomArray (int lenght, int leftRange, int rightRange) {
    
        int[] array = new int[lenght];
        for (int i = 0; i < lenght; i++) {
            array[i] = Random.Shared.Next(leftRange, rightRange + 1);
        }
        return array;
    }
    
    public int EvenNumber (int[] array) {
        int count = 0;
        for (int i = 0; i < array.Length; i++) {
            if (array[i] % 2 == 0) {
                count++;
            }
            i++;
        }
        return count;
    }
}