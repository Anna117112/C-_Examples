/*
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную 
степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

int getNumberFromUser(string message)
{

    Console.WriteLine(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void degreeOfPositive(int a, int b)
{

    int result = a;

    while (b - 1 > 0)
    {
        result *= a;
        b--;

    }
    System.Console.WriteLine(result);
}

void degreeOfNegative(int a, int b)
{

    double result = a;

    while (b - 1 < 0)
    {
        result /= a;
        b++;

    }
    System.Console.WriteLine(result);
}

void result(int a, int b)
{
    if (b <= 0)
    {
        degreeOfNegative(a, b);
    }
    else
    {
        degreeOfPositive(a, b);
    }
}
int number1 = getNumberFromUser("Введите первое число");
int number2 = getNumberFromUser("Введите второе число");
result(number1, number2);