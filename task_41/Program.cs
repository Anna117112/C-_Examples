/*
 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/


void CuontNumdersMoreZerro(String message)
{
    System.Console.WriteLine(message);

    int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int count = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;

        }
        System.Console.Write(arr[i] + " ");
    }

    Console.WriteLine($"->  {count}");
}
CuontNumdersMoreZerro("Введите числа через пробел");