/*
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
int getNumberFromUser(string message)
{
    int result = 0;
    Console.WriteLine(message);
    result = Convert.ToInt32(Console.ReadLine());
    return result;
}
void Result(int number)
{
    int res = 0;
    for (int i = 1; i <= number; i++)
    {

        res = i * i * i;
        System.Console.WriteLine(res);

    }
}
int x = getNumberFromUser("Введите число:");
Result(x);