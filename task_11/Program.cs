/*
Задача 26: Напишите программу, которая принимает на вход 
число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

int Result(int num)

{
    int count = 0;
    while (num > 0)
    {
        num /= 10;
        count++;

    }
    System.Console.WriteLine(count);
    return count;
}
Result(255);
