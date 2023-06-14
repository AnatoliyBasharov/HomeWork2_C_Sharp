//Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.


System.Console.WriteLine("Введите число ");
string number = Console.ReadLine();
int numberOne = Convert.ToInt32(number);

if(numberOne > 100 && numberOne < 1000){
    System.Console.WriteLine("Число трехзначное");
}else{
    System.Console.WriteLine("Число не трехзначное");
}

Char[] array = numberOne.ToString().ToCharArray();
System.Console.WriteLine($"Вторая цифра в числе {numberOne} является {array[1]}");