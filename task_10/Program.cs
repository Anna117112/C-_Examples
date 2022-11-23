/*
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/
int getNumberFromUser(string message)
{
    int result = 0;
    Console.WriteLine(message);
    result = Convert.ToInt32(Console.ReadLine());
    return result;
}


void Palindrome(int digit)
{
    int lenghtDigit = digit.ToString().Length;
    while (lenghtDigit != 5)
    {
        digit = getNumberFromUser("Введите 5-ти значное число");
        lenghtDigit = digit.ToString().Length;

    }

    int firstDigit = digit / 10000;
    int twoDigit = (digit % 10000) / 1000;
    int forDigit = (digit % 100) / 10;
    int fiveDigit = digit % 10;
    if ((firstDigit == fiveDigit) && (twoDigit == forDigit))
    {
        System.Console.WriteLine($"Число {digit} является палиндромом");

    }
    else
        System.Console.WriteLine($"Число {digit} не является палиндромом");

}


int x = getNumberFromUser("Введите 5- ти значное число:");
Palindrome(x);
