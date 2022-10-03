// Напишите программу, которая выводит 
// третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine ("Введите целое число от 1 до 99999: ");
int number = Convert.ToInt32(Console.ReadLine());
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
else if (number >=1 && number < 100)
{
    Console.WriteLine ("Третьей цифры нет");
}
else
{
    Console.WriteLine ("Введенная цифра выходит за рамки диапазона");
}
