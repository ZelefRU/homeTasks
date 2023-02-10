Console.Write("Input 1 number: ");
string firstString = Console.ReadLine();
int firstNumber = Convert.ToInt32(firstString);
Console.Write("Input 2 number: ");
string secondString = Console.ReadLine();
int secondNumber = Convert.ToInt32(secondString);
int max = 0;
if (firstNumber > secondNumber) { max = firstNumber; }
else  max = secondNumber;
Console.WriteLine(max);