/*
Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120
*/


int Result(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++)
    {

        result = result * i;

    }
    Console.WriteLine(result);
    return result;

}
Result(4);