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
        int[,] matrix = new int[5, 5];
        GetRandomUniqueMatrix(matrix);
        PrintMatrix(matrix);
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