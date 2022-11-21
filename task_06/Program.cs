/*
Задача 13: Напишите программу, которая выводит третью цифру заданного 
числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int NewRundome()
{
    int random = new Random().Next(1, 99999);
    System.Console.WriteLine(random);
    return random;
}

int ThreeDigitNumber(int digit)

{
    int result = 0;
    int digitLenght = digit.ToString().Length;

    if (digitLenght < 3)
    {
        System.Console.WriteLine("Нет третьего числа ");
    }
    else
    {
        int count = 1;
        for (int i = digitLenght; i > 3; i--)
        {
            count = count * 10;

            result = (digit / count) % 10;

        }
    }
    return result;
}

int num = NewRundome();

int res = ThreeDigitNumber(num);
System.Console.WriteLine($"Третья цифра {res}");