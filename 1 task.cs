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



// //// Компактная версия
// int random = Random.Shared.Next(1,99);
// int firstDigit = random / 10;
// int secondDigit = random % 10;
// if (firstDigit > secondDigit) {Console.WriteLine(firstDigit);}
// else Console.WriteLine(secondDigit);


// int randomNumber = Random.Shared.Next(1,99);
// Console.WriteLine("Загадываем число.");
// System.Threading.Thread.Sleep(800);
// Console.WriteLine("Загадываем число..");
// System.Threading.Thread.Sleep(800);
// Console.WriteLine("Загадываем число...");
// System.Threading.Thread.Sleep(800);
// Console.WriteLine("Наше число: " + randomNumber + "!");
// int firstRandomDigit = randomNumber / 10;
// int secondRandomDigit = randomNumber % 10;
// System.Threading.Thread.Sleep(2000);
// Console.WriteLine("*** Производим магию вычислений! ***");
// System.Threading.Thread.Sleep(2000);
// Console.WriteLine("Наша первая цифра: " + firstRandomDigit);
// System.Threading.Thread.Sleep(300);
// Console.WriteLine("Наша вторая цифра: " + secondRandomDigit);
// Console.WriteLine("Считаем.");
// System.Threading.Thread.Sleep(800);
// Console.WriteLine("Считаем..");
// System.Threading.Thread.Sleep(800);
// Console.WriteLine("Считаем...");
// System.Threading.Thread.Sleep(800);
// if (firstRandomDigit > secondRandomDigit) {Console.WriteLine("Цифра " + firstRandomDigit + " больше чем " + secondRandomDigit + "!");}
// else if (firstRandomDigit < secondRandomDigit) {Console.WriteLine("Цифра " + secondRandomDigit + " больше чем " + firstRandomDigit + "!");}
// else if (firstRandomDigit == secondRandomDigit) {Console.WriteLine("Вот это повезло!" + firstRandomDigit + "=" + secondRandomDigit);}
// else {Console.WriteLine("Магия не сработала :(");}

//// Компактная версия + ленивая версия
int random = Random.Shared.Next(100,999);
int firstDigit = random / 100;
int lastDigit = random % 10;
int middleDigit = (random / 10) % 10;
// Console.Write(firstDigit);
// Console.Write(secondDigit);
Console.Write("Загадываем число.");
System.Threading.Thread.Sleep(800);
Console.Write(".");
System.Threading.Thread.Sleep(800);
Console.Write(".");
System.Threading.Thread.Sleep(800);
Console.WriteLine(" ");
Console.WriteLine("Наше число: " + random + "!");
System.Threading.Thread.Sleep(1600);
Console.WriteLine(random + " <- Вот наше число");
System.Threading.Thread.Sleep(800);
Console.WriteLine(random + " <- А теперь магия исчезновения");
System.Threading.Thread.Sleep(1500);
Console.Write(firstDigit + " "); Console.WriteLine(lastDigit + " <- Хоба!");
System.Threading.Thread.Sleep(800);
Console.Write(".");
System.Threading.Thread.Sleep(300);
Console.Write(".");
System.Threading.Thread.Sleep(300);
Console.Write(".");
System.Threading.Thread.Sleep(300);
Console.WriteLine(" ");
if (middleDigit == 0) {
    Console.WriteLine("А куда же делся " + middleDigit + "?");
    System.Threading.Thread.Sleep(1200);
    Console.WriteLine("Его больше никто так и не видел...");
    }
else {
    Console.WriteLine("А куда же делась цифра " + middleDigit + "?");
    System.Threading.Thread.Sleep(1200);
    Console.WriteLine("Её больше никто так и не видел...");
}

