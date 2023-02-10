//1 task
Console.Write("Input 1 number: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Input 2 number: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (firstNumber > secondNumber) { max = firstNumber; }
else  max = secondNumber;
Console.WriteLine(max);

//2 task
Console.Write("Input 1 number: ");
int firstNumber2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input 2 number: ");
int secondNumber2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input 3 number: ");
int thirdNumber2 = Convert.ToInt32(Console.ReadLine());
int max2 = 0;
if (firstNumber2 > secondNumber2) { max = firstNumber2; }
else  max2 = secondNumber2;
if (thirdNumber2 > max2) { max2 = thirdNumber2; }
Console.WriteLine(max2);

//3 task
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number % 2 == 0) { Console.WriteLine("true"); }
else Console.WriteLine("false");

//4 task
Console.WriteLine("start four task");
Console.Write("Input number: ");
int number2 = Convert.ToInt32(Console.ReadLine());
for(int i=1; i<= number2; i++)
{if (i % 2 == 0) {Console.WriteLine(i);}}



// Console.WriteLine("?");


// Console.Write("Input number: ");
// int numberDay = Convert.ToInt32(Console.ReadLine());
// var res = "";
// string[] days = new string[] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье", "Ошибка"};
// if (numberDay > 7 || numberDay < 1) {res = days[7];}
// else res = days[numberDay-1];
// Console.WriteLine(res);