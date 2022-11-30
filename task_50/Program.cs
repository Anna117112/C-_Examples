/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
[0][1][2][3]
1 4 7 2
[4][5][6][7]
5 9 2 3
[8][9][10][11]
8 4 2 4

9 -> 4
5 -> 9

*/

int[,] generate2DArray(int lengthRow, int lengthCol)

{
    int[,] array = new int[lengthRow, lengthCol];
    for (int i = 0; i < lengthRow; i++)
    {
        for (int j = 0; j < lengthCol; j++)
        {
            array[i, j] = new Random().Next(1, 10 + 1);
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

void FindNumber(int[,] array, int pos)
{
    int result = 0;
    int count = 0;
    long arrayNumbers = (array.GetLongLength(0) * array.GetLongLength(1)) - 1;

    if (pos > arrayNumbers)
    {
        System.Console.WriteLine($" {pos} - > такого числа в массиве нет");
    }
    else
    {

        for (int i = 0; i < array.GetLength(0); i++)
        {
            if (pos > count)

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (pos == (i + j))
                    {
                        result = array[i, j];
                    }
                    count++;
                }

        }
        System.Console.WriteLine($" {pos} - > {result} ");
    }


}


int[,] array = generate2DArray(3, 4);

FindNumber(array, 12);
print2dArray(array);
