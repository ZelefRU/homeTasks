using static methods.Methods;
namespace Features;
class Program
{
    static void Main(string[] args)
    {
        // округление
        var a = 1.1;    
        var aFloor = Math.Floor(a);
        var aRound = Math.Round(a);
        var aCeiling = Math.Ceiling(a);
        
        Print($"{a} - default \n{aFloor} - Floor \n{aRound} - Round \n{aCeiling} - Ceiling");
////Хитрожопость
        string stringInt = "1, 2, 3, 4";
        int[] array = stringInt.Split(", ").Select(x => int.Parse(x)).ToArray();

        Print($"[ {string.Join(", ", array)} ]");
    }
}
