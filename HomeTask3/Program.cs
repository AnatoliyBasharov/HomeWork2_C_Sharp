// Задача 3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

System.Console.WriteLine("Введите число ");
string number = Console.ReadLine();
int numberOne = Convert.ToInt32(number);

if (numberOne > 5 && numberOne <= 7)
{
    System.Console.WriteLine("Является выходным днем");
}
if (numberOne > 0 && numberOne <= 5)
{
    System.Console.WriteLine("Это рабочий день, иди работай!");
}
if (numberOne > 7)
{
    System.Console.WriteLine("Такого дня не существует");
}