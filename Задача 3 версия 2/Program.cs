// Напишите программу, которая принимает 
// на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine ("Введите цифру, обозначающую день недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 1)
{
    Console.WriteLine ("Понедельник. Не выходной");    
}
else if (number == 2)
{
    Console.WriteLine ("Вторник. Не выходной");
}
else if (number == 3)
{
    Console.WriteLine ("Среда. Не выходной");
}
else if (number == 4)
{
    Console.WriteLine ("Четверг. Не выходной");
}
else if (number == 5)
{
    Console.WriteLine ("Пятница. Не выходной");
}
else if (number == 6)
{
    Console.WriteLine ("Суббота. Выходной");
}
else if (number == 7)
{
    Console.WriteLine ("Воскресенье. Выходной");
}
else if (number > 7 | number < 1)
{
   Console.WriteLine ("Для определения дня недели укажите цифру в диапозоне от 1 до 7");
}
