using methods;

namespace task31;
class Program
// Задача 31: Задайте массив из 12 элементов, 
// заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел равна 29, сумма отрицательных равна -20.
{
    static void Main(string[] args)
    {
        Methods m = new Methods();
        
        int[] taskArray = m.RandomArray(123, -9, 9);
        (int sumP, int sumM) = m.SumPlusMinusNum(taskArray);
        m.Print($"[{string.Join(", ", taskArray)}] \n {sumP}\n {sumM}");
    }
}


