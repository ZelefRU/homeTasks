void PrintS(string printMessage) { Console.Write(printMessage); }
void PrintN(int printNumber) { Console.Write(printNumber); }
void PrintSL(string printMessage) { Console.WriteLine(printMessage); }
void PrintNL(int printNumber) { Console.WriteLine(printNumber); }
void Wait(int waitTime) { System.Threading.Thread.Sleep(waitTime); }

// //1 task
// Console.Write("Input 1 number: ");
// int firstNumber = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input 2 number: ");
// int secondNumber = Convert.ToInt32(Console.ReadLine());
// int max = 0;
// if (firstNumber > secondNumber) { max = firstNumber; }
// else  max = secondNumber;
// Console.WriteLine(max);

// //2 task
// Console.Write("Input 1 number: ");
// int firstNumber2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input 2 number: ");
// int secondNumber2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input 3 number: ");
// int thirdNumber2 = Convert.ToInt32(Console.ReadLine());
// int max2 = 0;
// if (firstNumber2 > secondNumber2) { max = firstNumber2; }
// else  max2 = secondNumber2;
// if (thirdNumber2 > max2) { max2 = thirdNumber2; }
// Console.WriteLine(max2);

// //3 task
// Console.Write("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number % 2 == 0) { Console.WriteLine("true"); }
// else Console.WriteLine("false");

// //4 task
// Console.WriteLine("start four task");
// Console.Write("Input number: ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// for(int i=1; i<= number2; i++)
// {if (i % 2 == 0) {Console.WriteLine(i);}}



// // Console.WriteLine("?");


// // Console.Write("Input number: ");
// // int numberDay = Convert.ToInt32(Console.ReadLine());
// // var res = "";
// // string[] days = new string[] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье", "Ошибка"};
// // if (numberDay > 7 || numberDay < 1) {res = days[7];}
// // else res = days[numberDay-1];
// // Console.WriteLine(res);

//////////////////////////////////////////////////////////////////
//                                                              //
//                     2 дз начинается здесь                    //
//                                                              //
//////////////////////////////////////////////////////////////////

// //// Компактная версия
// int random = Random.Shared.Next(1,99);
// int firstDigit = random / 10;
// int secondDigit = random % 10;
// if (firstDigit > secondDigit) {PrintNL(firstDigit);}
// else PrintNL(secondDigit);


// //// Версия с магией
// int randomNumber = Random.Shared.Next(1,99);
// PrintS("Загадываем число.");
// Wait(800);
// PrintS(".");
// Wait(800);
// PrintS(".");
// Wait(800);
// PrintSL(" ");
// PrintSL($"Наше число: {randomNumber}!");
// int firstRandomDigit = randomNumber / 10;
// int secondRandomDigit = randomNumber % 10;
// Wait(2000);
// PrintSL("*** Производим магию вычислений! ***");
// Wait(2000);
// PrintSL($"Наша первая цифра: {firstRandomDigit}");
// Wait(300);
// PrintSL($"Наша вторая цифра: {secondRandomDigit}");
// PrintSL("Считаем.");
// Wait(800);
// PrintS(".");
// Wait(800);
// PrintS(".");
// PrintSL(" ");
// Wait(800);
// if (firstRandomDigit > secondRandomDigit) {PrintSL($"Цифра {firstRandomDigit} больше чем {secondRandomDigit}!");}
// else if (firstRandomDigit < secondRandomDigit) {PrintSL($"Цифра {secondRandomDigit} больше чем {firstRandomDigit}!");}
// else if (firstRandomDigit == secondRandomDigit) {PrintSL($"Вот это повезло {firstRandomDigit} = {secondRandomDigit}");}
// else {PrintSL("Магия не сработала :(");}

// //// хе
// int random = Random.Shared.Next(100,999);
// int firstDigit = random / 100;
// int lastDigit = random % 10;
// int middleDigit = (random / 10) % 10;
// PrintS("Загадываем число.");
// Wait(800);
// PrintS(".");
// Wait(800);
// PrintS(".");
// Wait(800);
// PrintSL(" ");
// PrintSL($"Наше число: {random}!");
// Wait(1600);
// PrintSL($"{random} <- Вот наше число");
// Wait(800);
// PrintSL($"{random} <- А теперь магия исчезновения");
// Wait(1500);
// PrintSL($"{firstDigit} {lastDigit} <- Хоба!");
// Wait(800);
// PrintS(".");
// Wait(300);
// PrintS(".");
// Wait(300);
// PrintS(".");
// Wait(300);
// PrintSL(" ");
// if (middleDigit == 0) {
//     PrintSL($"А куда же делся {middleDigit}?");
//     Wait(1200);
//     PrintSL("Его больше никто так и не видел...");
//     }
// else {
//     PrintSL("А куда же делась цифра {middleDigit}?");
//     Wait(1200);
//     PrintSL("Её больше никто так и не видел...");
// }



// Console.Write("Input ur num: ");
// int inputNumber = Convert.ToInt32(Console.ReadLine());
// if (inputNumber % 7 == 0 && inputNumber % 23 == 0) {Console.WriteLine("усё намана");}
// else {Console.WriteLine($"{inputNumber} не кратен 7 и 23");}


///////////////////////HOME TASK 2
///////////////////////HOME TASK 2
///////////////////////HOME TASK 2
///////////////////////HOME TASK 2

