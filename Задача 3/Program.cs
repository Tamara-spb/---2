﻿// Напишите программу, которая принимает 
// на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine ("Введите цифру, обозначающую день недели от 1 до 7: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number >=1 && number <= 5)
{
    Console.WriteLine ("Будний день");  
}
else if (number >5 && number <8)
{
    Console.WriteLine ("Выходной день");
}
else if (number < 1 | number >7)
{
    Console.WriteLine ("Введите цифру от 1 до 7");
}