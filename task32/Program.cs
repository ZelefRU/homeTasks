using methods;

namespace task32;
class Program
// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 
{
    static void Main(string[] args)
    {
        Methods m = new Methods();
        
        int[] taskArray = m.RandomArray(5, -99, 99);
        m.Print($"[{string.Join(", ", taskArray)}]");
        for (int i = 0; i < taskArray.Length; i++) {
            taskArray[i] = -taskArray[i];
        }
        m.Print($"[{string.Join(", ", taskArray)}]");
    }
}




