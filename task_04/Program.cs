/*Задача 8: Напишите программу, которая на вход 
принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/
Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;
if (num < 0)
{
    Console.WriteLine(" Число должно быть больше 0 ");
}
else if (num == 1)
{
    Console.WriteLine(" Нет четных чисел ");
}

else
{


    while (count < num)
    {
        count += 2;
        Console.Write((count) + " ");
    }
}
