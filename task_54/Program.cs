/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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

int[,] MaxToMin(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int count = 0;
        int max = 0;
        while (count < array.GetLength(1))
        {
            max = array[i, count];

            for (int j = count + 1; j < array.GetLength(1); j++)
            {


                if (max < array[i, j])
                {
                    max = array[i, j];
                    array[i, j] = array[i, count];
                    array[i, count] = max;
                }
                else
                {
                    array[i, count] = max;

                }
            }
            count++;

        }

    }
    return array;
}

int[,] array = generate2DArray(2, 3);
print2dArray(array);
int[,] newArray = MaxToMin(array);
print2dArray(newArray);

