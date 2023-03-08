using static methods.Methods;

namespace task61;
class Program
{
    static void Main(string[] args)
    {
        int rows = ReadNumber("Input rows count: ");
        
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j <= (rows - i); j++) 
            {
                Print("\t"); 
            }
            for (int j = 0; j <= i; j++)
            {
                Print("\t"); 
                Print($"{Math.Round(Factorial(i) / (Factorial(j) * Factorial(i - j)))}\t");
            }
            Print("\n\n");
        }
    }
}
