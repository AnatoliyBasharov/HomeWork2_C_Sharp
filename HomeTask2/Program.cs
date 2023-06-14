// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6


System.Console.WriteLine("Введите число ");
string number = Console.ReadLine();
int numberOne = Convert.ToInt32(number);
Char[] array = numberOne.ToString().ToCharArray();

if (numberOne < 100)
{

    System.Console.WriteLine("Третьей цифры нет");
}
else
{
    System.Console.WriteLine(array[2]);
}