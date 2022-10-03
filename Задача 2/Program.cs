// Напишите программу, которая выводит 
// третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Random rand = new Random();
int number = rand.Next (0, 100000);
Console.WriteLine ($"Введено случайное число: {number}");
if (number > 99 && number < 1000)
{
    int digit3 = number % 10;
    Console.WriteLine ($"Третья цифра числа {digit3}");
}
else if (number > 999 && number < 10000)
{
    int digit3 = number % 100 / 10;
    Console.WriteLine ($"Третья цифра числа {digit3}");
}
else if (number > 10000 && number < 100000)
{
    int digit3 = number % 1000 / 100;
    Console.WriteLine ($"Третья цифра числа {digit3}");
}
else
{
    Console.WriteLine ("Третьей цифры нет");
}