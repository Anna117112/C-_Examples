/*
Задача 10: Напишите программу, которая принимает на вход 
трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

int ThreeDigitNumber()
{
    int random = new Random().Next(100, 1000);
    return random;
}

int NumberTwoDigit(int digit)
{
    int twoDigit = 0;
    int number = digit % 100;
    twoDigit = number / 10;
    return twoDigit;
}

void main()
{
    int newRandome = ThreeDigitNumber();
    System.Console.WriteLine(newRandome);
    int result = NumberTwoDigit(newRandome);
    System.Console.WriteLine(result);
}

for (int i = 0; i < 10; i++)
{
    main();
}