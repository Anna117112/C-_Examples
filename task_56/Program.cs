/*  
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

*/
int[,] generate2DArray(int lengthRow, int lengthCol)
{
    int[,] array = new int[lengthRow, lengthCol];
    for (int i = 0; i < lengthRow; i++)
    {
        for (int j = 0; j < lengthCol; j++)
        {
            array[i, j] = new Random().Next(0, 5 + 1);
        }
    }
    return array;
}
void printColor(string information, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(information);
    Console.ResetColor();
}
void print2dArray(int[,] array)
{
    Console.Write("\t");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        printColor(i + "\t", ConsoleColor.DarkYellow);
    }
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        printColor(i + "\t", ConsoleColor.DarkYellow);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void SummRols(int[,] array)
{
    int summ = 0;
    int minSummRols = 0;
    int rols = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)

        {
            summ = summ + array[i, j];


        }

        if (summ < minSummRols)
        {
            minSummRols = summ;
            rols = i;
        }
        else
        {
            minSummRols = summ;
            rols = i;
        }
        summ = 0;

    }
    System.Console.WriteLine(rols);
    System.Console.WriteLine(minSummRols);

}


int[,] array = generate2DArray(4, 3);
print2dArray(array);
SummRols(array);


