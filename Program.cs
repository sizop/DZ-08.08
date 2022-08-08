// #1
/*
Console.WriteLine("Введите трехзначное число: ");

int digit2 = (num / 10) % 10;
Console.WriteLine(digit2);
*/

// #2
/*
Console.WriteLine("Введите число: ");
string? num = Console.ReadLine();
if ((num.Length) < 3) { Console.WriteLine("третьей цифры нет"); }
else {Console.WriteLine("Третья цифра числа: " + num[2]);}
*/

// #2-2
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num<100)
{	Console.WriteLine("У числа нет третьей цифры");}
else
{while (num > 999)
{	num = (num / 10);}
Console.WriteLine($"Третья цифра числа: {num % 10}");}

// #3
/*
Console.WriteLine("Введите порядковый номер дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num == 6 || num == 7) { Console.WriteLine("Да"); }
else { Console.WriteLine("Нет"); }
*/