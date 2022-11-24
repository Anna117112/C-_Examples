/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/
int getNumberFromUser(string message)
{
    int result = 0;
    Console.WriteLine(message);
    result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int summDigit(int digit)
{
    int summ = 0;
    while (digit > 0)
    {
        summ += digit % 10;

        digit /= 10;
    }

    return summ;

}
int dig = getNumberFromUser("Введите число ");
int result = summDigit(dig);
System.Console.WriteLine(result);