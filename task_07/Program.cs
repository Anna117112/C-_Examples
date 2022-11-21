/*
Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
int RandomDidit()
{
    System.Console.WriteLine("Введите число ");
    int digit = Convert.ToInt32(Console.ReadLine());
    return digit;
}

void DayOffWeek(int dayWeek)
{

    if ((dayWeek == 6) || (dayWeek == 7))
    {
        System.Console.WriteLine($"{dayWeek} да");
    }
    else
    {
        System.Console.WriteLine($"{dayWeek} нет");
    }
}

int number = RandomDidit();
DayOffWeek(number);