//Домашняя работа (не использовать для решения задач представления числа в виде строки (т.е. не брать число как массив))
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// Console.Write(" Input number from 100 to 999: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number < 1) {number = number * -1;}
// // number = Math.Abs(number);
// int middle = (number / 10) % 10;
// Console.WriteLine(middle);


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (номер цифры считается от левого края)
// Console.Write("Input number from 100: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if (number < 100)
// {
//     Console.WriteLine("Error");
// }
// else {
//     for (; number > 999;) {
//         number = number / 10;
//     }
//     Console.WriteLine(number % 10);
// }

////цикл while
// {
//     while (number > 999)
//     {
//         number = number / 10;
//     }
// }

// //Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// Console.Write("Input day: ");
// int day = Convert.ToInt32(Console.ReadLine());
// var result = day == 6 || day == 7 ? ("Stay home") : ("Go Work!");
// if (day > 7) {Console.WriteLine("Error");}
// else {Console.WriteLine(result);}






// //шифратор
// int value1 = 3;  // 0b0000_0011
// int result = 0;
// // сохраняем в result значения из value1
// result = result | value1; // 0b0000_0011
// // сдвигаем разряды в result на 2 разряда влево
// result = result << 12;   // 0b0000_1100
// Console.WriteLine(result);  // 12288
// result = result >> 12;
// Console.WriteLine(result);  // 3


// //тесты
// int test = 1993;
// int i = 1;
// foreach(char c in Convert.ToString(test))
// {
//     Console.WriteLine($"{c} - {i} элемент");
//     i++;
// }

//// Таблица умножения
// Console.WriteLine("How much numbers?");
// int count = Convert.ToInt32(Console.ReadLine()) + 1;
// for (int i = 1; i < count; i++)
// {
//     for (int j = 1; j < count; j++)
//     {
//         Console.Write($"{i * j}  ");
//     }
//     Console.WriteLine();
// }

// int[] numbers = { 1, 2, 3, 4, 5 };
// foreach (int i in numbers)
// {
//     Console.WriteLine(i);
// }


// int[][] numbers = new int[4][];
// numbers[0] = new int[] { 1, 2 };
// numbers[1] = new int[] { 1, 2, 3 };
// numbers[2] = new int[] { 1, 2, 3, 4, 5 };
// numbers[3] = new int[] { 3, 5, 1, 5 };
// foreach(int[] row in numbers)
// {
//     foreach(int number in row)
//     {
//         Console.Write($"{number} \t");
//     }
//     Print("");
// }

// // // перебор с помощью цикла for
// // for (int i = 0; i<numbers.Length;i++)
// // {
// //     for (int j =0; j<numbers[i].Length; j++)
// //     {
// //         Console.Write($"{numbers[i][j]} \t");
// //     }
// //     Console.WriteLine();
// // }



// Console.WriteLine("\n\n");
// int[] nums = { 54, 7, -41, 2, 4, 2, 89, 33, -5, 12 };
// for (int i = 0; i < nums.Length; i++) {Console.Write($"{nums[i]} ");}
// Console.WriteLine();
// int temp;
// for (int i = 0; i < nums.Length - 1; i++)
// {
//     for (int j = i + 1; j < nums.Length; j++)
//     {
//         if (nums[i] > nums[j])
//         {
//             temp = nums[i];
//             nums[i] = nums[j];
//             nums[j] = temp;
//         }
//     }
// }
// Console.WriteLine("Sorted: ");
// for (int i = 0; i < nums.Length; i++)
// {
//     Console.Write($"{nums[i]} ");
// }
// Console.WriteLine("\n\n");







// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// PrintS(" Input number from 10000 to 99999: ");
// var arrayNumber = Console.ReadLine().ToArray();
// if (arrayNumber.Length != 5) {
//     PrintSL("Error");
// }
// else {if (arrayNumber[0] == arrayNumber[4] && arrayNumber[1] == arrayNumber[3]) {
//         PrintSL("ok");
//     }
//     else {PrintSL("Nope");}
// }


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125











// PrintS("Input number from 1: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if ( number < 1 ) {
//     PrintSL("Error. Ur num less than 1");
// }
// else {
//     for (int i = 1; i < number + 1; i++) {
//         Console.WriteLine(i * i * i);
//     }
// }


// Console.Clear (); // Очистка консоли
// // Console.SetCursorPosition (x, y) - установка курсора в координаты x и y;
// // Console.WriteLine ("*");

// int xa = 60, ya = 1,
//     xb = 1, yb = 30,
//     xc = 120, yc = 30;

// Console.SetCursorPosition (xa, ya);
// Console.WriteLine ("*");

// Console.SetCursorPosition (xb, yb);
// Console.WriteLine ("*");

// Console.SetCursorPosition (xc, yc);
// Console.WriteLine ("*");

// int x = xa, y = ya;

// int count = 0;

// while (count < 25000) {

//     int what = new Random().Next(0, 3); //случайное число от 0 до 2 включительно

//     if (what == 0) {
//         x = (x + xa) / 2;
//         y = (y + ya) / 2;
//     }

//     if (what == 1) {
//         x = (x + xb) / 2;
//         y = (y + yb) / 2;
//     }

//     if (what == 2) {
//         x = (x + xc) / 2;
//         y = (y + yc) / 2;
//     }

//     Console.SetCursorPosition (x, y);
//     Console.WriteLine("*");
//     count++;

// }





