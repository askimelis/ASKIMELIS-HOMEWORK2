/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/

int Prompt(string message)
{
    Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

bool IsWeekend(int weekDay)
{
    if (weekDay < 5)
    {
        return true;
    }
    return false;
}

bool ValidateWeekday(int number)
{
    if (number > 0 && number <= 7)
    {
        return true;
    } 
    Console.WriteLine("It is not day of the week");
    return false;
}

int weekDay = Prompt("Please enter the day of the week >");
if (ValidateWeekday(weekDay))
{
    if (IsWeekend(weekDay))
    {
        Console.WriteLine("Yaaay! It is WEEEEEKEND!");
    }
    else
    {
       Console.WriteLine("NoOoOoO! It is WORKINGday!");
    }
}
