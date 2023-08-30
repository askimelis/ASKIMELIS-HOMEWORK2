/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1*/

int Message(string message)
{
System.Console.Write(message);
string value = Console.ReadLine();
int result = Convert.ToInt32(value);
return result;
}

int number = Message("Please write 3 digit number > ");
if (number < 100 || number >= 1000)
{
    Console.WriteLine("You didn't enter 3 digit number, please, enter 3 digit number again");
    return;
}

Console.WriteLine($"Entered number '{number}'");
int secondRank = number / 10 % 10;
Console.WriteLine($"Second digit is '{secondRank}'");

